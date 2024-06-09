void RunRoutine() {
  if (PulseMode) ClassicRoutine();
  else if (PulseTrainMode && PulseTrainArrayIsFull) PulseTrainRoutine();
}
// =========================================================

void PulseTrainRoutine() {
  /*Serial.println("IN");
  Serial.println(PulseCounter);
  Serial.println(PulseTrainCounter);
  if (PulseTrainCounter < numPulseTrains)
  {*/
    ClassicRoutine();
    PulseCounter = 0;
    IsWaiting = true;
    NeedToParse = true;
/*  }
  else
  {
    ClassicRoutine();    
    PulseMode = false;
    PulseTrainMode = false;
    Serial.println("END");
  }
  Serial.println("OUT");
  Serial.println(PulseCounter);
  Serial.println(PulseTrainCounter);*/
}

// =========================================================
void ClassicRoutine() {
  for (int i = 0; i < PulseCounter; i++)
  {
    SetPotentiometerValue(Pulse[0]);
    Serial.print("Current");Serial.println(Pulse[0]);

    SetPolarity(Pulse[1]);
    Serial.print("PulsePolarities");Serial.println(Pulse[1]);

    Wait(Pulse[2],  Pulse[3], Pulse[4]);

    digitalWrite(CLOCK_1_PIN, LOW); digitalWrite(CLOCK_2_PIN, HIGH); // desliga a saida

    Wait(Pulse[5], Pulse[6], Pulse[7]);
  }
}
/*
void ClassicRoutine() {
  for (int i = 0; i < PulseCounter; i++)
  {
    SetPotentiometerValue(PulseCurrents[i]);
    Serial.print("Current");Serial.println(PulseCurrents[i]);

    SetPolarity(PulsePolarities[i]);
    Serial.print("PulsePolarities");Serial.println(PulsePolarities[i]);

    Wait(PulseLengthsIntegerPart[i],  PulseLengthsFractionalPart[i], PulseLengthsMeasureUnity[i]);

    digitalWrite(CLOCK_1_PIN, LOW); digitalWrite(CLOCK_2_PIN, HIGH); // desliga a saida

    Wait(InterpulseLengthsIntegerPart[i],  InterpulseLengthsFractionalPart[i], InterpulseLengthsMeasureUnity[i]);
  }
}
*/
// =========================================================
void SetPolarity(int polarity) {
  if (polarity == 1)
  {
    digitalWrite(CLOCK_1_PIN, LOW);
    digitalWrite(CLOCK_2_PIN, LOW);
  }
  else
  {
    digitalWrite(CLOCK_1_PIN, HIGH);
    digitalWrite(CLOCK_2_PIN, HIGH);
  }
}

// =========================================================
void Wait(int timer, int fracTimer, int timeUnity) // --- Delay control ---
{
  if (timeUnity == INSTRUCTION_UNITY_US)
  {
    delayMicroseconds(timer);
  }
  else if (timeUnity == INSTRUCTION_UNITY_MS)
  {
    delay(timer);
    if (fracTimer > 0) delayMicroseconds(fracTimer);
  }
  else if (timeUnity == INSTRUCTION_UNITY_S)
  {
    for (int i = 0; i < timer; i++) delay(1000);
    if (fracTimer > 0) delay(fracTimer);
  }
}
