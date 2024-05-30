#include "Variables.h"

//Beginning of Auto generated function prototypes by Atmel Studio
void RunRoutine();
void ClassicRoutine();
void ChaoticRoutine();
void SetPolarity(int polarity);
void Wait(int timer, int fracTimer, int timeUnity);
//End of Auto generated function prototypes by Atmel Studio

void RunRoutine() {
  if (LorenzBatteryInterval == 0) ClassicRoutine();
  else ChaoticRoutine();
}

// =========================================================
void ClassicRoutine() {

  for (int i = 0; i < pulseCounter; i++)
  {
    SetPotentiometerValue(PulseCurrents[i]);
    //Serial.print("Current");Serial.println(PulseCurrents[i]);

    SetPolarity(PulsePolarities[i]);
    //Serial.print("PulsePolarities");Serial.println(PulsePolarities[i]);


    /*Serial.print("Wait int: ");Serial.println(PulseLengthsIntegerPart[i]);
      Serial.print("Wait frac: ");Serial.println(PulseLengthsFractionalPart[i]);
      Serial.print("Wait meas: ");Serial.println(PulseLengthsMeasureUnity[i]);    //*/
    Wait(PulseLengthsIntegerPart[i],  PulseLengthsFractionalPart[i], PulseLengthsMeasureUnity[i]);

    /*Serial.print("Wait int: ");Serial.println(InterpulseLengthsIntegerPart[i]);
      Serial.print("Wait frac: ");Serial.println(InterpulseLengthsFractionalPart[i]);
      Serial.print("Wait meas: ");Serial.println(InterpulseLengthsMeasureUnity[i]);    //*/
    digitalWrite(CLOCK_1_PIN, LOW); digitalWrite(CLOCK_2_PIN, HIGH);
    Wait(InterpulseLengthsIntegerPart[i],  InterpulseLengthsFractionalPart[i], InterpulseLengthsMeasureUnity[i]);
  }

}

// =========================================================
void ChaoticRoutine() {
  SetPotentiometerValue(PulseCurrents[0]);

  for (int i = 0; i < numPulseTrains; i++) {
    SetPolarity(LorenzPreviousPolarity);
    if (LorenzMode == 1) LorenzPreviousPolarity = 1 - LorenzPreviousPolarity;

    Wait(50,  0, INSTRUCTION_UNITY_MS);

    if (LorenzBatteryCounter == 0) Wait(LorenzPulseTrainValues[i],  0, INSTRUCTION_UNITY_MS);

    if (i % 199 == 0)
    {
      LorenzBatteryCounter++;
      if (LorenzBatteryCounter == 4) LorenzBatteryCounter = 0;
      
      Serial.println("LorenzWaiting");      
      
      Wait(LorenzBatteryInterval, 0, INSTRUCTION_UNITY_MS);
    }
  }
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
