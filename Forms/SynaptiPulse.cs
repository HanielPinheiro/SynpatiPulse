using SynaptiPulse.Models;
using SynaptiPulse.Utils;
using MaterialSkin;
using MaterialSkin.Controls;
using OxyPlot;
using OxyPlot.Series;
using System.ComponentModel;
using System.Data;
using System.IO.Ports;
using System.Globalization;
using System.Text;
using OxyPlot.WindowsForms;

namespace SynaptiPulse
{
    public partial class SynaptiPulse : MaterialForm
    {
        private DeviceControl? serialControl = new();
        private readonly DeviceControlParameters? editableParameters = new();

        public bool IsRunning { get; private set; } = false;
        public int numberOfPulses = 0;
        private string receivedData = string.Empty;
        private string chaosData = string.Empty;

        private readonly BindingList<Pulse> periodicTabPulses = new();
        private readonly BindingList<Pulse> chaoticTabPulses = new();

        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        private DataGridViewCellStyle? DefaultCellStyle;

        public const string STOP_READ = "M>";
        public const string RESET_BOARD = "D>";
        private const string JUMPLINE = "\r\n";
        private const string RESET_PREVIOUS_SETUP = "R>";
        private const string START_ROUTINE = "J>";
        private const string STOP_ROUTINE = "K>";
        private const string START_READ = "L>";

        public SynaptiPulse()
        {
            InitializeComponent();
            SetFormTheme();

            #region Set combo boxes

            ChaosTab_CbCurrent.DataSource = Pulse.PulseCurrentToCombobox.Select(p => p.Value).ToList();
            PeriodicTab_CbCurrents.DataSource = Pulse.PulseCurrentToCombobox.Select(p => p.Value).ToList();

            cbParity.Items.Clear();
            cbParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            cbParity.SelectedIndex = 0;

            cbStopBits.Items.Clear();
            cbStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            cbStopBits.SelectedIndex = 0;

            cbHandShake.Items.Clear();
            cbHandShake.Items.AddRange(Enum.GetNames(typeof(Handshake)));
            cbHandShake.SelectedIndex = 0;

            #endregion

            #region Initialize Serial Data

            RefreshCom();
            FillFieldsWithDefaultData(false);
            DisableFields();

            #endregion
        }

        #region On Load

        private void SetFormTheme()
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            DefaultCellStyle = new DataGridViewCellStyle()
            {
                BackColor = materialSkinManager.ColorScheme.PrimaryColor,
                ForeColor = materialSkinManager.ColorScheme.TextColor,
                SelectionBackColor = materialSkinManager.ColorScheme.PrimaryColor,
                SelectionForeColor = materialSkinManager.ColorScheme.TextColor,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
            };
        }

        private void BrainStimulator_Load(object sender, EventArgs e)
        {
            PeriodicTab_ChartPlotView.Model = GetModel();
            PeriodicTab_GridMain.DefaultConfiguration(periodicTabPulses, () => PeriodicTab_GridMain.SetPersistString(this.GetType().FullName + Pulse.CompleteLayout));
            PeriodicTab_GridMain.SetCellStyle(DefaultCellStyle!);
            PeriodicTab_GridMain.SetHeaderText(Pulse.DisplayNameFromProperties);
            PeriodicTab_GridMain.SetWidth(Pulse.ColumSizeFromProperties);

            ChaosTab_GridMain.DefaultConfiguration(periodicTabPulses, () => ChaosTab_GridMain.SetPersistString(this.GetType().FullName + Pulse.SingleLayout));
            ChaosTab_GridMain.SetCellStyle(DefaultCellStyle!);
            ChaosTab_GridMain.SetHeaderText(Pulse.DisplayNameFromProperties);
            ChaosTab_GridMain.SetWidth(Pulse.ColumSizeFromProperties);
            ChaosTab_ChartPlotView_Train.Model = GetModelToTrainPulses();
        }

        #endregion

        #region Pulses Interface

        #region Periodic Tab

