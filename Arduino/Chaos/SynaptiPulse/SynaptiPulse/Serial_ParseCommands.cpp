/*
* Serialnterface.cpp
*
* Created: 01/06/2024 14:08:02
*  Author: Hani
*/

#include "headers/config.h"
#include "headers/RoutinesDeclarations.h"
#include <avr/wdt.h>

extern uint8_t SerialRx[UartRxBuffer];
extern uint8_t SerialRxCounter;

extern uint8_t PulseCounter;
extern uint8_t HasInstruction;
extern uint8_t IsReading;
extern uint8_t IsRunning;

extern uint8_t PulsePolarities[numOfPulses];
extern uint8_t PulseLengthsMeasureUnity[numOfPulses];
extern uint8_t InterpulseLengthsMeasureUnity[numOfPulses];
extern uint8_t PulseCurrents[numOfPulses];

extern uint16_t PulseLengthsIntegerPart[numOfPulses];
extern uint16_t PulseLengthsFractionalPart[numOfPulses];
extern uint16_t InterpulseLengthsIntegerPart[numOfPulses];
extern uint16_t InterpulseLengthsFractionalPart[numOfPulses];
extern char jumpline[];
extern uint8_t PulseMode;
extern uint8_t PulseTrainMode;

char mustReset[] = "Must Reset\n\r";

void Serial_ResetBuffer() {
	memset(SerialRx, 0, UartRxBuffer);
	SerialRxCounter = 0;
}

void Serial_ParseCommands(uint8_t byte) {
	if (byte == CONTROL_RESET_BOARD){  //A>
		wdt_disable();
		wdt_enable(WDTO_15MS);
		while (1) {}
	}
	
	if (byte == CONTROL_RESET_INSTRUCTION){  //B>
		StopPulses();
		
		memset(InterpulseLengthsIntegerPart, 0, numOfPulses);
		memset(PulseCurrents, 0, numOfPulses);
		memset(PulsePolarities, 0, numOfPulses);
		memset(PulseLengthsIntegerPart, 0, numOfPulses);

		PulseCounter = 0;
		HasInstruction = 0;
		IsReading = 0;
		IsRunning = 0;
		PulseTrainMode = 0;
		PulseMode = 0;
		
		Serial_ResetBuffer();
		
		char a[] = "Reseted\n\r";
		UartSendString(a);
	}

	if (byte == CONTROL_ROUTINE_START)  //C>
	{
		char a[] = "Start Routine\n\r";
		UartSendString(a);
		
		if (!IsReading && HasInstruction)
		{
			//SetDigitalPotentiometerValue(PulseCurrents[0]);
			IsRunning = 1;
			char b[] = "Routine Enabled\n\r";
			UartSendString(b);
		}
	}

	if (byte == CONTROL_ROUTINE_STOP)  //D>
	{
		char a[] = "Stop Routine\n\r";
		UartSendString(a);
		
		if (IsRunning && !IsReading && HasInstruction)
		{
			StopPulses();
			IsRunning = 0;
			char b[] = "Routine Disabled\n\r";
			UartSendString(b);
		}
	}

	if (byte == CONTROL_READ_START)  //E>
	{
		char a[] = "Start Read Instructions\n\r";
		UartSendString(a);
		
		if(HasInstruction){			
			UartSendString(mustReset);
		}		
		else if (!IsRunning) {
			IsReading = 1;
			char b[] = "Read Routine Enabled\n\r";
			UartSendString(b);
		}
	}

	if (byte == CONTROL_READ_STOP)  //F>
	{
		char a[] = "Stop Read Instructions\n\r";
		char b[] = "Read Routine Disabled\n\r";
		
		UartSendString(a);
		if (!IsRunning && IsReading && !HasInstruction) {
			IsReading = 0;
			HasInstruction = 1;
			UartSendString(b);
		}
	}
	
	
	if (byte == CONTROL_MODE_PERIODIC)  //G>
	{
		if (!IsRunning && IsReading) {
			
			if(HasInstruction && PulseTrainMode)
				UartSendString(mustReset);
			else{
			char a[] = "Set mode to Periodic\n\r";		
			UartSendString(a);
			PulseTrainMode = 0;
			PulseMode = 1;
			}
		}
	}
	
	
		if (byte == CONTROL_MODE_PULSETRAINS) //H>
		{
			if (!IsRunning && IsReading) {
				
				if(HasInstruction && PulseMode)
				UartSendString(mustReset);
				else{
					char a[] = "Set mode to PulseTrain\n\r";
					UartSendString(a);
					PulseTrainMode = 1;
					PulseMode = 0;
				}
			}
		}
}
