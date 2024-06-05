
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
  Serial.println("Ready");
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

void loop() //SET$100$1$100.050M$400.108U>
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
      totalTime += 1000;
      if (totalTime > PulseTrainInterval) IsWaiting = false;
    }
  }
  if (millis() - verifyParse >= 100)
  {
    verifyParse = millis();
    if (PulseTrainMode && IsRunning && IsWaiting && NeedToParse) ParsePulseTrainInstruction();
  }

  if (millis() - verifySerial >= 50)
  {

    verifySerial = millis();

    if (Serial.available()) {
      int readedBytes = Serial.readBytesUntil(INSTRUCTION_END, tempData, bufferSize);
      
      int arraySize = 0;
      for (int i = 0; i < readedBytes; i++)
        if (tempData[i] != newLine && tempData[i] != 0x00)  arraySize++;

      if (arraySize > 0)
      {
        if (arraySize == 1)  ParseCommands(tempData[0]);
        else if (IsReading)
        {
          if (PulseMode)ParseInstruction(tempData);
          else if (PulseTrainMode)
          {
            if (PulseTrainInterval > 0 && !PulseTrainArrayIsFull)
            {
              if (PulseCounter < numOfPulses && PulseTrainCounter < numPulseTrains)
              {
                PulseTrains[PulseTrainCounter][PulseCounter] = tempData;
                PulseCounter++;
                if (PulseCounter == numOfPulses)
                {
                  PulseTrainCounter++;
                  PulseCounter = 0;
                  if (PulseTrainCounter == numPulseTrains)
                  {
                    PulseTrainArrayIsFull = true;
                    PulseTrainCounter = 0;
                  }
                }
              }

            }
            else { //reading pulse train interval, removing initial two digits: PT11000 to 11000, and parsing to int
              char *pulseInterval = tempData;
              for (; *pulseInterval != '\0'; pulseInterval++) *pulseInterval = *(pulseInterval + 2);
              *pulseInterval = '\0';
              PulseTrainInterval = atoi(pulseInterval);
            }
          }
        }
      }
      Serial_ResetBuffer();
    }
  }
}

// =========================================================
void Serial_ResetBuffer() {
  memset(tempData, 0, bufferSize);
  counterBuffer = 0;
}
