
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
  Serial.println("Stimulator is ready");
}

void StopPulses() {
  digitalWrite(CLOCK_1_PIN, LOW);
  digitalWrite(CLOCK_2_PIN, HIGH);
  SetCurrent_0();
}

unsigned long int timeMicros = 0;
unsigned long int timeMilis = 0;
unsigned long int timeSeconds = 0;

void loop()
{
  //SET$150$+$200U$999.8M> //Continuar testes
  //SET$450$-$200.8M$1.2S>
  if (IsRunning) {
    RunRoutine();
    //Serial.println(micros());
  }
  if (millis() - timeMilis >= 50)
  {
    timeMilis = millis();

    if (Serial.available()) {
      int readedBytes = Serial.readBytesUntil(INSTRUCTION_END, tempData, bufferSize);

      int arraySize = 0;
      for (int i = 0; i < readedBytes; i++)
        if (tempData[i] != newLine && tempData[i] != 0x00)
          arraySize++;

      if (arraySize > 0)
      {
        if (arraySize == 1)  ParseCommands(tempData[0]);
        else if (IsReading) ParseInstruction(tempData);
      }
    }
    
    Serial_ResetBuffer();
    
  }
}

// =========================================================
void Serial_ResetBuffer() {
  memset(tempData, 0, bufferSize);
  counterBuffer = 0;
}
