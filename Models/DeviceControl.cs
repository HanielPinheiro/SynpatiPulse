using System.IO.Ports;

namespace SynaptiPulse.Models
{
    public class DeviceControl : IDisposable
    {
        private readonly DeviceControlParameters parameters = new();
        private readonly SerialPort serialPort;

        public bool IsConnected { get => serialPort!.IsOpen; }

        public DeviceControl() { serialPort = new SerialPort(); }

        /// <summary>
        /// This constructor use <see cref="string"/>
        /// </summary>
        /// <param name="_portName"></param>
        public DeviceControl(string _portName)
        {
            serialPort = new SerialPort();

            parameters.PortName = _portName;
            parameters.CopyTo(serialPort);
        }

        /// <summary>
        /// This constructor use <see cref="DeviceControlParameters"/>
        /// </summary>
        /// <param name="_parameters"></param>
        public DeviceControl(DeviceControlParameters _parameters)
        {
            serialPort = new SerialPort();

            parameters.CopyFrom(_parameters);
            parameters.CopyTo(serialPort);
        }

        #region Reset

        /// <summary>
        /// Reset serialPort
        /// </summary>
        public void Reset()
        {
            Dispose();

            parameters.CopyFrom(new DeviceControlParameters());
            parameters.CopyTo(serialPort);

            InitializeSerialPort();
        }

        #endregion

        #region Open / Dispose

        /// <summary>
        /// Initialize serial port = serialPort.Open()
        /// </summary>
        public void InitializeSerialPort() { serialPort!.Open(); }

        /// <summary>
        /// Following IDispose
        /// </summary>
        public void Dispose()
        {
            if (IsConnected)
            {
                serialPort!.Close();
                serialPort!.Dispose();

                GC.SuppressFinalize(this);
            }
        }

        /// <summary>
        /// Dispose Serial Port Connection
        /// </summary>
        public void Dispose(string? instructionToSendToTurnOffBoard)
        {
            if (IsConnected)
            {
                if (!string.IsNullOrEmpty(instructionToSendToTurnOffBoard))
                {
                    serialPort!.Write(instructionToSendToTurnOffBoard);
                    Thread.Sleep(SynaptiPulse.Delay);
                }

                serialPort!.Dispose();
            }
        }

        #endregion

        #region DataReceiveHandler      

        /// <summary>
        /// Set a Received Event Handler to handler data received from board
        /// </summary>
        /// <param name="dataReceivedHandler"></param>
        public void SetDataReceivedEventHandler(SerialDataReceivedEventHandler dataReceivedHandler)
        {
            serialPort!.DataReceived += dataReceivedHandler;
        }

        /// <summary>
        /// Set a Received Event Handler to handler data received from board
        /// </summary>
        /// <param name="dataReceivedHandler"></param>
        public void UnSetDataReceivedEventHandler(SerialDataReceivedEventHandler dataReceivedHandler)
        {
            serialPort!.DataReceived -= dataReceivedHandler;
        }

        /// <summary>
        /// Encapsulation of WriteLine
        /// </summary>
        /// <param name="txt"></param>
        public void SendData(string txt)
        {
            if (IsConnected) serialPort!.WriteLine(txt);
        }

        /// <summary>
        /// Encapsulation of ReadLine
        /// </summary>
        /// <returns></returns>
        public string ReadLine()
        {
                return serialPort.ReadLine();
        }

        #endregion

    }
}








