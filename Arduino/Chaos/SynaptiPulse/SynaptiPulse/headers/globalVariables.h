/*
* GlobalVariables.cpp
*
* Created: 01/06/2024 14:39:07
*  Author: Hani
*/

#ifndef Variables
#define Variables

#include "config.h"

char jumpline[] = "\n\r";
uint8_t cantReceiveMorePulses[] = "Can't receive more pulses!\n\r";
uint8_t mustSetPulseMode[] = "Must Set if is PulseMode or PulseTrainMode!\n\r";

//uint8 é o somatorio de 2^0 até 2^7 = 255 bits se for unsigned. Se for normal vai +127 até -127 incluindo 0
//uint16 é o somatorio de 2^0 até 2^15 = 65535 bits se for unsigned. Se for normal vai +32767 até -32767 incluindo 0
//uint32 é o somatorio de 2^0 até 2^32 = 4.294.967.295 bits se for unsigned. Se for normal vai +2.147.483.647 até -2.147.483.647 incluindo 0

uint8_t HasInstruction = 0;
uint8_t IsReading = 0;
uint8_t IsRunning = 0;

// =========================================================

uint8_t PulseMode = 0;
uint8_t PulseCounter = 0;

uint8_t PulsePolarities[numOfPulses] = {0};
uint8_t PulseCurrents[numOfPulses] = {0};
uint8_t PulseLengthsMeasureUnity[numOfPulses] = {0};
uint8_t InterpulseLengthsMeasureUnity[numOfPulses] = {0};

uint16_t PulseLengthsIntegerPart[numOfPulses] = {0};
uint16_t InterpulseLengthsIntegerPart[numOfPulses] = {0};
uint16_t PulseLengthsFractionalPart[numOfPulses] = {0};
uint16_t InterpulseLengthsFractionalPart[numOfPulses] = {0};


// =========================================================

uint8_t PulseTrainMode = 0;
uint8_t PulseTrainCounter = 0;
uint8_t PulseTrainInterval = 0;
uint8_t* PulseTrains[numPulseTrains][numOfPulses] = {0};

// =========================================================
uint8_t SerialRx[UartRxBuffer] = {0};
uint8_t SerialRxCounter = 0;
uint8_t DebugMode = 0;

#endif