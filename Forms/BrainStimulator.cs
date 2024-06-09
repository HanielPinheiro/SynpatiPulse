using BrainStimulator.Models;
using BrainStimulator.Utils;
using MaterialSkin;
using MaterialSkin.Controls;
using OxyPlot;
using OxyPlot.Series;
using SerialPortController;
using System.ComponentModel;
using System.Data;

namespace BrainStimulator
{
    public partial class BrainStimulator : MaterialForm
    {
        private readonly BindingList<Pulse> pulses = new();
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        private Interface? boardConnection;
        private DataGridViewCellStyle? DefaultCellStyle;

        private const string JUMPLINE = "\r\n";
        public const string RESET_BOARD = "D>";
        private const string RESET_PREVIOUS_SETUP = "R>";
        private const string START_ROUTINE = "J>";
        private const string STOP_ROUTINE = "K>";
        private const string START_READ = "L>";
        public const string STOP_READ = "M>";

        public const string startStimulus = "INICIAR ESTIMULAÇÃO";
        public const string stopStimulus = "PARAR ESTIMULAÇÃO";

        public BrainStimulator()
        {
            InitializeComponent();
            SetFormTheme();
            cbCurrents.DataSource = Pulse.pulseCurrentToCombobox.Select(p => p.Value).ToList();
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
            PeriodicTab_SetChart();
            PeriodicTab_GridMain.DefaultConfiguration(pulses, () => PeriodicTab_GridMain.SetPersistString(this.GetType().FullName + Pulse.Layout));
            PeriodicTab_GridMain.SetCellStyle(DefaultCellStyle!);
            PeriodicTab_GridMain.SetHeaderText(Pulse.displayNameFromProperties);
            PeriodicTab_GridMain.SetWidth(Pulse.columSizeFromProperties);
        }

        #endregion

        #region Charts

        private void RefreshChart()
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
            catch (Exception ex) { Error($"Problema ao tentar executar {nameof(RefreshChart)}", ex); }
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

        #endregion

        #region Periodic Tab

        #region Header Panel

        private void PeriodicTab_AddPulse_Click(object sender, EventArgs e)
        {
            try
            {
                if (pulses.Count < 10)
                {
                    Pulse p = new();
                    p.Current = cbCurrents.SelectedValue as string ?? throw new InvalidOperationException("Erro no seletor de corrente");
                    pulses.Add(p);
                    RefreshChart();
                }
                if (boardConnection != null && pulses.Count > 0 && boardConnection!.IsConnected && !boardConnection!.StimulationHasStarted)
                    PeriodicTab_SendConfigToBoard.Enabled = true;
            }
            catch (InvalidOperationException ex) { Error("Problema ao adicionar pulso", ex); }
        }

        private void PeriodicTab_RemovePulse_Click(object sender, EventArgs e)
        {
            HashSet<Pulse> pulsesToRemove = new();

            foreach (DataGridViewCell cell in PeriodicTab_GridMain.SelectedCells)
                if (PeriodicTab_GridMain.Rows[cell.RowIndex].DataBoundItem is Pulse pulse) pulsesToRemove.Add(pulse);

            foreach (Pulse pulse in pulsesToRemove) pulses.Remove(pulse);

            if (pulses.Count <= 0 && boardConnection != null && boardConnection.IsConnected) PeriodicTab_SendConfigToBoard.Enabled = false;

            RefreshChart();
        }

