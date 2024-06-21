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

namespace SynaptiPulse
{
    public partial class SynaptiPulse : MaterialForm
    {
        private DeviceControl? serialControl = new();
        private readonly DeviceControlParameters? editableParameters = new();

        private string chaosData = string.Empty;
        private Pulse[][]? parsedChaosData = null;
        private double chaosInterval = 0d;
        private bool PulseTrainRunning = false;
        private bool HasParsed = false;
        private bool NeedWaiting = false;
        private bool CanSend = false;

        private readonly BindingList<Pulse> periodicTabPulses = new();
        private readonly BindingList<Pulse> chaoticTabPulses = new();

        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        private DataGridViewCellStyle? DefaultCellStyle;

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

        private void PeriodicTab_SaveRoutine_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new();
            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.FilterIndex = 1;
            saveDialog.RestoreDirectory = true;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveDialog.FileName;

                using (StreamWriter sw = new(path))
                {
                    foreach (var pulse in periodicTabPulses)
                        sw.WriteLine(pulse);
                }
            }
        }

        private void PeriodicTab_LoadRoutine_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new();
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;

                using (StreamReader sr = File.OpenText(path))
                {
                    string? newLine = string.Empty;
                    while ((newLine = sr.ReadLine()) != null)
                    {
                        var p = new Pulse(newLine);
                        periodicTabPulses.Add(p);
                    }
                }
                PeriodicTab_CbCurrents.Enabled = false;
                PeriodicTab_SwitchCurrent.Checked = false;
                RefreshAll_PeriodicTab();
            }
        }

        private void PeriodicTab_SendConfigToBoard_Click(object sender, EventArgs e)
        {
            Task.WaitAny(Task.Run(() => SendConfig_PeriodicData()));
        }


        private void PeriodicTab_StartStimulation_Click(object sender, EventArgs e)
        {
            if (PeriodicTab_StartStimulation.Text == "Começar Estimulação")
            {
                SendData($"{DeviceControl.PREFIX}{DeviceControl.ROUTINE_START}{DeviceControl.SUFIX}");
                Thread.Sleep(DeviceControl.Delay);
                PeriodicTab_StartStimulation.Text = "Parar Estimulação";
                PeriodicTab_SendConfigToBoard.Enabled = false;
            }
            else
            {
                SendData($"{DeviceControl.PREFIX}{DeviceControl.ROUTINE_STOP}{DeviceControl.SUFIX}");
                Thread.Sleep(DeviceControl.Delay);
                PeriodicTab_StartStimulation.Text = "Começar Estimulação";
                PeriodicTab_SendConfigToBoard.Enabled = true;
            }
        }
        
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
                string message = $"Você realmente deseja fixar a corrente? {DeviceControl.JUMPLINE}{DeviceControl.JUMPLINE} Isso irá modificar o valor de corrente em todas as linhas.";
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

        private void PeriodicTab_GridMain_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (periodicTabPulses.Count > 0)
            {
                PeriodicTab_SaveRoutine.Enabled = true;
                PeriodicTab_RemovePulse.Enabled = true;
                PeriodicTab_SwitchCurrent.Enabled = true;
                PeriodicTab_SendConfigToBoard.Enabled = true;
            }
        }

        private void PeriodicTab_GridMain_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (periodicTabPulses.Count <= 0)
            {
                PeriodicTab_SaveRoutine.Enabled = false;
                PeriodicTab_RemovePulse.Enabled = false;
                PeriodicTab_SwitchCurrent.Enabled = false;
                PeriodicTab_SendConfigToBoard.Enabled = false;
            }
        }

        #endregion

        #endregion

        #region Chaos Tab

        private void RefreshAll_ChaosTab()
        {
            RefreshCbPulseTrains();
            RefreshPartial_ChaosTab();
        }

        private void RefreshPartial_ChaosTab()
        {
            Refresh();
            RefreshChart_ChaosTab();
        }

        private void RefreshCbPulseTrains()
        {
            if (parsedChaosData != null && parsedChaosData!.Length > 0)
            {
                List<string> l = new();
                for (int i = 0; i < parsedChaosData.Length; i++) l.Add(DeviceControl.CB_PULSE_TRAIN + (i + 1));
                ChaosTab_CbPulseTrains.DataSource = l;
                ChaosTab_CbPulseTrains.Enabled = true;
            }
        }

        private void RefreshChart_ChaosTab()
        {
            try
            {
                PlotModel model = GetModel();
                LineSeries? lineSeries = model.Series[0] as LineSeries;
                PulseLikeDataPoint chartPoints;
                PulseLikeDataPoint? predecessor = null;

                foreach (Pulse p in chaoticTabPulses)
                {
                    chartPoints = new PulseLikeDataPoint();
                    chartPoints.SetDataPointsFrom(p, lineSeries!, predecessor);
                    predecessor = chartPoints;
                }

                ChaosTab_ChartPlotView_Train.Model = model;
            }
            catch (Exception ex) { Error($"Problema ao tentar executar {nameof(RefreshChart_ChaosTab)}", ex); }
        }

        private void ChaosTab_CbCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (parsedChaosData != null)
            {
                foreach (var data in parsedChaosData!)
                    foreach (Pulse item in data) item.Current = (ChaosTab_CbCurrent.SelectedValue as string)!;
                RefreshAll_ChaosTab();
            }
        }

        private void ChaosTab_CbPulseTrains_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (parsedChaosData != null)
            {
                int value = int.Parse((ChaosTab_CbPulseTrains.SelectedValue as string)!.Replace(DeviceControl.CB_PULSE_TRAIN, ""), CultureInfo.InvariantCulture);
                chaoticTabPulses.Clear();
                foreach (var item in parsedChaosData![value - 1]) chaoticTabPulses.Add(item);
                RefreshPartial_ChaosTab();
            }
        }

        private void ChaosTab_TxtPulseLength_Leave(object sender, EventArgs e)
        {
            try
            {
                string value = ChaosTab_TxtPulseLength.Text;
                bool conversion = double.TryParse(value.Replace(',', '.'), out double newValue);
                if (conversion) newValue = Math.Round(newValue, 0);
                else newValue = Math.Round(double.Parse(value, NumberStyles.None, CultureInfo.CurrentCulture), 0);

                ParseData(newValue);
            }
            catch (InvalidOperationException iEx) { Error("Erro por ação inválida!", iEx); }
            catch (Exception ex) { Error("Erro não esperado!", ex); }
        }

        private void ChaosTab_LoadPulses_Click(object sender, EventArgs e)
        {
            try
            {
                #region Choose File

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

                #endregion

                #region Read File

                chaosData = string.Empty;
                using (FileStream fs = File.OpenRead(filePath))
                {
                    int newData;
                    byte[] buffer = new byte[1024];
                    UTF8Encoding temp = new(true);

                    while ((newData = fs.Read(buffer, 0, buffer.Length)) > 0)
                        chaosData += temp.GetString(buffer, 0, newData);
                }
                chaosData = chaosData.Replace(',', '.');

                #endregion

                ParseData();
            }
            catch (InvalidOperationException iEx) { Error("Erro por ação inválida!", iEx); }
            catch (Exception ex) { Error("Erro ao carregar arquivo caótico", ex); }
        }

        private void ParseData(double? newPulseLengthValueInMicros = null)
        {
            string current = (ChaosTab_CbCurrent.SelectedValue as string)!;

            double pulseLength = 0d;
            if (newPulseLengthValueInMicros.HasValue) pulseLength = newPulseLengthValueInMicros.Value;
            else pulseLength = double.Parse(ChaosTab_TxtPulseLength.Text.Replace(',', '.').Split('.')[0], CultureInfo.InvariantCulture);
            double pulseLengthInSeconds = pulseLength / 1e6d;

            string pulseLengthMeasure = Pulse.MeasureUnityToCombobox[MeasureUnity.Microseconds];
            if (pulseLength >= 1e6d) { pulseLength /= 1e6d; pulseLengthMeasure = Pulse.MeasureUnityToCombobox[MeasureUnity.Seconds]; }
            else if (pulseLength >= 1e3d) { pulseLength /= 1e3d; pulseLengthMeasure = Pulse.MeasureUnityToCombobox[MeasureUnity.Milliseconds]; }

            List<double[]> totalData = chaosData.Split("\r\n", StringSplitOptions.RemoveEmptyEntries)
                                                .Select(p => p.Split(';', StringSplitOptions.RemoveEmptyEntries)
                                                              .Select(d => double.Parse(d, CultureInfo.InvariantCulture)).ToArray())
                                                .ToList();
            int rows = totalData.Count;
            int columns = totalData[0].Length;
            parsedChaosData = new Pulse[columns][];

            Pulse[]? rowData = null;

            for (int col = 0; col < columns; col++)
            {
                rowData = new Pulse[rows];
                for (int row = 0; row < rows; row++)
                {
                    double afterPulseLengthInMs = 0d;
                    if (row > 0) afterPulseLengthInMs = Math.Round((totalData[row][col] - pulseLengthInSeconds) * 1000, 3);
                    else afterPulseLengthInMs = Math.Round(totalData[row][col] * 1000, 3);
                    if (afterPulseLengthInMs <= 0d) throw new InvalidOperationException("O tempo estipulado para largura do pulso é muito grande!");

                    Pulse pulse = new()
                    {
                        Polarity = Pulse.PulsePolarityToCombobox[PulsePolariy.Positive],
                        Current = current,
                        PulseLength = row > 0 ? pulseLength : 0,
                        PulseMeasureUnity = pulseLengthMeasure,
                        AfterPulseLength = afterPulseLengthInMs,
                        AfterPulseMeasureUnity = Pulse.MeasureUnityToCombobox[MeasureUnity.Milliseconds]
                    };

                    rowData[row] = pulse;
                }
                parsedChaosData[col] = rowData;
            }

            RefreshAll_ChaosTab();
        }

        private void DisableConfig()
        {
            ChaosTab_CbCurrent.Enabled = false;
            ChaosTab_TxtPulseLength.Enabled = false;
            ChaosTab_TxtInterpulseInterval.Enabled = false;
            ChaosTab_btnLoadPulses.Enabled = false;
        }
        private void EnableConfig()
        {
            ChaosTab_CbCurrent.Enabled = true;
            ChaosTab_TxtPulseLength.Enabled = true;
            ChaosTab_TxtInterpulseInterval.Enabled = true;
            ChaosTab_btnLoadPulses.Enabled = true;
        }

        private async void ChaosTab_btnStartStimulus_Click(object sender, EventArgs e)
        {
            if (parsedChaosData == null) return;

            chaosInterval = double.Parse(ChaosTab_TxtInterpulseInterval.Text, CultureInfo.CurrentCulture);

            DisableConfig();

            ResetControllers();

            int totalData = parsedChaosData!.Length;
            for (int i = 0; i < totalData; i++)
            {
                NeedWaiting = i < totalData - 1;
                await Task.Run(async () => await SendDataAndRun(parsedChaosData![i]));
            }
        }

        private async Task SendDataAndRun(Pulse[] pulseTrain)
        {
            await Task.Run(() => { Parallel.Invoke(() => RunningChaos(pulseTrain)); });
        }

        private void RunningChaos(Pulse[] pulseTrain)
        {
            try
            {
                int totalPulses = pulseTrain.Length;
                int maxNumOfPulsesThatArduinoAchieve = 40;

                this.BeginInvoke(() => { ChaosTab_Status.Text = "Estimulando"; });
                PulseTrainRunning = true;

                SendData($"{DeviceControl.PREFIX}{DeviceControl.RESET_BOARD}{DeviceControl.SUFIX}");
                Thread.Sleep(DeviceControl.Delay);

                SendData($"{DeviceControl.PREFIX}{DeviceControl.READ_START}{DeviceControl.SUFIX}");
                Thread.Sleep(DeviceControl.Delay);
                int i = 0;
                for (; i < maxNumOfPulsesThatArduinoAchieve; i++)
                {
                    string txt = pulseTrain[i].ToString().Replace(",", ".");
                    SendData($"{DeviceControl.PREFIX}{txt}{DeviceControl.SUFIX}");
                    Thread.Sleep(DeviceControl.Delay);
                }

                SendData($"{DeviceControl.PREFIX}{DeviceControl.READ_STOP}{DeviceControl.SUFIX}");
                Thread.Sleep(DeviceControl.Delay);

                SendData($"{DeviceControl.PREFIX}{DeviceControl.ROUTINE_START}{DeviceControl.SUFIX}");
                Thread.Sleep(DeviceControl.Delay);

                while (!HasParsed) { }

                for (; i < totalPulses;)
                {
                    if (CanSend)
                    {
                        string txt = pulseTrain[i].ToString().Replace(",", ".");
                        SendData($"{DeviceControl.PREFIX}{txt}{DeviceControl.SUFIX}");
                        Thread.Sleep(DeviceControl.Delay);
                        i++;
                        CanSend = false;
                    }
                }

                while (PulseTrainRunning) { }

                if (NeedWaiting) Thread.Sleep((int)chaosInterval);

            }
            catch (Exception ex) { Error("Error when try to send configs to the board", ex); }
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
                serialControl!.SetDataReceivedEventHandler(new SerialDataReceivedEventHandler(DataReceivedHandler));
                serialControl!.InitializeSerialPort();
                serialControl.SendData($"{DeviceControl.PREFIX}{DeviceControl.RESET_BOARD}{DeviceControl.SUFIX}");
            }
            catch (Exception ex) { Error("Problema ao tentar conectar na placa", ex); }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                CloseSerialPort();
                SetConnectOrDisconnectState(true);

                if (PeriodicTab_StartStimulation.Text == "Parar Estimulação")
                {
                    SendData($"{DeviceControl.PREFIX}{DeviceControl.ROUTINE_STOP}{DeviceControl.SUFIX}");
                    Thread.Sleep(DeviceControl.Delay);
                    PeriodicTab_StartStimulation.Text = "Começar Estimulação";
                }

                txtReceivedData.Text = string.Empty;
                PeriodicTab_StartStimulation.Enabled = false;
                Refresh();
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
            ChaosTab_btnStartStimulus.Enabled = !value;

            cbComPortsList.Enabled = value;
            btnUpdate.Enabled = value;
            switchDefaultParameters.Enabled = value;
        }

        #endregion

        #region txtReceiveData

        private void BtnCleanTxtReceive_Click(object sender, EventArgs e)
        {
            txtReceivedData.Text = string.Empty;
        }

        private void TxtReceivedData_TextChanged(object sender, EventArgs e)
        {
            txtReceivedData.SelectionStart = txtReceivedData.TextLength;
            txtReceivedData.ScrollToCaret();
        }

        public void ResetControllers()
        {
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

            if (newText.Contains("Ready")) this.BeginInvoke(() => { if (serialControl!.IsConnected) SetButtonsState(false); });
            if (newText.Contains("Saved")) this.BeginInvoke(() => { PeriodicTab_StartStimulation.Enabled = true; });
            if (newText.Contains("Parsed")) HasParsed = true;
            if (newText.Contains("Executed") && HasParsed) CanSend = true;
            if (newText.Contains("FimDoTremDePulsos"))
            {
                PulseTrainRunning = false;
                if (NeedWaiting) this.BeginInvoke(() => { ChaosTab_Status.Text = "Aguardando"; });
                else this.BeginInvoke(() => { ChaosTab_Status.Text = "Concluído"; });
            }

            this.BeginInvoke(() => { if (serialControl!.IsConnected) txtReceivedData.Text += newText; });
        }

        public void ResetDataCommunication()
        {
            SendData($"{DeviceControl.PREFIX}{DeviceControl.ROUTINE_STOP}{DeviceControl.SUFIX}");
            Thread.Sleep(DeviceControl.Delay);

            SendData($"{DeviceControl.PREFIX}{DeviceControl.RESET_BOARD}{DeviceControl.SUFIX}");
            Thread.Sleep(DeviceControl.Delay);

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
            ResetControllers();
            try
            {
                SendData($"{DeviceControl.PREFIX}{DeviceControl.ROUTINE_STOP}{DeviceControl.SUFIX}");
                Thread.Sleep(DeviceControl.Delay);

                SendData($"{DeviceControl.PREFIX}{DeviceControl.RESET_BOARD}{DeviceControl.SUFIX}");
                Thread.Sleep(DeviceControl.Delay);

                SendData($"{DeviceControl.PREFIX}{DeviceControl.READ_START}{DeviceControl.SUFIX}");
                Thread.Sleep(DeviceControl.Delay);

                SendData($"{DeviceControl.PREFIX}{DeviceControl.MODE_PERIODIC}{DeviceControl.SUFIX}");
                Thread.Sleep(DeviceControl.Delay);

                foreach (DataGridViewRow row in PeriodicTab_GridMain.Rows)
                {
                    if (row.DataBoundItem is Pulse pulse)
                    {
                        var txt = pulse.ToString().Replace(",", ".");
                        SendData($"{DeviceControl.PREFIX}{txt}{DeviceControl.SUFIX}");
                        Thread.Sleep(DeviceControl.Delay);
                    }
                }

                SendData($"{DeviceControl.PREFIX}{DeviceControl.READ_STOP}{DeviceControl.SUFIX}");
                Thread.Sleep(DeviceControl.Delay);
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
                string message = $"Você realmente deseja fechar esta janela? {DeviceControl.JUMPLINE}{DeviceControl.JUMPLINE} Isso irá cortar a comunicação com o estimulador.";
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
                try { serialControl!.Dispose($"{DeviceControl.PREFIX}{DeviceControl.RESET_BOARD}{DeviceControl.SUFIX}"); } catch { /* Ignorado */ }
            }
        }

        #endregion

        #region Error

        private static void Error(string errorMessage, Exception e)
        {
            MessageBox.Show($"{errorMessage} {DeviceControl.JUMPLINE}{DeviceControl.JUMPLINE}Exception message:{DeviceControl.JUMPLINE} {e.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
        }

        #endregion

    }
}
