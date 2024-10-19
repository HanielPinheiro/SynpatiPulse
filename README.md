SynaptiPulse

This is a software to control a board that was developed to stimulate rats brain with pre chosed constant current and variable frequencie.

This is composed by:
	A service that stablish the communication with the board an transmit via Messagerie Service (RabbitMQ) the data.
	A User Interface that is responsible to control the operation models of stimulation (chaotic, stochastic and constant)
	The chaotic model can variate the pulse parameters in intensity, pulse length and interpulse intervals
	The stochastic maybe?
	The constant has the pulse parameters always the same.
	Focus in performance.