        private void PeriodicTab_ConnectBoard_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<Interface>().Any())
            {
                boardConnection = new Interface(PeriodicTab_ConnectBoard, PeriodicTab_SendConfigToBoard, PeriodicTab_StartRoutine);
                boardConnection.Show();
                PeriodicTab_ConnectBoard.Enabled = false;
            }
            else boardConnection!.Focus();
        }

        #endregion

        private void PeriodicTab_SetChart()
        {
            PeriodicTab_ChartPlotView.Model = GetModel();
        }

        private void PeriodicTab_GridMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Ignore
        }

        private void PeriodicTab_GridMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            RefreshChart();
        }

        private void PeriodicTab_GridMain_ColumnDataPropertyNameChanged(object sender, DataGridViewColumnEventArgs e)
        {
            switch (e.Column.DataPropertyName)
            {
                case nameof(Pulse.AfterPulseMeasureUnity):
                case nameof(Pulse.PulseMeasureUnity):
                    (sender as DataGridView)!.ConvertColumnToComboBox(e, DataToCombobox.GetListFrom(Pulse.measureUnityToCombobox.Select(p => p.Value).ToList()), "Name", "Name");
                    break;

                case nameof(Pulse.Current):
                    (sender as DataGridView)!.ConvertColumnToComboBox(e, DataToCombobox.GetListFrom(Pulse.pulseCurrentToCombobox.Select(p => p.Value).ToList()), "Name", "Name");
                    break;

                case nameof(Pulse.Polarity):
                    (sender as DataGridView)!.ConvertColumnToComboBox(e, DataToCombobox.GetListFrom(Pulse.pulsePolarityToCombobox.Select(p => p.Value).ToList()), "Name", "Name");
                    break;

                default:
                    (sender as DataGridView)!.ConvertColumnDefault(e);
                    break;
            }
        }

        #endregion

        static private void Error(string errorMessage, Exception e)
        {
            MessageBox.Show($"{errorMessage} {JUMPLINE}{JUMPLINE}Exception message:{JUMPLINE} {e.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
        }

        private void PeriodicTab_SendConfigToBoard_Click(object sender, EventArgs e)
        {
            boardConnection!.ResetControllers(PeriodicTab_GridMain.Rows.Count);

            try
            {
                boardConnection!.SendData(STOP_ROUTINE);
                Thread.Sleep(DeviceControl.delay);

                boardConnection!.SendData(STOP_READ);
                Thread.Sleep(DeviceControl.delay);

                boardConnection!.SendData(RESET_PREVIOUS_SETUP);
                Thread.Sleep(DeviceControl.delay);

                boardConnection!.SendData(START_READ);
                Thread.Sleep(2000);

                foreach (DataGridViewRow row in PeriodicTab_GridMain.Rows)
                {
                    if (row.DataBoundItem is Pulse pulse)
                    {
                        var txt = pulse.ToString().Replace(",", ".");
                        boardConnection!.SendData(txt);
                        Thread.Sleep(2000);
                    }
                }

                boardConnection!.SendData(STOP_READ);
                Thread.Sleep(2000);

                boardConnection!.BoardHasData = true;
                PeriodicTab_StartRoutine.Enabled = true;
            }
            catch (Exception ex) { Error("Error when try to send configs to the board", ex); }
        }

        private void CbCurrents_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PeriodicTab_GridMain.Rows)
            {
                if (row.DataBoundItem is Pulse pulse)
                {
                    if (cbCurrents.SelectedValue is string item) pulse.Current = item;
                }
            }
        }

        private void PeriodicTab_StartRoutine_Click(object sender, EventArgs e)
        {
            if (boardConnection!.BoardHasData)
            {
                if (!boardConnection!.StimulationHasStarted)
                {
                    boardConnection!.SendData(START_ROUTINE);
                    Thread.Sleep(DeviceControl.delay);

                    boardConnection!.StimulationHasStarted = true;
                    PeriodicTab_SendConfigToBoard.Enabled = false;
                    PeriodicTab_StartRoutine.Text = stopStimulus;
                }
                else
                {
                    boardConnection!.SendData(STOP_ROUTINE);
                    Thread.Sleep(DeviceControl.delay);

                    boardConnection!.StimulationHasStarted = false;
                    PeriodicTab_SendConfigToBoard.Enabled = true;
                    PeriodicTab_StartRoutine.Text = startStimulus;
                }
            }
        }       

        private void PeriodicTab_StartRoutine_EnabledChanged(object sender, EventArgs e)
        {
            if (PeriodicTab_StartRoutine.Enabled)
            {
                if (boardConnection!.BoardHasData) PeriodicTab_StartRoutine.Enabled = true;
                else PeriodicTab_StartRoutine.Enabled = false;
            }
        }

        private void PeriodicTab_SendConfigToBoard_EnabledChanged(object sender, EventArgs e)
        {
            if (PeriodicTab_SendConfigToBoard.Enabled)
            {
                if (pulses.Count <= 0) PeriodicTab_SendConfigToBoard.Enabled = false;
                else PeriodicTab_SendConfigToBoard.Enabled = true;
            }
        }
    }
}
