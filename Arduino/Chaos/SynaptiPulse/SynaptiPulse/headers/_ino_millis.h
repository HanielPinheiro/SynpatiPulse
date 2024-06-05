/*
  wiring_private.h - Internal header file.
  Part of Arduino - http://www.arduino.cc/
*/

#ifndef _ino_millis_h
#define _ino_millis_h

#include "config.h"

#include <avr/io.h>
#include <avr/interrupt.h>
#include <stdio.h>
#include <stdarg.h>

#define clockCyclesPerMicrosecond() ( F_CPU / 1000000L )
#define clockCyclesToMicroseconds(a) ( (a) / clockCyclesPerMicrosecond() )
#define microsecondsToClockCycles(a) ( (a) * clockCyclesPerMicrosecond() )


#ifdef __cplusplus
extern "C"{
#endif

#ifndef cbi
#define cbi(sfr, bit) (_SFR_BYTE(sfr) &= ~_BV(bit))
#endif

#ifndef sbi
#define sbi(sfr, bit) (_SFR_BYTE(sfr) |= _BV(bit))
#endif

#define EXTERNAL_INT_0 0
#define EXTERNAL_INT_1 1
#define EXTERNAL_INT_2 2
#define EXTERNAL_INT_3 3
#define EXTERNAL_INT_4 4
#define EXTERNAL_INT_5 5
#define EXTERNAL_INT_6 6
#define EXTERNAL_INT_7 7
#define EXTERNAL_NUM_INTERRUPTS 2

uint32_t countPulseASM(volatile uint8_t *port, uint8_t bit, uint8_t stateMask, unsigned long maxloops);
typedef void (*voidFuncPtr)(void);
void initMillis();
unsigned long millis();

#ifdef __cplusplus
} // extern "C"
#endif

#endif