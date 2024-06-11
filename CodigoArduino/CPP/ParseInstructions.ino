void ParsePulseFromArray()
{
    /*
    Tenho que converter o array[pos] para pulse durante o intervalo entre pulsos
    Contar o avanço
    Se chegar no ultimo elemento do pulso, espero a proxima sequencia → Software C#
    */
    ParseInstruction(ArrayWithPulses[PulseCounter].c_str());
    PulseCounter++;
}

// =========================================================

void ParseInstruction(char* data) {
  char *token = strtok(data, INSTRUCTION_SEPARATOR);
  
    token = strtok(NULL, INSTRUCTION_SEPARATOR);
    Pulse[0] = atoi(token); //mandar o token como numero direto do c#
    Serial.write("Current: "); Serial.write(Pulse[0]);

    token = strtok(NULL, INSTRUCTION_SEPARATOR);
    Pulse[1] = atoi(token);
    Serial.write("Polarity: "); Serial.write(Pulse[1]);

    token = strtok(NULL, INSTRUCTION_SEPARATOR);
    GetTimeFromInstruction(token, strlen(token), 2); //,PulseLengthsIntegerPart, PulseLengthsFractionalPart, PulseLengthsMeasureUnity);

    token = strtok(NULL, INSTRUCTION_SEPARATOR);
    GetTimeFromInstruction(token, strlen(token), 5);//, InterpulseLengthsIntegerPart, InterpulseLengthsFractionalPart, InterpulseLengthsMeasureUnity);

    PulseCounter++;
  Serial.write("<Parsed>");
}

// =========================================================
void GetTimeFromInstruction(char *data, int siz, int index) //int* lengths, int* fracs, int* measures)
{
  Serial.write(data);
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

  Serial.write("Integer: "); Serial.write(Pulse[index]);
  Serial.write("Frac: "); Serial.write( Pulse[index + 1]);
  Serial.write("Measure: "); Serial.write(Pulse[index + 2]);
}
