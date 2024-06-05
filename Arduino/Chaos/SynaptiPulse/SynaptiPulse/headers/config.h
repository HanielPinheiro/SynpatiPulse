/*
* RoutinesDeclarations.h
*
* Created: 31/05/2024 12:17:07
*  Author: Hani
*/

#ifndef CONFIG
#define CONFIG
#include <stdint.h>

#define F_CPU 16000000UL
#define __DELAY_BACKWARD_COMPATIBLE__
#include <util/delay.h>
#define UartRxBuffer 128
#define PreScale 64

#define numOfPulses 50
#define numPulseTrains 4
#define totalPulseTrain (numOfPulses * numPulseTrains)

#define CONTROL_RESET_BOARD 'A'
#define CONTROL_RESET_INSTRUCTION 'B'
#define CONTROL_ROUTINE_START 'C'
#define CONTROL_ROUTINE_STOP 'D'
#define CONTROL_READ_START 'E'
#define CONTROL_READ_STOP 'F'
#define CONTROL_MODE_PERIODIC 'G'
#define CONTROL_MODE_PULSETRAINS 'H'

/*
* Instructions examples:
* SET$150$1$200U$999.8M>
* SET$450$0$200.8M$1.2S>
* SET$50$1$100U$100M>
* SET$100$0$100U$100M>
*/

#define INSTRUCTION_SET "SET"
#define INSTRUCTION_UNITY_MS 77
#define INSTRUCTION_UNITY_US 85
#define INSTRUCTION_UNITY_S 83
#define INSTRUCTION_DECIMAL '.'
#define INSTRUCTION_SEPARATOR '$'
#define INSTRUCTION_END '>'

#endif
