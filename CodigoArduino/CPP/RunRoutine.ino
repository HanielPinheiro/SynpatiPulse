void RunRoutine() {
  SetCurrent(Pulse[0]);

  SetPolarity(Pulse[1]);

  // Largura do Pulso
  Wait(Pulse[2],  Pulse[3], Pulse[4]);

  // Intervalo entre pulso
  digitalWrite(CLOCK_1_PIN, LOW); digitalWrite(CLOCK_2_PIN, HIGH);
  IsWaiting = true;
  Wait(Pulse[5], Pulse[6], Pulse[7]);

  if (!PeriodicMode && PulseCounter == ArrayCounter) {
    IsRunning = false;
    IsWaiting = false;
  }
  
  if(PeriodicMode && ArrayCounter == 1) IsWaiting = false;
}

// =========================================================
void SetCurrent(int value) {
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
  else if (value == 12)SetCurrent_650();
  else SetCurrent_0();
}

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
  //Serial.println("Esperando");

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
  
  //Serial.println("Parou");
}
