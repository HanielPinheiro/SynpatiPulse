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
  StopPulses();

  Serial.begin(115200);
  Serial.write("<Ready>");
  Serial.write(NEW_LINE);
}

void StopPulses() {
  digitalWrite(CLOCK_1_PIN, LOW);
  digitalWrite(CLOCK_2_PIN, HIGH);
  SetCurrent_0();
}
//<100$1$100U$200M>
//<500$0$70U$125.9M>
//<250$1$48U$78.3M>
//<350$0$250U$130.010M>


void loop()
{
  if (IsRunning && !IsWaiting) RunRoutine();

  if (IsWaiting && ArrayCounter > 1) {
      ParsePulseFromArray();
      IsWaiting = false;
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
      Serial.write("ReceivedData:"); Serial.write(tempData);
      Serial.write(NEW_LINE);
      if (counterBuffer == 1) ParseCommands(tempData[0]);

      if (counterBuffer > 1 && IsReading) {
        if (!ArrayIsFull)
        {
          if (ArrayCounter < numOfPulses)
          {
            ArrayWithPulses[ArrayCounter] = tempData;
            ArrayCounter++;
            if (ArrayCounter == numOfPulses) ArrayIsFull = true;
          }
        }  else
        {
          Serial.write("<ArrayFull>");
          Serial.write(NEW_LINE);
        }
      }

      newData = false;
    }
  }
}
