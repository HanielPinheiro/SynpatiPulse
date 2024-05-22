void ParseCommands(char target) {
  
  if (target == CONTROL_RESET_BOARD)  //D>
  {    
    Serial.end();
    asm ("jmp (0x0000)");
  }

  if (target == CONTROL_RESET_INSTRUCTION)  //R>
  {
    Serial_ResetBuffer();
  
    pulseCounter = 0;

    InterpulseLengths[numOfPulses] = { NULL };
    Currents[numOfPulses] = { NULL };
    Polarities[numOfPulses] = { NULL };
    PulseLengths[numOfPulses] = { NULL };

    HasInstruction = false;
    IsReading = false;
    IsRunning = false;
    StopPulses();
    
    Serial.println("Reseted");
  }

  if (target == CONTROL_START_ROUTINE)  //J>
  {
    Serial.println("Start Routine");
    if (!IsReading && HasInstruction)
    {
      SetPotentiometerValue(Currents[0]);
      IsRunning = true;
      Serial.println("Routine Enabled");
    }
  }

  if (target == CONTROL_STOP_ROUTINE)  //K>
  {
    Serial.println("Stop Routine");
    if (IsRunning && !IsReading && HasInstruction)
    {
      IsRunning = false;
      Serial.println("Routine Disabled");
    }
  }

  if (target == CONTROL_READ_INSTRUCTIONS)  //L>
  { Serial.println("Start Read Instructions");
    if (!IsRunning && !HasInstruction) {
      IsReading = true;
      Serial.println("Read Routine Enabled");
    }
  }

  if (target == CONTROL_STOP_READ_INSTRUCTIONS)  //M>
  {
    Serial.println("Stop Read Instructions");
    if (!IsRunning && IsReading && !HasInstruction) {
      IsReading = false;
      HasInstruction = true;
      Serial.println("Read Routine Disabled");
      Serial.print("Saved data: "); Serial.println(pulseCounter);
    }
  }
}
// =========================================================
void ParseInstruction(char* data) {
  char item[6];
  int ctItem = 0;
  int stepper = 0;
  int tempPolarity = 0;
  char *token = strtok(data, INSTRUCTION_SEPARATOR); //SET = ignore

  token = strtok(NULL, INSTRUCTION_SEPARATOR);
  SetCurrentValueToArr(token);

  token = strtok(NULL, INSTRUCTION_SEPARATOR);
  if (strcmp(token, INSTRUCTION_POLARITY_P) == 0)tempPolarity = 1; else tempPolarity = 0;
  Polarities[pulseCounter] = tempPolarity;

  token = strtok(NULL, INSTRUCTION_SEPARATOR);
  GetTimeFromInstruction(token, strlen(token), PulseLengths, PulseLengthsFractional, PulseLengthsMeasure);

  token = strtok(NULL, INSTRUCTION_SEPARATOR);
  GetTimeFromInstruction(token, strlen(token), InterpulseLengths, InterpulseLengthsFractional, InterpulseLengthsMeasure);

  pulseCounter++;
  Serial.println("Parsed");
}
// =========================================================
void GetTimeFromInstruction(char *data, int siz, int* lengths, int* fracs, int* measures)
{
  double intPart;
  double fractPart = modf(atof(data), &intPart);
  fractPart *=1000;
  
  int measureUnity = 0;

  for (int i = 0; i < siz; i++){
    if (data[i] == INSTRUCTION_UNITY_MS || data[i] == INSTRUCTION_UNITY_US || data[i] == INSTRUCTION_UNITY_S)     
      measureUnity = data[i];   
  }
  
    lengths[pulseCounter] = (int)intPart;
    fracs[pulseCounter] = (int)fractPart;
    measures[pulseCounter] = measureUnity;
      
  Serial.print("Data: "); Serial.println(data);
  Serial.print("Integer: "); Serial.println(lengths[pulseCounter]);
  Serial.print("Frac: "); Serial.println(fracs[pulseCounter]);
  Serial.print("Measure: "); Serial.println(measures[pulseCounter]);
}
// =========================================================
void SetCurrentValueToArr(char *nomCurr)
{
  Serial.print("nomCurr: ");Serial.println(nomCurr);
  if (strcmp(nomCurr, "50") == 0) Currents[pulseCounter] = 0;
  else if   (strcmp(nomCurr, "100") == 0)Currents[pulseCounter] = 1;
  else if   (strcmp(nomCurr, "150") == 0)Currents[pulseCounter] = 2;
  else if   (strcmp(nomCurr, "200") == 0)Currents[pulseCounter] = 3;
  else if   (strcmp(nomCurr, "250") == 0)Currents[pulseCounter] = 4;
  else if   (strcmp(nomCurr, "300") == 0)Currents[pulseCounter] = 5;
  else if   (strcmp(nomCurr, "350") == 0)Currents[pulseCounter] = 6;
  else if   (strcmp(nomCurr, "400") == 0)Currents[pulseCounter] = 7;
  else if   (strcmp(nomCurr, "450") == 0)Currents[pulseCounter] = 8;
  else if   (strcmp(nomCurr, "500") == 0)Currents[pulseCounter] = 9;
  else if   (strcmp(nomCurr, "550") == 0)Currents[pulseCounter] = 10;
  else if   (strcmp(nomCurr, "600") == 0)Currents[pulseCounter] = 11;
  else Currents[pulseCounter] = 12;
  Serial.print("Current: ");Serial.println(Currents[pulseCounter]);
}
