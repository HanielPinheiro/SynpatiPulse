#include "Variables.h"


//Beginning of Auto generated function prototypes by Atmel Studio
void ParseCommands(char target);
//End of Auto generated function prototypes by Atmel Studio

void ParseCommands(char target) {
  
  if (target == CONTROL_RESET_BOARD)  //D>
  {    
    Serial.end();
    asm ("jmp (0x0000)");
  }

  if (target == CONTROL_RESET_INSTRUCTION)  //R>
  {
    Serial_ResetBuffer();
  
    pulseCounter = 0;

    InterpulseLengthsIntegerPart[numOfPulses] = { NULL };
    PulseCurrents[numOfPulses] = { NULL };
    PulsePolarities[numOfPulses] = { NULL };
    PulseLengthsIntegerPart[numOfPulses] = { NULL };

    HasInstruction = false;
    IsReading = false;
    IsRunning = false;
    StopPulses();
    
    Serial.println("Reseted");
  }

  if (target == CONTROL_START_ROUTINE)  //J>
  {
    Serial.println("Start Routine");
    if (!IsReading && HasInstruction)
    {
      SetPotentiometerValue(PulseCurrents[0]);
      IsRunning = true;
      Serial.println("Routine Enabled");
    }
  }

  if (target == CONTROL_STOP_ROUTINE)  //K>
  {
    Serial.println("Stop Routine");
    if (IsRunning && !IsReading && HasInstruction)
    {
      IsRunning = false;
      Serial.println("Routine Disabled");
    }
  }

  if (target == CONTROL_READ_INSTRUCTIONS)  //L>
  { Serial.println("Start Read Instructions");
    if (!IsRunning && !HasInstruction) {
      IsReading = true;
      Serial.println("Read Routine Enabled");
    }
  }

  if (target == CONTROL_STOP_READ_INSTRUCTIONS)  //M>
  {
    Serial.println("Stop Read Instructions");
    if (!IsRunning && IsReading && !HasInstruction) {
      IsReading = false;
      HasInstruction = true;
      Serial.println("Read Routine Disabled");
      Serial.print("Saved data: "); Serial.println(pulseCounter);
    }
  }
}
