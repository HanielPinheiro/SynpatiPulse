void setup() {
  pinMode(Ladder_0, OUTPUT);
  pinMode(Ladder_1, OUTPUT);
  pinMode(Ladder_2, OUTPUT);
  pinMode(Ladder_3, OUTPUT);
  pinMode(Ladder_4, OUTPUT);
  pinMode(Ladder_5, OUTPUT);
  pinMode(Ladder_6, OUTPUT);
  pinMode(Ladder_7, OUTPUT);

  pinMode(CLOCK_1_PIN, OUTPUT);
  pinMode(CLOCK_2_PIN, OUTPUT);
  digitalWrite(CLOCK_1_PIN, LOW);
  digitalWrite(CLOCK_2_PIN, HIGH);
  SetCurrent_0();

  Serial.begin(115200);
  Serial.println(F("<Ready>"));
}

//<100$1$100U$200M>
//<500$0$70U$125.9M>
//<250$1$48U$78.3M>
//<350$0$250U$130.010M>


void loop()
{
  if (IsRunning)
  {
    if (!IsWaiting)
    {
      RunRoutine();
      IsWaiting = true;

      if (!PeriodicMode && PulseCounter == ArrayCounter) {
        if (ParsedCounter == 0)
        {
          IsRunning = false;
          IsWaiting = false;
          Serial.println(F("<FimDoTremDePulsos>"));
        }
        else {
          Serial.println(F("<HasMoreData>"));
          ArrayCounter = ParsedCounter;
          PulseCounter = 0;
          ParsedCounter = 0;
        }
      }

      if (PeriodicMode && ArrayCounter == 1) IsWaiting = false;
      Serial.println(F("<Executed>"));
    }
    else if ( ArrayCounter > 1)
    {
      ParsePulseFromArray();
      IsWaiting = false;
    }
  }

  if (millis() - verifySerial >= 50)
  {
    verifySerial = millis();
    static boolean recvInProgress = false;
    static int index = 0;
    char startMarker = '<';
    char endMarker = '>';
    char readedChar;

    while (Serial.available() > 0 && newData == false) {
      readedChar = Serial.read();
      if (recvInProgress == true) {
        if (readedChar != endMarker) {
          tempData[index] = readedChar;
          index++;
          if (index >= bufferSize) {
            index = bufferSize - 1;
          }
        }
        else {
          tempData[index] = '\0'; // terminate the string
          recvInProgress = false;
          counterBuffer = index;
          index = 0;
          newData = true;
        }
      }
      else if (readedChar == startMarker) {
        recvInProgress = true;
      }
    }

    if (newData == true) {
      Serial.print(F("ReceivedData:")); Serial.println(tempData);
      if (counterBuffer == 1) ParseCommands(tempData[0]);

      if (counterBuffer > 1) {

        if (IsReading)
        {
          if (!ArrayIsFull)
          {
            if (ArrayCounter < numOfPulses)
            {
              memcpy(&ArrayWithPulses[ArrayCounter][0], tempData, counterBuffer);
              ArrayCounter++;

              if (ArrayCounter == numOfPulses) ArrayIsFull = true;
            }

          }
          else Serial.println(F("<ArrayFull>"));
        }

        if (IsRunning) {
          Serial.print(F("<Add> "));
          memcpy(&ArrayWithPulses[ParsedCounter][0], tempData, counterBuffer);
          Serial.println(ArrayWithPulses[ParsedCounter]);
          ParsedCounter++;
        }
      }

      newData = false;
    }
  }
}
