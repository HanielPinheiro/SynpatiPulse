/*
* RoutinesDeclarations.h
*
* Created: 31/05/2024 12:17:07
*  Author: Hani
*/

#ifndef ROUTINESDECLARATIONS_H_
#define ROUTINESDECLARATIONS_H_

#include <avr/io.h>
#include <string.h>
#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

// Main File ============================================
void InitializePorts();
void SetTime();
void BlinkLed();
void StopPulses();

//=======================================================

void Serial_ResetBuffer();
void Serial_ParseCommands(uint8_t byte);

// Dac8bits.cpp ===========================================

void SetDigitalPotentiometerValue(uint8_t value);
void SetCurrent_0();
void SetCurrent_50();
void SetCurrent_100();
void SetCurrent_150();
void SetCurrent_200();
void SetCurrent_250();
void SetCurrent_300();
void SetCurrent_350();
void SetCurrent_400();
void SetCurrent_450();
void SetCurrent_500();
void SetCurrent_550();
void SetCurrent_600();
void SetCurrent_650();

//============================================

// UartHal.cpp ===========================================

void UartInit(uint32_t baud, uint8_t highSpeed);
void UartSendByte(uint8_t byte);
void UartSendArray(uint8_t *c);
void UartSendString(char *c);
void UartSendChar(char byte);
void UartSend16Bit(uint16_t c);

uint16_t UartReadCount(void);
uint8_t UartRead(void);

uint16_t convertFrom8ArrTo16(uint8_t* dataAll) ;
uint8_t arr_length(uint8_t* arr);
//=======================================================

// ParseInstructions.cpp ===========================================

void ParsePulse(uint8_t* data, uint8_t size);
void SetCurrentValueToArr(char* nomCurr);
void GetTimeFromInstruction(uint8_t *data, uint8_t size, uint16_t* lengths, uint16_t* fracs, uint8_t* measures);
void ParsePulseTrain(uint8_t* data[]);
//=======================================================

// RunRoutine.cpp ===========================================

void RunRoutine();
void ClassicRoutine();
void PulseTrainRoutine();
void SetPolarity(uint8_t polarity);
void Wait(uint16_t timer, uint16_t fracTimer, uint8_t timeUnity);

//=======================================================

#endif