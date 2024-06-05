#include "headers/config.h"
#include "headers/RoutinesDeclarations.h"

extern uint8_t PulseMode;
extern uint8_t PulseTrainMode;
extern uint8_t IsRunning;
extern uint8_t PulseCounter;

extern uint8_t PulsePolarities[numOfPulses];
extern uint8_t PulseCurrents[numOfPulses];
extern uint8_t PulseLengthsMeasureUnity[numOfPulses];
extern uint8_t InterpulseLengthsMeasureUnity[numOfPulses];

extern uint16_t PulseLengthsIntegerPart[numOfPulses];
extern uint16_t InterpulseLengthsIntegerPart[numOfPulses];
extern uint16_t PulseLengthsFractionalPart[numOfPulses];
extern uint16_t InterpulseLengthsFractionalPart[numOfPulses];

extern uint8_t* mustSetPulseMode;
extern uint8_t* PulseTrains[numPulseTrains][numOfPulses];

void RunRoutine() {
	if (PulseTrainMode) PulseTrainRoutine();
	else if(PulseMode) ClassicRoutine();
	else{
		IsRunning = 0;
		UartSendArray(mustSetPulseMode);
	}
}

// =========================================================
void ClassicRoutine() {
	for (uint8_t i = 0; i < PulseCounter; i++)
	{
		//Define a intensidade da corrente
		SetDigitalPotentiometerValue(PulseCurrents[i]);

		//Define o estado do pulso (+1 ou -1)
		SetPolarity(PulsePolarities[i]);
		
		//Espera a largura do pulso
		Wait(PulseLengthsIntegerPart[i],  PulseLengthsFractionalPart[i], PulseLengthsMeasureUnity[i]);
		
		PORTB &= ~(1 << PORTB4); // clk1 = 0
		PORTB |=  (1 << PORTB3); // clk2 = 1 Isso faz nenhuma corrente cair na carga (intervalo entre pulsos)
		
		//Espera o intervalo
		Wait(InterpulseLengthsIntegerPart[i],  InterpulseLengthsFractionalPart[i], InterpulseLengthsMeasureUnity[i]);
	}
}

// =========================================================
void PulseTrainRoutine() {
	for (uint8_t i = 0; i < numPulseTrains; i++)
	{
		ParsePulseTrain(PulseTrains[i]);
		PulseCounter = numOfPulses;		
		ClassicRoutine();	
	}
}

// =========================================================
void SetPolarity(uint8_t polarity) {
	if (polarity)	{//PORTB4 = clk1, PORTB3 = clk2
		PORTB &= ~(1 << PORTB4); // Lo
		PORTB &= ~(1 << PORTB3); // Lo
		}	else	{
		PORTB |= (1 << PORTB4); // Hi
		PORTB |= (1 << PORTB3); // Hi
	}
}

// =========================================================
void Wait(uint16_t timer, uint16_t fracTimer, uint8_t timeUnity) // --- Delay control ---
{
	if (timeUnity == INSTRUCTION_UNITY_US)
	{
		_delay_us(timer);
	}
	else if (timeUnity == INSTRUCTION_UNITY_MS)
	{
		_delay_ms(timer);
		if (fracTimer > 0) _delay_us(fracTimer);
	}
	else if (timeUnity == INSTRUCTION_UNITY_S)
	{
		for (uint16_t i = 0; i < timer; i++) _delay_ms(1000);
		if (fracTimer > 0) _delay_ms(fracTimer);
	}
}
