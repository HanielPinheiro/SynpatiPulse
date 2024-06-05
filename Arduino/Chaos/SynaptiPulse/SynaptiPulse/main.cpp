/*
* SynaptiPulse.cpp
*
* Created: 25/05/2024 14:18:02
* Author : Hani
*/

#include "headers/globalVariables.h"
#include "headers/RoutinesDeclarations.h"
#include <avr/interrupt.h>
#include "headers/_ino_millis.h"


void Setup()
{
	SetTime();
	
	InitializePorts();
	SetCurrent_0();
	
	uint8_t start[] = "Stimulator is ready\n\r";
	UartInit(38400,0);
	UartSendArray(start);
}

int main(void)
{
	Setup();
	unsigned long timeMilis = 0;
	
	while (1)
	{
		if (DebugMode) ParsePulse(SerialRx, SerialRxCounter);
		else {
			if (IsRunning) RunRoutine();
			
			if (millis() - timeMilis >= 100)
			{
				timeMilis = millis();
				
				while(UartReadCount() > 0){
					uint8_t data = UartRead();
					if(data != INSTRUCTION_END){
						SerialRx[SerialRxCounter] = data;
						SerialRxCounter++;
						if(DebugMode) UartSendByte(data);
					}
					else
					{
						if(SerialRxCounter == 1) Serial_ParseCommands(SerialRx[0]);
						else if (IsReading){
							if(PulseTrainMode)
							{
								if((PulseTrainCounter * PulseCounter) < totalPulseTrain) 
								{
									PulseTrains[PulseTrainCounter][PulseTrainCounter] = SerialRx;
									PulseCounter++;
									if(PulseCounter == numOfPulses) 
									{ 
										PulseTrainCounter++;
										PulseCounter=0;
									}
								}
								else UartSendArray(cantReceiveMorePulses);
							}
							else if(PulseMode){
								if(PulseCounter < numOfPulses) ParsePulse(SerialRx, SerialRxCounter);
								else UartSendArray(cantReceiveMorePulses);
							}
							else UartSendArray(mustSetPulseMode);
						}
					}
				}
				Serial_ResetBuffer();
			}
		}
	}
}

void InitializePorts(){
	// Pinos digitais 2 - 9 Ladder(PD2 - PD7) e (PB0 e PB1)
	// Pinos digitais 11 e 12 - Clock(PB3 e PB4)
	// Pino digital 13 - LED (PB5)
	
	//D13 = Led D12=Clk1 D11=Clk2,D9=Bit7, D8=Bit6
	//PORTB7, PORTB6, PORTB2 Ignorados
	DDRB = 0b00111011; // 0 = INPUT e 1 = OUTPUT
	PORTB = 0; //0 = LOW e 1 = HIGH,
	StopPulses();
	
	//D7 ate D2 = Bit 5 ao Bit0 do DigiPot, D1 = Tx e D0 = Rx
	DDRD = 0b11111100; // 0 = INPUT e 1 = OUTPUT
	PORTD = 0; //0 = LOW e 1 = HIGH ? Todas as portas em estado LOW*/
}
	
void StopPulses() {
	//PORTB4 = clk1, PORTB3 = clk2
	//Ck1 = 0 e ck2 = 1 fazem o estimulador não gerar pulsos
	PORTB &= ~(1 << PORTB4);
	PORTB |=  (1 << PORTB3);
	SetCurrent_0();
}
	
void SetTime(){
	//The main objective is toogle Timer0 Overflow Interruption always that a overflow count in clock occurs
	TCCR0B = (1 << CS01) | (1 << CS00); // Set timer prescaler to 64 to correctly start millis()
	TCCR0A = (1 << WGM01) | (1 << WGM00); // Enable Fast Pwm - Look pag 86 datasheet
	TIMSK0 = (1 << TOIE0);  //Enable timer0 interrupt by overflow
	initMillis();
}

void BlinkLed(){
	/*
	Lembrete:
	PORTB |= (1 << PORTB5);  //1 no pino Portb5
	PORTB &= ~(1 << PORTB5); //0 no pino Portb5
	*/
	
	PORTB |= (1 << PORTB5);
	_delay_ms(500);
	PORTB &= ~(1 << PORTB5);
	_delay_ms(500);
	PORTB |= (1 << PORTB5);
	_delay_ms(500);
	PORTB &= ~(1 << PORTB5);
	_delay_ms(500);
	PORTB |= (1 << PORTB5);
	_delay_ms(500);
	PORTB &= ~(1 << PORTB5);
	_delay_ms(500);
}
