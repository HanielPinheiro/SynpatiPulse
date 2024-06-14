void ParsePulseFromArray()
{
  //verifyDelay = millis();
  char data[bufferSize];
  memcpy(&data[0], &ArrayWithPulses[PulseCounter], bufferSize);
 
  ParseInstruction(data);
  PulseCounter++;
  if (PulseCounter == ArrayCounter && PeriodicMode) PulseCounter = 0;

  //verifyDelay = millis() -  verifyDelay;
  //Serial.print(F("<Delay> ")); Serial.println(verifyDelay);
}

// =========================================================

void ParseInstruction(char* data) {
  int value = PulseCounter + 1;
  Serial.print(F("<Parsing ")); Serial.print(value); Serial.print(F("> - ")); Serial.println(data);

  char *token = strtok(data, INSTRUCTION_SEPARATOR);
  Pulse[0] = atoi(token); //mandar o token como numero direto do c#
  //Serial.write("Current: "); Serial.println(Pulse[0]);

  token = strtok(NULL, INSTRUCTION_SEPARATOR);
  Pulse[1] = atoi(token);
  //Serial.write("Polarity: "); Serial.println(Pulse[1]);

  token = strtok(NULL, INSTRUCTION_SEPARATOR);
  GetTimeFromInstruction(token, strlen(token), 2); //,PulseLengthsIntegerPart, PulseLengthsFractionalPart, PulseLengthsMeasureUnity);

  token = strtok(NULL, INSTRUCTION_SEPARATOR);
  GetTimeFromInstruction(token, strlen(token), 5);//, InterpulseLengthsIntegerPart, InterpulseLengthsFractionalPart, InterpulseLengthsMeasureUnity);

  Serial.println(F("<Parsed>"));
}

// =========================================================
void GetTimeFromInstruction(char *data, int siz, int index) //int* lengths, int* fracs, int* measures)
{
  //Serial.println(data);

  double intPart;
  double fractPart = modf(atof(data), &intPart);
  fractPart *= 1000;

  int measureUnity = 0;

  for (int i = 0; i < siz; i++) {
    if (data[i] == INSTRUCTION_UNITY_MS || data[i] == INSTRUCTION_UNITY_US || data[i] == INSTRUCTION_UNITY_S)
      measureUnity = data[i];
  }
  Pulse[index] = (int)intPart;
  Pulse[index + 1] = (int)fractPart;
  Pulse[index + 2] = measureUnity;

  /*Serial.write("Integer: "); Serial.println(Pulse[index]);

    Serial.write("Frac: "); Serial.println( Pulse[index + 1]);

    Serial.write("Measure: "); Serial.println(Pulse[index + 2]);*/
}
