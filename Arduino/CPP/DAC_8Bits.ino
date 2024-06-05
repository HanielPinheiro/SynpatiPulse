/* Bkp, pode ser que novo metodo fique lento e atrase os pulsos
 * void SetPotentiometerValue(int value) {
  if (value == 0) SetCurrent_50();
  else if (value == 1) SetCurrent_100();
  else if (value == 2) SetCurrent_150();
  else if (value == 3) SetCurrent_200();
  else if (value == 4) SetCurrent_250();
  else if (value == 5) SetCurrent_300();
  else if (value == 6) SetCurrent_350();
  else if (value == 7) SetCurrent_400();
  else if (value == 8) SetCurrent_450();
  else if (value == 9) SetCurrent_500();
  else if (value == 10) SetCurrent_550();
  else if (value == 11) SetCurrent_600();
  else SetCurrent_650();
}
*/
void SetPotentiometerValue(char* nomCurr){
  if (strcmp(nomCurr, "50") == 0) SetCurrent_50();
  else if   (strcmp(nomCurr, "100") == 0)SetCurrent_100();
  else if   (strcmp(nomCurr, "150") == 0)SetCurrent_150();
  else if   (strcmp(nomCurr, "200") == 0)SetCurrent_200();
  else if   (strcmp(nomCurr, "250") == 0)SetCurrent_250();
  else if   (strcmp(nomCurr, "300") == 0)SetCurrent_300();
  else if   (strcmp(nomCurr, "350") == 0)SetCurrent_350();
  else if   (strcmp(nomCurr, "400") == 0)SetCurrent_400();
  else if   (strcmp(nomCurr, "450") == 0)SetCurrent_450();
  else if   (strcmp(nomCurr, "500") == 0)SetCurrent_500();
  else if   (strcmp(nomCurr, "550") == 0)SetCurrent_550();
  else if   (strcmp(nomCurr, "600") == 0)SetCurrent_600();
  else SetCurrent_650();
}

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

void SetCurrent_50() {
// digitalWrite(Ladder_0, 1);
//  digitalWrite(Ladder_1, 0);
//  digitalWrite(Ladder_2, 0);
//  digitalWrite(Ladder_3, 1);
//  digitalWrite(Ladder_4, 1);
//  digitalWrite(Ladder_5, 0);
//  digitalWrite(Ladder_6, 0);
//  digitalWrite(Ladder_7, 0);
  
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_100() {
//  digitalWrite(Ladder_0, 1);
//  digitalWrite(Ladder_1, 1);
//  digitalWrite(Ladder_2, 1);
//  digitalWrite(Ladder_3, 1);
//  digitalWrite(Ladder_4, 1);
//  digitalWrite(Ladder_5, 0);
//  digitalWrite(Ladder_6, 0);
//  digitalWrite(Ladder_7, 0);

  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_150() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 1);
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
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_250() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 1);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 1);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_300() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 1);
  digitalWrite(Ladder_7, 0);
}

void SetCurrent_350() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_400() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_450() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_500() {
  digitalWrite(Ladder_0, 1);
  digitalWrite(Ladder_1, 1);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 0);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_550() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_600() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 1);
  digitalWrite(Ladder_4, 0);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}

void SetCurrent_650() {
  digitalWrite(Ladder_0, 0);
  digitalWrite(Ladder_1, 0);
  digitalWrite(Ladder_2, 0);
  digitalWrite(Ladder_3, 0);
  digitalWrite(Ladder_4, 1);
  digitalWrite(Ladder_5, 1);
  digitalWrite(Ladder_6, 0);
  digitalWrite(Ladder_7, 1);
}
