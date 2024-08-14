void TestRoutine() {
  SetCurrent_300(); //<300$1$15U$1M>
  digitalWrite(CLOCK_1_PIN, LOW);
  digitalWrite(CLOCK_2_PIN, LOW);
  delayMicroseconds(15);
  digitalWrite(CLOCK_1_PIN, LOW);
  digitalWrite(CLOCK_2_PIN, HIGH);
  delay(1);

  SetCurrent_200(); //<200$1$30U$5M>
  digitalWrite(CLOCK_1_PIN, LOW);
  digitalWrite(CLOCK_2_PIN, LOW);
  delayMicroseconds(30);
  digitalWrite(CLOCK_1_PIN, LOW);
  digitalWrite(CLOCK_2_PIN, HIGH);
  delay(5);
}
//1,54 e 5,57
//1,27 e 5,29
//1,14 e 5,16
//1,09 e 5,10

//1,10 e 5,12 - 18,8u e 29,8u

//1,07 e 5,07
//1,05 e 5,06 - 16u e 29,8u

//<200$1$3S$1S>
//<300$1$1S$3S>
