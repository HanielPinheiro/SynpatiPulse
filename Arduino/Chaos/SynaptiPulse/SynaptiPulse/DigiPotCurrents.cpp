#include "headers/RoutinesDeclarations.h"

/*
Para consulta:
#define PIN_LADDER_BIT0 9
#define PIN_LADDER_BIT1 8
#define PIN_LADDER_BIT2 7
#define PIN_LADDER_BIT3 6
#define PIN_LADDER_BIT4 5
#define PIN_LADDER_BIT5 4
#define PIN_LADDER_BIT6 3
#define PIN_LADDER_BIT7 2

#define PIN_CLOCK1 12
#define PIN_CLOCK2 11
*/

void SetDigitalPotentiometerValue(uint8_t value) {
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
	else SetCurrent_650();
}

void SetCurrent_0() {	
	PORTB |= (0 << PORTB1);//D9 - Bit 0
	PORTB |= (0 << PORTB0);//D8 - Bit 1
	PORTD |= (0 << PORTD7);//D7 - Bit 2
	PORTD |= (0 << PORTD6);//D6 - Bit 3
	PORTD |= (0 << PORTD5);//D5 - Bit 4
	PORTD |= (0 << PORTD4);//D4 - Bit 5
	PORTD |= (0 << PORTD3);//D3 - Bit 6
	PORTD |= (0 << PORTD2);//D2 - Bit 7
}

void SetCurrent_50() {
	PORTB |= (0 << PORTB1);//D9 - Bit 0
	PORTB |= (0 << PORTB0);//D8 - Bit 1
	PORTD |= (0 << PORTD7);//D7 - Bit 2
	PORTD |= (0 << PORTD6);//D6 - Bit 3
	PORTD |= (0 << PORTD5);//D5 - Bit 4
	PORTD |= (1 << PORTD4);//D4 - Bit 5
	PORTD |= (0 << PORTD3);//D3 - Bit 6
	PORTD |= (0 << PORTD2);//D2 - Bit 7
}

void SetCurrent_100() {
	PORTB |= (1 << PORTB1);//D9 - Bit 0
	PORTB |= (0 << PORTB0);//D8 - Bit 1
	PORTD |= (0 << PORTD7);//D7 - Bit 2
	PORTD |= (1 << PORTD6);//D6 - Bit 3
	PORTD |= (0 << PORTD5);//D5 - Bit 4
	PORTD |= (1 << PORTD4);//D4 - Bit 5
	PORTD |= (0 << PORTD3);//D3 - Bit 6
	PORTD |= (0 << PORTD2);//D2 - Bit 7
}

void SetCurrent_150() {
	PORTB |= (0 << PORTB1);//D9 - Bit 0
	PORTB |= (1 << PORTB0);//D8 - Bit 1
	PORTD |= (1 << PORTD7);//D7 - Bit 2
	PORTD |= (1 << PORTD6);//D6 - Bit 3
	PORTD |= (0 << PORTD5);//D5 - Bit 4
	PORTD |= (1 << PORTD4);//D4 - Bit 5
	PORTD |= (0 << PORTD3);//D3 - Bit 6
	PORTD |= (0 << PORTD2);//D2 - Bit 7
}

void SetCurrent_200() {
	PORTB |= (0 << PORTB1);//D9 - Bit 0
	PORTB |= (0 << PORTB0);//D8 - Bit 1
	PORTD |= (0 << PORTD7);//D7 - Bit 2
	PORTD |= (1 << PORTD6);//D6 - Bit 3
	PORTD |= (1 << PORTD5);//D5 - Bit 4
	PORTD |= (1 << PORTD4);//D4 - Bit 5
	PORTD |= (0 << PORTD3);//D3 - Bit 6
	PORTD |= (0 << PORTD2);//D2 - Bit 7
}

void SetCurrent_250() {
	PORTB |= (0 << PORTB1);//D9 - Bit 0
	PORTB |= (1 << PORTB0);//D8 - Bit 1
	PORTD |= (1 << PORTD7);//D7 - Bit 2
	PORTD |= (1 << PORTD6);//D6 - Bit 3
	PORTD |= (1 << PORTD5);//D5 - Bit 4
	PORTD |= (0 << PORTD4);//D4 - Bit 5
	PORTD |= (1 << PORTD3);//D3 - Bit 6
	PORTD |= (0 << PORTD2);//D2 - Bit 7
}