        #region Charts

        private void RefreshChart_PeriodicTab()
        {
            try
            {
                PlotModel model = GetModel();
                LineSeries? lineSeries = model.Series[0] as LineSeries;
                PulseLikeDataPoint chartPoints;
                PulseLikeDataPoint? predecessor = null;

                foreach (DataGridViewRow row in PeriodicTab_GridMain.Rows)
                    if (row.DataBoundItem is Pulse pulse)
                    {
                        chartPoints = new PulseLikeDataPoint();
                        chartPoints.SetDataPointsFrom(pulse, lineSeries!, predecessor);
                        predecessor = chartPoints;
                    }

                PeriodicTab_ChartPlotView.Model = model;
            }
            catch (Exception ex) { Error($"Problema ao tentar executar {nameof(RefreshChart_PeriodicTab)}", ex); }
        }
        private PlotModel GetModel()
        {
            var model = new PlotModel();
            var lineSeries = new LineSeries()
            {
                SeriesGroupName = "Series 1",
                Color = OxyColor.FromRgb(materialSkinManager.ColorScheme.PrimaryColor.R, materialSkinManager.ColorScheme.PrimaryColor.G, materialSkinManager.ColorScheme.PrimaryColor.B),
                MarkerType = MarkerType.Circle,
                MarkerSize = 6,
                MarkerStroke = OxyColor.FromRgb(materialSkinManager.ColorScheme.DarkPrimaryColor.R, materialSkinManager.ColorScheme.DarkPrimaryColor.G, materialSkinManager.ColorScheme.DarkPrimaryColor.B),
                MarkerFill = OxyColor.FromRgb(materialSkinManager.ColorScheme.LightPrimaryColor.R, materialSkinManager.ColorScheme.LightPrimaryColor.G, materialSkinManager.ColorScheme.LightPrimaryColor.B),
                MarkerStrokeThickness = 1.5,

            };
            model.Series.Add(lineSeries);
            return model;
        }

        private PlotModel GetModelToTrainPulses()
        {
            var model = new PlotModel();
            var lineSeries = new LineSeries()
            {
                SeriesGroupName = "Series 1",
                Color = OxyColor.FromRgb(materialSkinManager.ColorScheme.PrimaryColor.R, materialSkinManager.ColorScheme.PrimaryColor.G, materialSkinManager.ColorScheme.PrimaryColor.B),
                MarkerType = MarkerType.Circle,
                MarkerSize = 1,
                MarkerStroke = OxyColor.FromRgb(materialSkinManager.ColorScheme.DarkPrimaryColor.R, materialSkinManager.ColorScheme.DarkPrimaryColor.G, materialSkinManager.ColorScheme.DarkPrimaryColor.B),
                MarkerFill = OxyColor.FromRgb(materialSkinManager.ColorScheme.LightPrimaryColor.R, materialSkinManager.ColorScheme.LightPrimaryColor.G, materialSkinManager.ColorScheme.LightPrimaryColor.B),
                MarkerStrokeThickness = 0.5,                
            };
            model.Series.Add(lineSeries);
            return model;
        }

        #endregion

        #region Header Panel

        private void PeriodicTab_AddPulse_Click(object sender, EventArgs e)
        {
            if (periodicTabPulses.Count < 10)
            {
                var p = new Pulse();
                if (PeriodicTab_SwitchCurrent.Checked) p.Current = (PeriodicTab_CbCurrents.SelectedValue as string)!;
                periodicTabPulses.Add(p);
                RefreshAll_PeriodicTab();
            }
        }

        private void PeriodicTab_RemovePulse_Click(object sender, EventArgs e)
        {
            HashSet<Pulse> pulsesToRemove = new();

            foreach (DataGridViewCell cell in PeriodicTab_GridMain.SelectedCells)
                if (PeriodicTab_GridMain.Rows[cell.RowIndex].DataBoundItem is Pulse pulse) pulsesToRemove.Add(pulse);

            foreach (Pulse pulse in pulsesToRemove) periodicTabPulses.Remove(pulse);

            RefreshAll_PeriodicTab();
        }

