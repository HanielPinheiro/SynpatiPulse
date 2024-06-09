
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
  Serial.println("<Ready>");
}

void StopPulses() {
  digitalWrite(CLOCK_1_PIN, LOW);
  digitalWrite(CLOCK_2_PIN, HIGH);
  SetCurrent_0();
}

unsigned long int verifySerial = 0;
unsigned long int verifyParse = 0;
unsigned long int verifyInterval = 0;
unsigned long int totalTime = 0;
boolean newData = false;

void loop() //<SET$100$1$100.050M$400.108U><SET$350$0$322.655M$123.456U><SET$450$1$789.012M$345.678U>
{
  if (IsRunning)
  {
    if ((PulseTrainMode && !IsWaiting && !NeedToParse) || PulseMode)
      RunRoutine();
  }

  if (millis() - verifyInterval >= 1000)
  {
    verifyInterval = millis();
      if (IsWaiting)
      {
      Serial.println("Pause");
      totalTime += 1000;
      if (totalTime > PulseTrainInterval)
      {
        IsWaiting = false;
        totalTime = 0;
      }
      }
  }
  if (millis() - verifyParse >= 100)
  {
     verifyParse = millis();
      if (PulseTrainMode && IsRunning && IsWaiting && NeedToParse) {
       Serial.println("Parse");
       ParsePulseTrainInstruction();
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
      Serial.print("ReceivedData:"); Serial.println(tempData);
      if (counterBuffer == 1) ParseCommands(tempData[0]);
      if (counterBuffer > 1)
      {
        if (IsReading)
        {
          if (PulseMode) ParseInstruction(tempData);
          else if (PulseTrainMode)
          {
            if (PulseTrainInterval > 0) SetDataToArray();
            else  PulseTrainInterval = atoi(tempData);
          }
        }
      }
      newData = false;
    }
  }
}

// =========================================================
void SetDataToArray() {
  if (!PulseTrainArrayIsFull && PulseTrainCounter < numOfPulses)
  {    
    PulseTrains[PulseTrainCounter] = tempData;
    PulseTrainCounter++;    
    if (PulseTrainCounter == numOfPulses) PulseTrainArrayIsFull = true;    
  }
  //Serial.print("Data in Array: ");Serial.println(PulseTrains[PulseTrainCounter-1]);
}
