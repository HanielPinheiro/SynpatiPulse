//DAC 8 Bits para Resistores da versão que está com Fernando - 1k e 2k2

void SetCurrent_0() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_30() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_50() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}
void SetCurrent_75() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_100() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_150() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_200() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}
// A partir daqui tem que ter um valor pra + e -
void SetCurrent_250() {
  if (Pulse[1] == 0) {
    digitalWrite(Ladder_0, 0);
    digitalWrite(Ladder_1, 1);
    digitalWrite(Ladder_2, 0);
    digitalWrite(Ladder_3, 1);
    digitalWrite(Ladder_4, 0);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
  else { // Lado positivo do software
    digitalWrite(Ladder_0, 0);
    digitalWrite(Ladder_1, 1);
    digitalWrite(Ladder_2, 0);
    digitalWrite(Ladder_3, 1);
    digitalWrite(Ladder_4, 0);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
}

void SetCurrent_300() {
  if (Pulse[1] == 0) {
    digitalWrite(Ladder_0, 1);
    digitalWrite(Ladder_1, 1);
    digitalWrite(Ladder_2, 0);
    digitalWrite(Ladder_3, 1);
    digitalWrite(Ladder_4, 0);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
  else { // Lado positivo do software
    digitalWrite(Ladder_0, 1);
    digitalWrite(Ladder_1, 0);
    digitalWrite(Ladder_2, 1);
    digitalWrite(Ladder_3, 1);
    digitalWrite(Ladder_4, 0);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
}

void SetCurrent_350() {
    if (Pulse[1] == 0) {
    digitalWrite(Ladder_0, 1);
    digitalWrite(Ladder_1, 0);
    digitalWrite(Ladder_2, 1);
    digitalWrite(Ladder_3, 1);
    digitalWrite(Ladder_4, 0);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
  else { // Lado positivo do software
    digitalWrite(Ladder_0, 0);
    digitalWrite(Ladder_1, 1);
    digitalWrite(Ladder_2, 1);
    digitalWrite(Ladder_3, 1);
    digitalWrite(Ladder_4, 0);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
}

void SetCurrent_400() {
  if (Pulse[1] == 0) {
    digitalWrite(Ladder_0, 0);
    digitalWrite(Ladder_1, 1);
    digitalWrite(Ladder_2, 1);
    digitalWrite(Ladder_3, 1);
    digitalWrite(Ladder_4, 0);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
  else { // Lado positivo do software
    digitalWrite(Ladder_0, 1);
    digitalWrite(Ladder_1, 0);
    digitalWrite(Ladder_2, 0);
    digitalWrite(Ladder_3, 0);
    digitalWrite(Ladder_4, 1);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
}

void SetCurrent_450() {
  if (Pulse[1] == 0) {
    digitalWrite(Ladder_0, 0);
    digitalWrite(Ladder_1, 0);
    digitalWrite(Ladder_2, 0);
    digitalWrite(Ladder_3, 0);
    digitalWrite(Ladder_4, 1);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
  else { // Lado positivo do software
    digitalWrite(Ladder_0, 1);
    digitalWrite(Ladder_1, 1);
    digitalWrite(Ladder_2, 0);
    digitalWrite(Ladder_3, 0);
    digitalWrite(Ladder_4, 1);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
}

void SetCurrent_500() {
  if (Pulse[1] == 0) {
    digitalWrite(Ladder_0, 1);
    digitalWrite(Ladder_1, 0);
    digitalWrite(Ladder_2, 0);
    digitalWrite(Ladder_3, 0);
    digitalWrite(Ladder_4, 1);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
  else { // Lado positivo do software
    digitalWrite(Ladder_0, 0);
    digitalWrite(Ladder_1, 0);
    digitalWrite(Ladder_2, 1);
    digitalWrite(Ladder_3, 0);
    digitalWrite(Ladder_4, 1);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
}

void SetCurrent_550() {
if (Pulse[1] == 0) {
    digitalWrite(Ladder_0, 1);
    digitalWrite(Ladder_1, 1);
    digitalWrite(Ladder_2, 0);
    digitalWrite(Ladder_3, 0);
    digitalWrite(Ladder_4, 1);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
  else { // Lado positivo do software
    digitalWrite(Ladder_0, 0);
    digitalWrite(Ladder_1, 1);
    digitalWrite(Ladder_2, 1);
    digitalWrite(Ladder_3, 0);
    digitalWrite(Ladder_4, 1);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
}

void SetCurrent_600() {
if (Pulse[1] == 0) {
    digitalWrite(Ladder_0, 0);
    digitalWrite(Ladder_1, 0);
    digitalWrite(Ladder_2, 1);
    digitalWrite(Ladder_3, 0);
    digitalWrite(Ladder_4, 1);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
  else { // Lado positivo do software
    digitalWrite(Ladder_0, 0);
    digitalWrite(Ladder_1, 0);
    digitalWrite(Ladder_2, 0);
    digitalWrite(Ladder_3, 1);
    digitalWrite(Ladder_4, 1);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
}

void SetCurrent_650() {
 if (Pulse[1] == 0) {
    digitalWrite(Ladder_0, 1);
    digitalWrite(Ladder_1, 0);
    digitalWrite(Ladder_2, 1);
    digitalWrite(Ladder_3, 0);
    digitalWrite(Ladder_4, 1);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
  else { // Lado positivo do software
    digitalWrite(Ladder_0, 1);
    digitalWrite(Ladder_1, 0);
    digitalWrite(Ladder_2, 0);
    digitalWrite(Ladder_3, 1);
    digitalWrite(Ladder_4, 1);
    digitalWrite(Ladder_5, 1);
    digitalWrite(Ladder_6, 0);
    digitalWrite(Ladder_7, 0);
  }
}
//*/
