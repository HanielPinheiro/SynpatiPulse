void ParsePulseFromArray()
{
  char* data = ArrayWithPulses[PulseCounter];
  int stage = 0;
  int intPart = 0;
  int fractPart = 0;
  int measureUnity = 0;
  int multiplier = 100;  // Inicial para o número inteiro
  bool isFraction = false;

  for (int i = 0; data[i] != '\0'; i++) {
    char c = data[i];
    //Serial.print(F("<dado>: "));    Serial.print(i); Serial.print(" - "); Serial.println(c);

    if (c != INSTRUCTION_SEPARATOR) {

      if (c >= '0' && c <= '9') {
        if (isFraction) {
          fractPart += (c - '0') * multiplier;
          multiplier /= 10;
        }
        else intPart = intPart * 10 + (c - '0');
      }

      else if (c == '.') isFraction = true;

      else if (c == INSTRUCTION_UNITY_MS || c == INSTRUCTION_UNITY_US || c == INSTRUCTION_UNITY_S) measureUnity = c;
    }
    else {
      if (stage == 0) Pulse[0] = intPart;  // Armazena o valor de corrente
      else if (stage == 1) Pulse[1] = intPart;  // Armazena a polaridade
      else if (stage == 2) {  // Processa a largura do pulso
        Pulse[2] = intPart;
        Pulse[3] = fractPart;
        Pulse[4] = measureUnity;
      }

      intPart = 0;
      fractPart = 0;
      multiplier = 100;
      isFraction = false;
      stage++;
    }
  }
  if (stage == 3) {
    Pulse[5] = intPart;
    Pulse[6] = fractPart;
    Pulse[7] = measureUnity;
  }

  /* for (int a = 0; a < 8; a++) {
     Serial.print(Pulse[a]);
     if (a == 7) Serial.println(); else Serial.print(F(" - "));
    }*/

  PulseCounter++;
  if (PulseCounter == ArrayCounter && PeriodicMode) PulseCounter = 0;
}
