void ParsePulseTrainInstruction()
{
  if (PulseTrainArrayIsFull /*&& PulseTrainCounter < numPulseTrains*/)
  {    
   //while (PulseCounter < numOfPulses)    
   /*for(int i =0; i < numOfPulses; i++)
         ParseInstruction(PulseTrains[i].c_str());     
    */
    //PulseTrainCounter++;
    PulseCounter = numOfPulses; 
    NeedToParse = false;
  }
}

// =========================================================

void ParseInstruction(char* data) {  
//  Serial.println(data);
  char *token = strtok(data, INSTRUCTION_SEPARATOR);

  if (!strcmp(token, INSTRUCTION_SET))
  {
    token = strtok(NULL, INSTRUCTION_SEPARATOR);    
    Pulse[0] = atoi(token); //mandar o token como numero direto do c#
    Serial.print("Current: "); Serial.println(Pulse[0]);

    token = strtok(NULL, INSTRUCTION_SEPARATOR);
    Pulse[1] = atoi(token);
    Serial.print("Polarity: "); Serial.println(Pulse[1]);

    token = strtok(NULL, INSTRUCTION_SEPARATOR);    
    GetTimeFromInstruction(token, strlen(token), 2); //,PulseLengthsIntegerPart, PulseLengthsFractionalPart, PulseLengthsMeasureUnity);

    token = strtok(NULL, INSTRUCTION_SEPARATOR);    
    GetTimeFromInstruction(token, strlen(token), 5);//, InterpulseLengthsIntegerPart, InterpulseLengthsFractionalPart, InterpulseLengthsMeasureUnity);

    PulseCounter++;
  }
  Serial.println("<Parsed>");
}

// =========================================================
void GetTimeFromInstruction(char *data, int siz, int index) //int* lengths, int* fracs, int* measures)
{
  Serial.println(data);
  double intPart;
  double fractPart = modf(atof(data), &intPart);
  fractPart *= 1000;

  int measureUnity = 0;

  for (int i = 0; i < siz; i++) {
    if (data[i] == INSTRUCTION_UNITY_MS || data[i] == INSTRUCTION_UNITY_US || data[i] == INSTRUCTION_UNITY_S)
      measureUnity = data[i];
  }

  //lengths[PulseCounter] = (int)intPart;
  //fracs[PulseCounter] = (int)fractPart;
  //measures[PulseCounter] = measureUnity;
  Pulse[index] = (int)intPart;
  Pulse[index+1]= (int)fractPart;
  Pulse[index+2]= measureUnity;

  Serial.print("Integer: "); Serial.println(Pulse[index]);
  Serial.print("Frac: "); Serial.println( Pulse[index+1]);
  Serial.print("Measure: "); Serial.println(Pulse[index+2]);
}
