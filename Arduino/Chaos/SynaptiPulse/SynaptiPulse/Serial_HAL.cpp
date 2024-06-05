/*
* UART_HAL.cpp
*
* Created: 31/05/2024 16:37:59
*  Author: Hani
*/

#include "headers/config.h"
#include "headers/RoutinesDeclarations.h"
#include <avr/interrupt.h>

uint8_t UartTxBusy = 0;
uint8_t UartRxArray[UartRxBuffer] = {0};
uint16_t UartRxCount = 0;
extern uint8_t DebugMode;

ISR(USART_RX_vect){
	volatile static uint16_t RxPosition = 0;
	UartRxArray[RxPosition] = UDR0;
	UartRxCount++;
	RxPosition++;
	if(RxPosition >= UartRxBuffer) RxPosition = 0;
}

ISR(USART_TX_vect){	UartTxBusy = 0; }

void UartInit(uint32_t baud, uint8_t highSpeed)
{
	uint8_t speed = 16;
	
	if(highSpeed != 0)
	{
		speed = 8;
		UCSR0A |= (1 << U2X0);
	}
	baud = (F_CPU / (speed*baud)) - 1;

	// Set baud rate
	UBRR0L = (uint8_t)(baud & 0xFF);
	UBRR0H = (uint8_t)(baud >> 8);
	
	// Set frame format to 8 data bits, no parity, 1 stop bit
	UCSR0C |= (1<<UCSZ01)|(1<<UCSZ00);
	
	//Enable Rx and Tx
	UCSR0B |= (1 << TXEN0) | (1 << RXEN0);
	UCSR0B |= (1 << RXCIE0) | (1 << TXCIE0);
}

void UartSendByte(uint8_t byte){
	while(UartTxBusy == 1);
	UartTxBusy = 1;
	UDR0 = byte;
}

void UartSendChar(char byte){
	while(UartTxBusy == 1);
	UartTxBusy = 1;
	UDR0 = byte;
}

void UartSendArray(uint8_t *c)
{
	uint16_t counter = 0;
	
	do{
		UartSendByte(c[counter]);
		counter++;
	}while(c[counter] != '\0');
	
	UartSendByte(c[counter]);
}

void UartSendString(char *c)
{
	uint16_t counter = 0;
	
	do{
		UartSendChar(c[counter]);
		counter++;
	}while(c[counter] != '\0');
	
	UartSendChar(c[counter]);
}

void UartSend16Bit(uint16_t value)
{
	uint8_t i = 0;
	char temp[6] = {0}; // Maximum length for 5 digits + null terminator (uint16_t max value is 65535)
	char str[6] = {0};
	
	// Convert number to string (reverse order)
	do {
		temp[i++] = (value % 10) + '0';
		value /= 10;
	} while (value > 0);
	
	// Reverse the string
	uint8_t j;
	for (j = 0; j < i; j++) {
		str[j] = temp[i - j - 1];
	}
	str[j] = '\0'; // Null-terminate the string
	
	UartSendString(str);
}


uint16_t UartReadCount(void){
	return UartRxCount;
}

uint8_t UartRead(void){
	static uint16_t rx_read_pos = 0;
	uint8_t data = 0;
	
	data = UartRxArray[rx_read_pos];
	rx_read_pos++;
	UartRxCount--;
	if(rx_read_pos >= UartRxBuffer)		rx_read_pos = 0;
	
	return data;
}

uint16_t convertFrom8ArrTo16(uint8_t* dataAll) {
	uint8_t s = arr_length(dataAll);
	uint8_t s2 = s-1;
	uint16_t m = 0;
	
	uint8_t zeroChar = 48;
	uint8_t nineChar = 57;
	
	for(uint8_t i = 0; i< s; i++){
		//if(WantToPrint) UartSendChar((char)dataAll[i]);
		
		uint16_t weig = 1;
		for(uint8_t j = 0; j< (s2 - i); j++) weig *= 10;
		
		if(dataAll[i] >= zeroChar && dataAll[i] <= nineChar) m += (dataAll[i] - zeroChar)*weig;
		else		m += dataAll[i] * (weig);
	}
	
	return m;
}

uint8_t arr_length(uint8_t* arr)
{
	uint8_t i;
	uint8_t count = 0;
	
	for(i=0; arr[i]!='\0'; i++)
	count++;
	
	return count;
}