        private void PeriodicTab_SendConfigToBoard_Click(object sender, EventArgs e)
        {
            Task.WaitAny(Task.Run(() => SendConfig_PeriodicData()));
        }

        private void PeriodicTab_CbCurrents_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Pulse item in periodicTabPulses)
                if (PeriodicTab_SwitchCurrent.Checked)
                {
                    item.Current = (PeriodicTab_CbCurrents.SelectedValue as string)!;
                    RefreshAll_PeriodicTab();
                }
        }

        private void PeriodicTab_SwitchGlobalCurrent_CheckedChanged(object sender, EventArgs e)
        {
            if (PeriodicTab_SwitchCurrent.Checked)
            {
                string message = $"Você realmente deseja fixar a corrente? {JUMPLINE}{JUMPLINE} Isso irá modificar o valor de corrente em todas as linhas.";
                string caption = "Fixar Corrente";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) SetFixedCurrents();
                else PeriodicTab_SwitchCurrent.Checked = false;
            }

            PeriodicTab_CbCurrents.Enabled = PeriodicTab_SwitchCurrent.Checked;
        }

        private void SetFixedCurrents()
        {
            PeriodicTab_CbCurrents.Enabled = PeriodicTab_SwitchCurrent.Checked;
            foreach (Pulse item in periodicTabPulses) item.Current = (PeriodicTab_CbCurrents.SelectedValue as string)!;
            RefreshAll_PeriodicTab();
        }

        private void RefreshAll_PeriodicTab()
        {
            Refresh();
            RefreshChart_PeriodicTab();
        }

        #endregion

        #region Grid Main

        private void PeriodicTab_GridMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Ignore
        }

        private void PeriodicTab_GridMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView? grid = sender as DataGridView;
            if (grid!.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn column && column!.DataPropertyName == nameof(Pulse.Current))
            {
                if (PeriodicTab_SwitchCurrent.Checked)
                {
                    if (grid![e.ColumnIndex, e.RowIndex] is DataGridViewComboBoxCell comboBox)
                        comboBox.Value = PeriodicTab_CbCurrents.SelectedValue;
                }
            }

            RefreshChart_PeriodicTab();
        }

        private void PeriodicTab_GridMain_ColumnDataPropertyNameChanged(object sender, DataGridViewColumnEventArgs e)
        {
            switch (e.Column.DataPropertyName)
            {
                case nameof(Pulse.AfterPulseMeasureUnity):
                case nameof(Pulse.PulseMeasureUnity):
                    (sender as DataGridView)!.ConvertColumnToComboBox(e, DataToCombobox.GetListFrom(Pulse.MeasureUnityToCombobox.Select(p => p.Value).ToList()), "Name", "Name");
                    break;

                case nameof(Pulse.Current):
                    (sender as DataGridView)!.ConvertColumnToComboBox(e, DataToCombobox.GetListFrom(Pulse.PulseCurrentToCombobox.Select(p => p.Value).ToList()), "Name", "Name");
                    break;

                case nameof(Pulse.Polarity):
                    (sender as DataGridView)!.ConvertColumnToComboBox(e, DataToCombobox.GetListFrom(Pulse.PulsePolarityToCombobox.Select(p => p.Value).ToList()), "Name", "Name");
                    break;

                default:
                    (sender as DataGridView)!.ConvertColumnDefault(e);
                    break;
            }
        }

        #endregion

        #endregion

        #region Chaos Tab

        private void RefreshAll_ChaosTab()
        {
            Refresh();
            RefreshChart_ChaosTab();
        }

        private void RefreshChart_ChaosTab()
        {
            try
            {
                PlotModel model = GetModel();
                LineSeries? lineSeries = model.Series[0] as LineSeries;
                PulseLikeDataPoint chartPoints;
                PulseLikeDataPoint? predecessor = null;

                foreach (DataGridViewRow row in ChaosTab_GridMain.Rows)
                    if (row.DataBoundItem is Pulse pulse)
                    {
                        chartPoints = new PulseLikeDataPoint();
                        chartPoints.SetDataPointsFrom(pulse, lineSeries!, predecessor);
                        predecessor = chartPoints;
                    }

                ChaosTab_ChartPlotView_Train.Model = model;
            }
            catch (Exception ex) { Error($"Problema ao tentar executar {nameof(RefreshChart_ChaosTab)}", ex); }
        }

        private void ChaosTab_CbCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Pulse item in chaoticTabPulses)
                item.Current = (ChaosTab_CbCurrent.SelectedValue as string)!;
            RefreshAll_ChaosTab();
        }

        private void ChaosTab_TxtPulseLength_Leave(object sender, EventArgs e)
        {
            try
            {
                string value = ChaosTab_TxtPulseLength.Text;
                bool conversion = double.TryParse(value.Replace(',', '.'), out double newValue);
                if (conversion) newValue = Math.Round(newValue, 0);
                else newValue = Math.Round(double.Parse(value, NumberStyles.None, CultureInfo.CurrentCulture), 0);
                newValue /= 1000000d;

                List<double> interpulsesIntervals = chaosData.Split("\r\n", StringSplitOptions.RemoveEmptyEntries).Select(p => Math.Round((double.Parse(p, CultureInfo.InvariantCulture) - newValue) * 1000, 3)).ToList();
                if (interpulsesIntervals.Any(p => p <= 0)) throw new InvalidOperationException("O tempo estipulado para largura do pulso é muito grande!");

                MeasureUnity newUnity = MeasureUnity.Microseconds;
                if (newValue >= 1d) newUnity = MeasureUnity.Seconds;
                else if (newValue >= 0.001d)
                {
                    newUnity = MeasureUnity.Milliseconds;
                    newValue *= 1000d;
                }

                int counter = 0;
                foreach (Pulse item in chaoticTabPulses)
                {
                    item.PulseLength = newValue;
                    item.PulseMeasureUnity = Pulse.MeasureUnityToCombobox[newUnity];
                    item.AfterPulseLength = interpulsesIntervals[counter];
                    counter++;
                }

                RefreshAll_ChaosTab();
            }
            catch (InvalidOperationException iEx) { Error("Erro por ação inválida!", iEx); }
            catch (Exception ex) { Error("Erro não esperado!", ex); }
        }

        private void ChaosTab_LoadPulses_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = string.Empty;

                using (OpenFileDialog openFileDialog = new())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK) filePath = openFileDialog.FileName;
                    else return;
                }

                chaosData = string.Empty;
                using (FileStream fs = File.OpenRead(filePath))
                {
                    int newData;
                    byte[] buffer = new byte[1024];
                    UTF8Encoding temp = new(true);

                    while ((newData = fs.Read(buffer, 0, buffer.Length)) > 0)
                        chaosData += temp.GetString(buffer, 0, newData);
                }

                string current = (ChaosTab_CbCurrent.SelectedValue as string)!;
                double pulseLength = double.Parse(ChaosTab_TxtPulseLength.Text.Replace(',', '.').Split('.')[0], CultureInfo.InvariantCulture);
                double pulseLengthInMicros = pulseLength / 1000000.0d;

                List<double> interpulsesIntervals = chaosData.Split("\r\n", StringSplitOptions.RemoveEmptyEntries).Select(p => Math.Round((double.Parse(p, CultureInfo.InvariantCulture) - pulseLengthInMicros) * 1000, 3)).ToList();
                if (interpulsesIntervals.Any(p => p <= 0)) throw new InvalidOperationException("O tempo estipulado para largura do pulso é muito grande!");

                chaoticTabPulses.Clear();

                foreach (double interval in interpulsesIntervals)
                {
                    Pulse p = new()
                    {
                        Polarity = Pulse.PulsePolarityToCombobox[PulsePolariy.Positive],
                        Current = current,
                        PulseLength = pulseLength,
                        PulseMeasureUnity = Pulse.MeasureUnityToCombobox[MeasureUnity.Microseconds],
                        AfterPulseLength = interval,
                        AfterPulseMeasureUnity = Pulse.MeasureUnityToCombobox[MeasureUnity.Milliseconds]
                    };
                    chaoticTabPulses.Add(p);
                }

                ChaosTab_GridMain.DataSource = chaoticTabPulses;
                RefreshAll_ChaosTab();
            }
            catch (InvalidOperationException iEx) { Error("Erro por ação inválida!", iEx); }
            catch (Exception ex) { Error("Erro ao carregar arquivo caótico", ex); }

        }

        private void ChaosTab_SendConfigToBoard_Click(object sender, EventArgs e)
        {


            Task.WaitAny(Task.Run(() => SendConfig_ChaoticData()));
        }


        #endregion

        #endregion

        #region Interface USB Serial Control

        #region btnUpdate

        private void BtnUpdate_Click(object sender, EventArgs e) { RefreshCom(); }

        private void RefreshCom()
        {
            cbComPortsList.Items.Clear();
            cbComPortsList.Items.AddRange(SerialPort.GetPortNames());
            if (cbComPortsList.Items.Count > 0) cbComPortsList.SelectedIndex = 0;
        }
        #endregion

        #region Switch Parameters On / Off

        private void EnableFields()
        {
            SetState(true);
        }

        private void DisableFields()
        {
            SetState(false);
        }

        private void SetState(bool enable)
        {
            txtBaudRate.Enabled = enable;
            txtDataBits.Enabled = enable;
            txtReadTimeOut.Enabled = enable;
            txtWriteTimeOut.Enabled = enable;

            cbParity.Enabled = enable;
            cbStopBits.Enabled = enable;
            cbHandShake.Enabled = enable;
        }
        private void SwitchDefaultParameters_CheckedChanged(object sender, EventArgs e)
        {
            if (switchDefaultParameters.Checked)
            {
                FillFieldsWithDefaultData(true);
                DisableFields();
            }
            else
            {
                FillFieldsWithLastData();
                EnableFields();
            }
        }
        #endregion

        #region CopyFromParametersToFields

        private void FillFieldsWithLastData()
        {
            txtBaudRate.Text = editableParameters!.BaudRate.ToString();
            txtDataBits.Text = editableParameters!.DataBits.ToString();
            txtReadTimeOut.Text = editableParameters!.ReadTimeOut.ToString();
            txtWriteTimeOut.Text = editableParameters!.WriteTimeOut.ToString();

            cbParity.SelectedIndex = cbParity.Items.IndexOf(editableParameters!.Parity.ToString());
            cbStopBits.SelectedIndex = cbStopBits.Items.IndexOf(editableParameters!.StopBits.ToString());
            cbHandShake.SelectedIndex = cbHandShake.Items.IndexOf(editableParameters!.HandShake.ToString());
        }

        private void FillFieldsWithDefaultData(bool savePreviousParams)
        {
            if (savePreviousParams) CopyFieldsValuesToParameters();

            var param = new DeviceControlParameters();

            txtBaudRate.Text = param.BaudRate.ToString();
            txtDataBits.Text = param.DataBits.ToString();
            txtReadTimeOut.Text = param.ReadTimeOut.ToString();
            txtWriteTimeOut.Text = param.WriteTimeOut.ToString();

            cbParity.SelectedIndex = cbParity.Items.IndexOf(param.Parity.ToString());
            cbStopBits.SelectedIndex = cbStopBits.Items.IndexOf(param.StopBits.ToString());
            cbHandShake.SelectedIndex = cbHandShake.Items.IndexOf(param.HandShake.ToString());
        }

        #endregion

        #region Connect / Disconnect

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                CopyFieldsValuesToParameters();
                editableParameters!.PortName = cbComPortsList.SelectedItem.ToString();
                serialControl = new DeviceControl(editableParameters);
                serialControl!.InitializeSerialPort();

                SetButtonsState(false);

                SetDataCommunication();
            }
            catch (Exception ex) { Error("Problema ao tentar conectar na placa", ex); }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                CloseSerialPort();

                SetConnectOrDisconnectState(true);
            }
            catch (Exception ex) { Error("Problema ao tentar conectar na placa", ex); }
        }

        private void SetButtonsState(bool value)
        {
            SetConnectOrDisconnectState(value);

            cbHandShake.Enabled = value;
            cbParity.Enabled = value;
            cbStopBits.Enabled = value;

            txtBaudRate.Enabled = value;
            txtDataBits.Enabled = value;
            txtReadTimeOut.Enabled = value;
            txtWriteTimeOut.Enabled = value;
        }

        private void SetConnectOrDisconnectState(bool value)
        {
            btnConnect.Enabled = value;
            btnDisconnect.Enabled = !value;
            PeriodicTab_SendConfigToBoard.Enabled = !value;
            ChaosTab_btnSendConfigToBoard.Enabled = !value;

            cbComPortsList.Enabled = value;
            btnUpdate.Enabled = value;
            switchDefaultParameters.Enabled = value;
        }

        #endregion

        #region txtReceiveData

        private void TxtReceivedData_TextChanged(object sender, EventArgs e)
        {
            txtReceivedData.SelectionStart = txtReceivedData.TextLength;
            txtReceivedData.ScrollToCaret();
        }
        public void ResetControllers(int newNumberOfPulses)
        {
            IsRunning = false;
            numberOfPulses = newNumberOfPulses;
            receivedData = string.Empty;
            this.BeginInvoke(() => { txtReceivedData.Text = string.Empty; });
        }

        #endregion

        #region Copy To
        private void CopyFieldsValuesToParameters()
        {
            try { editableParameters!.BaudRate = int.Parse(txtBaudRate.Text); }
            catch (Exception e) { Error($"Falha ao converter valor do campo BaudRate", e); }

            try { editableParameters!.DataBits = int.Parse(txtDataBits.Text); }
            catch (Exception e) { Error($"Falha ao converter valor do campo DataBits", e); }

            try { editableParameters!.ReadTimeOut = int.Parse(txtReadTimeOut.Text); }
            catch (Exception e) { Error($"Falha ao converter valor do campo ReadTimeOut", e); }

            try { editableParameters!.WriteTimeOut = int.Parse(txtWriteTimeOut.Text); }
            catch (Exception e) { Error($"Falha ao converter valor do campo WriteTimeOut", e); }

            try
            {
                var str = cbParity.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(str)) editableParameters!.Parity = Enum.Parse<Parity>(str);
            }
            catch (Exception e) { Error($"Falha ao converter valor do campo Parity", e); }

            try
            {
                var str = cbStopBits.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(str)) editableParameters!.StopBits = Enum.Parse<StopBits>(str);
            }
            catch (Exception e) { Error($"Falha ao converter valor do campo StopBits", e); }

            try
            {
                var str = cbHandShake.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(str)) editableParameters!.HandShake = Enum.Parse<Handshake>(str);
            }
            catch (Exception e) { Error($"Falha ao converter valor do campo HandShake", e); }
        }

        #endregion

        #region SerialPorts  
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string newText = ((SerialPort)sender).ReadExisting();
            this.BeginInvoke(() => { txtReceivedData.Text += newText; });
            //txtReceivedData.Text += ((SerialPort)sender).ReadExisting();
        }

        private void SetDataCommunication()
        {
            serialControl!.SetDataReceivedEventHandler(new SerialDataReceivedEventHandler(DataReceivedHandler));
        }

        public void ResetDataCommunication()
        {
            Task<string> responseTask;
            int localDelay = 2000;

            try
            {
                SendData(SynaptiPulse.STOP_READ);
                responseTask = Task.Run(() => serialControl!.ReadLine());
                Task.WaitAny(responseTask, Task.Delay(localDelay));
            }
            catch {/*Ignore*/ }

            try
            {
                SendData(SynaptiPulse.RESET_BOARD);
                responseTask = Task.Run(() => serialControl!.ReadLine());
                Task.WaitAny(responseTask, Task.Delay(localDelay));
            }
            catch {/*Ignore*/ }

            serialControl!.UnSetDataReceivedEventHandler(new SerialDataReceivedEventHandler(DataReceivedHandler));
        }

        /// <summary>
        /// Encapsulation of <see cref="DeviceControl.SendData(string)"/>. The objective is show Error if fail.
        /// </summary>
        /// <param name="text"></param>
        public void SendData(string text)
        {
            try { serialControl!.SendData(text); }
            catch (Exception ex) { Error($"Error when try to{nameof(SendData)}!", ex); }
        }

        public void SendConfig_PeriodicData()
        {
            int delay = 100;
            ResetControllers(PeriodicTab_GridMain.Rows.Count);
            try
            {
                SendData(STOP_ROUTINE);
                Thread.Sleep(delay);

                SendData(STOP_READ);
                Thread.Sleep(delay);

                SendData(RESET_PREVIOUS_SETUP);
                Thread.Sleep(delay);

                SendData(START_READ);
                Thread.Sleep(delay);

                foreach (DataGridViewRow row in PeriodicTab_GridMain.Rows)
                {
                    if (row.DataBoundItem is Pulse pulse)
                    {
                        var txt = pulse.ToString().Replace(",", ".");
                        SendData(txt);
                        Thread.Sleep(delay);
                    }
                }

                SendData(STOP_READ);
                Thread.Sleep(delay);

                SendData(START_ROUTINE);
                Thread.Sleep(delay);
            }
            catch (Exception ex) { Error("Error when try to send configs to the board", ex); }
        }

        public void SendConfig_ChaoticData()
        {
            int delay = 100;
            ResetControllers(ChaosTab_GridMain.Rows.Count);
            try
            {
                SendData(STOP_ROUTINE);
                Thread.Sleep(delay);

                SendData(STOP_READ);
                Thread.Sleep(delay);

                SendData(RESET_PREVIOUS_SETUP);
                Thread.Sleep(delay);

                SendData(START_READ);
                Thread.Sleep(delay);

                foreach (DataGridViewRow row in ChaosTab_GridMain.Rows)
                {
                    if (row.DataBoundItem is Pulse pulse)
                    {
                        var txt = pulse.ToString().Replace(",", ".");
                        SendData(txt);
                        Thread.Sleep(delay);
                    }
                }

                SendData(STOP_READ);
                Thread.Sleep(delay);

                SendData(START_ROUTINE);
                Thread.Sleep(delay);
            }
            catch (Exception ex) { Error("Error when try to send configs to the board", ex); }
        }

        #endregion

        #endregion

        #region Form Closed / Closing
        private void BrainStimulator_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseSerialPort();
        }

        private void BrainStimulator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialControl != null && serialControl.IsConnected)
            {
                string message = $"Você realmente deseja fechar esta janela? {JUMPLINE}{JUMPLINE} Isso irá cortar a comunicação com o estimulador.";
                string caption = "Fechar Interface";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) e.Cancel = true;
            }
        }

        /// <summary>
        /// In this method has a double security check. If ResetDataCommunication don't reset board, Dispose will try to do
        /// </summary>
        private void CloseSerialPort()
        {
            if (serialControl != null && serialControl!.IsConnected)
            {
                ResetDataCommunication();

                btnConnect.Enabled = true;
                PeriodicTab_SendConfigToBoard.Enabled = false;

                try { serialControl!.Dispose(RESET_BOARD); } catch { /* Ignorado */ }
            }
        }

        #endregion

        #region Error

        private static void Error(string errorMessage, Exception e)
        {
            MessageBox.Show($"{errorMessage} {JUMPLINE}{JUMPLINE}Exception message:{JUMPLINE} {e.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
        }

        #endregion

     
    }
}
