void RunPulse() {
  SetCurrent(Pulse[0]);

  SetPolarity(Pulse[1]);
  
  Wait(Pulse[2],  Pulse[3], Pulse[4]); // Largura do Pulso
  
  digitalWrite(CLOCK_1_PIN, LOW); digitalWrite(CLOCK_2_PIN, HIGH); // desliga a saída (0V)
  
  Wait(Pulse[5], Pulse[6], Pulse[7]);// Intervalo entre pulso
}

// =========================================================
void SetCurrent(int value) {
  if (value == 30) SetCurrent_30();
  else if (value == 50) SetCurrent_50();
  else if (value == 75) SetCurrent_75();
  else if (value == 100) SetCurrent_100();
  else if (value == 150) SetCurrent_150();
  else if (value == 200) SetCurrent_200();
  else if (value == 250) SetCurrent_250();
  else if (value == 300) SetCurrent_300();
  else if (value == 350) SetCurrent_350();
  else if (value == 400) SetCurrent_400();
  else if (value == 450) SetCurrent_450();
  else if (value == 500) SetCurrent_500();
  else if (value == 550) SetCurrent_550();
  else if (value == 600) SetCurrent_600();
  else if (value == 650) SetCurrent_650();
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
