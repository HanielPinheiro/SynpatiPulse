void ParsePulseTrainInstruction()
{
  if(PulseTrainArrayIsFull)
  {
   while(PulseCounter < numOfPulses)
    ParseInstruction(PulseTrains[PulseTrainCounter][PulseCounter]);
   
   NeedToParse = false;
   PulseTrainCounter++;
   PulseCounter = 0; // sai da ParseInstruction como 50 no final
  }
}

// =========================================================

void ParseInstruction(char* data) {
  int tempPolarity = 0;
  char *token = strtok(data, INSTRUCTION_SEPARATOR);
  if (!strcmp(token, INSTRUCTION_SET))
  {
    token = strtok(NULL, INSTRUCTION_SEPARATOR);
    PulseCurrents[PulseCounter] = token; 
    //SetCurrentValueToArr(token); //anterior 

    token = strtok(NULL, INSTRUCTION_SEPARATOR);
    tempPolarity = atoi(token);
    PulsePolarities[PulseCounter] = tempPolarity;

    token = strtok(NULL, INSTRUCTION_SEPARATOR);
    GetTimeFromInstruction(token, strlen(token), PulseLengthsIntegerPart, PulseLengthsFractionalPart, PulseLengthsMeasureUnity);

    token = strtok(NULL, INSTRUCTION_SEPARATOR);
    GetTimeFromInstruction(token, strlen(token), InterpulseLengthsIntegerPart, InterpulseLengthsFractionalPart, InterpulseLengthsMeasureUnity);

    PulseCounter++;
  }
  Serial.println("Parsed");
}

// =========================================================
void GetTimeFromInstruction(char *data, int siz, int* lengths, int* fracs, int* measures)
{
  double intPart;
  double fractPart = modf(atof(data), &intPart);
  fractPart *= 1000;

  int measureUnity = 0;

  for (int i = 0; i < siz; i++) {
    if (data[i] == INSTRUCTION_UNITY_MS || data[i] == INSTRUCTION_UNITY_US || data[i] == INSTRUCTION_UNITY_S)
      measureUnity = data[i];
  }

  lengths[PulseCounter] = (int)intPart;
  fracs[PulseCounter] = (int)fractPart;
  measures[PulseCounter] = measureUnity;

  //Serial.print("Data: "); Serial.println(data);
  Serial.print("Integer: "); Serial.println(lengths[PulseCounter]);
  Serial.print("Frac: "); Serial.println(fracs[PulseCounter]);
  Serial.print("Measure: "); Serial.println(measures[PulseCounter]);//*/
}

// =========================================================
/*
void SetCurrentValueToArr(char *nomCurr)
{
  
  //Serial.print("nomCurr: "); Serial.println(nomCurr);
  if (strcmp(nomCurr, "50") == 0) PulseCurrents[PulseCounter] = 0;
  else if   (strcmp(nomCurr, "100") == 0)PulseCurrents[PulseCounter] = 1;
  else if   (strcmp(nomCurr, "150") == 0)PulseCurrents[PulseCounter] = 2;
  else if   (strcmp(nomCurr, "200") == 0)PulseCurrents[PulseCounter] = 3;
  else if   (strcmp(nomCurr, "250") == 0)PulseCurrents[PulseCounter] = 4;
  else if   (strcmp(nomCurr, "300") == 0)PulseCurrents[PulseCounter] = 5;
  else if   (strcmp(nomCurr, "350") == 0)PulseCurrents[PulseCounter] = 6;
  else if   (strcmp(nomCurr, "400") == 0)PulseCurrents[PulseCounter] = 7;
  else if   (strcmp(nomCurr, "450") == 0)PulseCurrents[PulseCounter] = 8;
  else if   (strcmp(nomCurr, "500") == 0)PulseCurrents[PulseCounter] = 9;
  else if   (strcmp(nomCurr, "550") == 0)PulseCurrents[PulseCounter] = 10;
  else if   (strcmp(nomCurr, "600") == 0)PulseCurrents[PulseCounter] = 11;
  else PulseCurrents[PulseCounter] = 12;
  Serial.print("Current: "); Serial.println(PulseCurrents[PulseCounter]);
}
*/