void SetCurrent_300() {
	PORTB |= (0 << PORTB1);//D9 - Bit 0
	PORTB |= (0 << PORTB0);//D8 - Bit 1
	PORTD |= (0 << PORTD7);//D7 - Bit 2
	PORTD |= (1 << PORTD6);//D6 - Bit 3
	PORTD |= (0 << PORTD5);//D5 - Bit 4
	PORTD |= (1 << PORTD4);//D4 - Bit 5
	PORTD |= (1 << PORTD3);//D3 - Bit 6
	PORTD |= (0 << PORTD2);//D2 - Bit 7
}

void SetCurrent_350() {
	PORTB |= (1 << PORTB1);//D9 - Bit 0
	PORTB |= (1 << PORTB0);//D8 - Bit 1
	PORTD |= (0 << PORTD7);//D7 - Bit 2
	PORTD |= (0 << PORTD6);//D6 - Bit 3
	PORTD |= (0 << PORTD5);//D5 - Bit 4
	PORTD |= (0 << PORTD4);//D4 - Bit 5
	PORTD |= (0 << PORTD3);//D3 - Bit 6
	PORTD |= (1 << PORTD2);//D2 - Bit 7
}

void SetCurrent_400() {
	PORTB |= (0 << PORTB1);//D9 - Bit 0
	PORTB |= (1 << PORTB0);//D8 - Bit 1
	PORTD |= (0 << PORTD7);//D7 - Bit 2
	PORTD |= (1 << PORTD6);//D6 - Bit 3
	PORTD |= (0 << PORTD5);//D5 - Bit 4
	PORTD |= (0 << PORTD4);//D4 - Bit 5
	PORTD |= (0 << PORTD3);//D3 - Bit 6
	PORTD |= (1 << PORTD2);//D2 - Bit 7
}

void SetCurrent_450() {
	PORTB |= (1 << PORTB1);//D9 - Bit 0
	PORTB |= (1 << PORTB0);//D8 - Bit 1
	PORTD |= (0 << PORTD7);//D7 - Bit 2
	PORTD |= (0 << PORTD6);//D6 - Bit 3
	PORTD |= (1 << PORTD5);//D5 - Bit 4
	PORTD |= (0 << PORTD4);//D4 - Bit 5
	PORTD |= (0 << PORTD3);//D3 - Bit 6
	PORTD |= (1 << PORTD2);//D2 - Bit 7
}

void SetCurrent_500() {	
	PORTB |= (1 << PORTB1);//D9 - Bit 0
	PORTB |= (1 << PORTB0);//D8 - Bit 1
	PORTD |= (0 << PORTD7);//D7 - Bit 2
	PORTD |= (1 << PORTD6);//D6 - Bit 3
	PORTD |= (1 << PORTD5);//D5 - Bit 4
	PORTD |= (0 << PORTD4);//D4 - Bit 5
	PORTD |= (0 << PORTD3);//D3 - Bit 6
	PORTD |= (1 << PORTD2);//D2 - Bit 7
}

void SetCurrent_550() {
	PORTB |= (0 << PORTB1);//D9 - Bit 0
	PORTB |= (0 << PORTB0);//D8 - Bit 1
	PORTD |= (0 << PORTD7);//D7 - Bit 2
	PORTD |= (0 << PORTD6);//D6 - Bit 3
	PORTD |= (0 << PORTD5);//D5 - Bit 4
	PORTD |= (1 << PORTD4);//D4 - Bit 5
	PORTD |= (0 << PORTD3);//D3 - Bit 6
	PORTD |= (1 << PORTD2);//D2 - Bit 7
}

void SetCurrent_600() {
	PORTB |= (0 << PORTB1);//D9 - Bit 0
	PORTB |= (0 << PORTB0);//D8 - Bit 1
	PORTD |= (0 << PORTD7);//D7 - Bit 2
	PORTD |= (1 << PORTD6);//D6 - Bit 3
	PORTD |= (0 << PORTD5);//D5 - Bit 4
	PORTD |= (1 << PORTD4);//D4 - Bit 5
	PORTD |= (0 << PORTD3);//D3 - Bit 6
	PORTD |= (1 << PORTD2);//D2 - Bit 7
}

void SetCurrent_650() {
	PORTB |= (0 << PORTB1);//D9 - Bit 0
	PORTB |= (0 << PORTB0);//D8 - Bit 1
	PORTD |= (0 << PORTD7);//D7 - Bit 2
	PORTD |= (0 << PORTD6);//D6 - Bit 3
	PORTD |= (1 << PORTD5);//D5 - Bit 4
	PORTD |= (1 << PORTD4);//D4 - Bit 5
	PORTD |= (0 << PORTD3);//D3 - Bit 6
	PORTD |= (1 << PORTD2);//D2 - Bit 7
}
