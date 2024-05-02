void ParseInstruction(char* data) {
  int tempPolarity = 0;
  char *token = strtok(data, INSTRUCTION_SEPARATOR);
if(!strcmp(token,INSTRUCTION_SET))
{   
  token = strtok(NULL, INSTRUCTION_SEPARATOR);
  SetCurrentValueToArr(token);

  token = strtok(NULL, INSTRUCTION_SEPARATOR);
  if (strcmp(token, INSTRUCTION_POLARITY_P) == 0)tempPolarity = 1; else tempPolarity = 0;
  PulsePolarities[pulseCounter] = tempPolarity;

  token = strtok(NULL, INSTRUCTION_SEPARATOR);
  GetTimeFromInstruction(token, strlen(token), PulseLengthsIntegerPart, PulseLengthsFractionalPart, PulseLengthsMeasureUnity);

  token = strtok(NULL, INSTRUCTION_SEPARATOR);
  GetTimeFromInstruction(token, strlen(token), InterpulseLengthsIntegerPart, InterpulseLengthsFractionalPart, InterpulseLengthsMeasureUnity);

  pulseCounter++;
}
else { // token = LORENZ → LORENZ$50$5000$0 → MODELO LORENZ $ CORRENTE $ INTERVALO ENTRE TRENS DE PULSO $ PULSOS POSITIVOS (0) OU ALTERNADOS (1)
  if(LorenzBatteryInterval == 0)
  {
    token = strtok(NULL, INSTRUCTION_SEPARATOR);
    SetCurrentValueToArr(token);
    
    token = strtok(NULL, INSTRUCTION_SEPARATOR);
    LorenzBatteryInterval = atoi(token);  
    
    token = strtok(NULL, INSTRUCTION_SEPARATOR);
    LorenzMode = atoi(token);
  }
  else{
    if(LorenzCounter < numPulseTrains)
    {
     token = strtok(NULL, INSTRUCTION_SEPARATOR);
     LorenzPulseTrainValues[LorenzCounter] = atof(token);
     
     Serial.print("Token: ");
     Serial.println(LorenzPulseTrainValues[LorenzCounter]);
     
     LorenzCounter++;
    }
    else LorenzCounter = 0;
  }
    
}

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
  if (strcmp(nomCurr, "50") == 0) PulseCurrents[pulseCounter] = 0;
  else if   (strcmp(nomCurr, "100") == 0)PulseCurrents[pulseCounter] = 1;
  else if   (strcmp(nomCurr, "150") == 0)PulseCurrents[pulseCounter] = 2;
  else if   (strcmp(nomCurr, "200") == 0)PulseCurrents[pulseCounter] = 3;
  else if   (strcmp(nomCurr, "250") == 0)PulseCurrents[pulseCounter] = 4;
  else if   (strcmp(nomCurr, "300") == 0)PulseCurrents[pulseCounter] = 5;
  else if   (strcmp(nomCurr, "350") == 0)PulseCurrents[pulseCounter] = 6;
  else if   (strcmp(nomCurr, "400") == 0)PulseCurrents[pulseCounter] = 7;
  else if   (strcmp(nomCurr, "450") == 0)PulseCurrents[pulseCounter] = 8;
  else if   (strcmp(nomCurr, "500") == 0)PulseCurrents[pulseCounter] = 9;
  else if   (strcmp(nomCurr, "550") == 0)PulseCurrents[pulseCounter] = 10;
  else if   (strcmp(nomCurr, "600") == 0)PulseCurrents[pulseCounter] = 11;
  else PulseCurrents[pulseCounter] = 12;
  Serial.print("Current: ");Serial.println(PulseCurrents[pulseCounter]);
}

// =========================================================
void ParsePulseTrainFromStr(){
  /*
 char *token = strtok(LorenzPulseTrainStr, INSTRUCTION_COMMA_SEPARATOR);
 int i = 0;
  while (token != NULL && i < numPulseTrains) {
    LorenzPulseTrainValues[i] = atof(token);
    
    Serial.print("Token: ");
    Serial.println(LorenzPulseTrainValues[i]);

    token = strtok(NULL, INSTRUCTION_COMMA_SEPARATOR);
    i++;
  }*/
}
