namespace SynaptiPulse
{
    partial class SynaptiPulse
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SynaptiPulse));
            tableLayoutPanel1 = new TableLayoutPanel();
            splitContainer = new SplitContainer();
            TabControl = new TabControl();
            tabPeriodic = new TabPage();
            tbPanel_PeriodicTab = new TableLayoutPanel();
            PeriodicTab_GridMain = new DataGridView();
            PeriodicTab_ChartPlotView = new OxyPlot.WindowsForms.PlotView();
            tableLayoutPanel7 = new TableLayoutPanel();
            PeriodicTab_HeaderPanel = new TableLayoutPanel();
            PeriodicTab_SendConfigToBoard = new MaterialSkin.Controls.MaterialButton();
            PeriodicTab_StartStimulation = new MaterialSkin.Controls.MaterialButton();
            PeriodicTab_LoadRoutine = new MaterialSkin.Controls.MaterialButton();
            PeriodicTab_SaveRoutine = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel16 = new TableLayoutPanel();
            PeriodicTab_RemovePulse = new MaterialSkin.Controls.MaterialButton();
            PeriodicTab_AddPulse = new MaterialSkin.Controls.MaterialButton();
            PeriodicTab_CbCurrents = new MaterialSkin.Controls.MaterialComboBox();
            PeriodicTab_SwitchCurrent = new MaterialSkin.Controls.MaterialSwitch();
            tabChaos = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            ChaosTab_ChartPlotView_Train = new OxyPlot.WindowsForms.PlotView();
            tableLayoutPanel6 = new TableLayoutPanel();
            ChaosTab_LblInterval = new MaterialSkin.Controls.MaterialLabel();
            ChaosTab_CbPulseTrains = new MaterialSkin.Controls.MaterialComboBox();
            groupBox4 = new GroupBox();
            TbPanel_Chaos = new TableLayoutPanel();
            tableLayoutPanel18 = new TableLayoutPanel();
            ChaosTab_LabelStatus = new MaterialSkin.Controls.MaterialLabel();
            ChaosTab_Status = new MaterialSkin.Controls.MaterialLabel();
            ChaosTab_btnStartStimulus = new MaterialSkin.Controls.MaterialButton();
            ChaosTab_btnLoadPulses = new MaterialSkin.Controls.MaterialButton();
            ChaosTab_LblInterpulseInterval = new MaterialSkin.Controls.MaterialLabel();
            ChaosTab_CbCurrent = new MaterialSkin.Controls.MaterialComboBox();
            ChaosTab_LblCurrent = new MaterialSkin.Controls.MaterialLabel();
            ChaosTab_LblPulseLarge = new MaterialSkin.Controls.MaterialLabel();
            ChaosTab_TxtPulseLength = new MaterialSkin.Controls.MaterialTextBox();
            ChaosTab_TxtInterpulseInterval = new MaterialSkin.Controls.MaterialTextBox();
            tableLayoutPanel14 = new TableLayoutPanel();
            tableLayoutPanel13 = new TableLayoutPanel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel12 = new TableLayoutPanel();
            btnDisconnect = new MaterialSkin.Controls.MaterialButton();
            btnConnect = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel11 = new TableLayoutPanel();
            cbComPortsList = new MaterialSkin.Controls.MaterialComboBox();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            switchDefaultParameters = new MaterialSkin.Controls.MaterialSwitch();
            groupBox1 = new GroupBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            txtWriteTimeOut = new MaterialSkin.Controls.MaterialTextBox();
            txtReadTimeOut = new MaterialSkin.Controls.MaterialTextBox();
            txtDataBits = new MaterialSkin.Controls.MaterialTextBox();
            txtBaudRate = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel10 = new TableLayoutPanel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            cbParity = new MaterialSkin.Controls.MaterialComboBox();
            cbHandShake = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            cbStopBits = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            groupBox2 = new GroupBox();
            tableLayoutPanel15 = new TableLayoutPanel();
            btnCleanTxtReceive = new MaterialSkin.Controls.MaterialButton();
            txtReceivedData = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            TabControl.SuspendLayout();
            tabPeriodic.SuspendLayout();
            tbPanel_PeriodicTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PeriodicTab_GridMain).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            PeriodicTab_HeaderPanel.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            tabChaos.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox4.SuspendLayout();
            TbPanel_Chaos.SuspendLayout();
            tableLayoutPanel18.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 213F));
            tableLayoutPanel1.Controls.Add(splitContainer, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 64);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.8770046F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 71.12299F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1394, 533);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Margin = new Padding(0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(TabControl);
            splitContainer.Panel1MinSize = 800;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tableLayoutPanel14);
            splitContainer.Size = new Size(1394, 533);
            splitContainer.SplitterDistance = 800;
            splitContainer.TabIndex = 0;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPeriodic);
            TabControl.Controls.Add(tabChaos);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(800, 533);
            TabControl.TabIndex = 0;
            // 
            // tabPeriodic
            // 
            tabPeriodic.Controls.Add(tbPanel_PeriodicTab);
            tabPeriodic.Location = new Point(4, 24);
            tabPeriodic.Name = "tabPeriodic";
            tabPeriodic.Padding = new Padding(3);
            tabPeriodic.Size = new Size(792, 505);
            tabPeriodic.TabIndex = 0;
            tabPeriodic.Text = "Pulsos Periódicos";
            tabPeriodic.UseVisualStyleBackColor = true;
            // 
            // tbPanel_PeriodicTab
            // 
            tbPanel_PeriodicTab.ColumnCount = 1;
            tbPanel_PeriodicTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbPanel_PeriodicTab.Controls.Add(PeriodicTab_GridMain, 0, 1);
            tbPanel_PeriodicTab.Controls.Add(PeriodicTab_ChartPlotView, 0, 2);
            tbPanel_PeriodicTab.Controls.Add(tableLayoutPanel7, 0, 0);
            tbPanel_PeriodicTab.Dock = DockStyle.Fill;
            tbPanel_PeriodicTab.Location = new Point(3, 3);
            tbPanel_PeriodicTab.Margin = new Padding(0);
            tbPanel_PeriodicTab.Name = "tbPanel_PeriodicTab";
            tbPanel_PeriodicTab.RowCount = 3;
            tbPanel_PeriodicTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tbPanel_PeriodicTab.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbPanel_PeriodicTab.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbPanel_PeriodicTab.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbPanel_PeriodicTab.Size = new Size(786, 499);
            tbPanel_PeriodicTab.TabIndex = 2;
            // 
            // PeriodicTab_GridMain
            // 
            PeriodicTab_GridMain.AllowUserToAddRows = false;
            PeriodicTab_GridMain.AllowUserToDeleteRows = false;
            PeriodicTab_GridMain.AllowUserToOrderColumns = true;
            PeriodicTab_GridMain.AllowUserToResizeRows = false;
            PeriodicTab_GridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PeriodicTab_GridMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PeriodicTab_GridMain.Dock = DockStyle.Fill;
            PeriodicTab_GridMain.Location = new Point(0, 120);
            PeriodicTab_GridMain.Margin = new Padding(0);
            PeriodicTab_GridMain.Name = "PeriodicTab_GridMain";
            PeriodicTab_GridMain.RowTemplate.Height = 25;
            PeriodicTab_GridMain.Size = new Size(786, 189);
            PeriodicTab_GridMain.TabIndex = 4;
            PeriodicTab_GridMain.CellEndEdit += PeriodicTab_GridMain_CellEndEdit;
            PeriodicTab_GridMain.ColumnDataPropertyNameChanged += PeriodicTab_GridMain_ColumnDataPropertyNameChanged;
            PeriodicTab_GridMain.DataError += PeriodicTab_GridMain_DataError;
            PeriodicTab_GridMain.RowsAdded += PeriodicTab_GridMain_RowsAdded;
            PeriodicTab_GridMain.RowsRemoved += PeriodicTab_GridMain_RowsRemoved;
            // 
            // PeriodicTab_ChartPlotView
            // 
            PeriodicTab_ChartPlotView.Dock = DockStyle.Fill;
            PeriodicTab_ChartPlotView.Location = new Point(3, 312);
            PeriodicTab_ChartPlotView.Name = "PeriodicTab_ChartPlotView";
            PeriodicTab_ChartPlotView.PanCursor = Cursors.Hand;
            PeriodicTab_ChartPlotView.Size = new Size(780, 184);
            PeriodicTab_ChartPlotView.TabIndex = 2;
            PeriodicTab_ChartPlotView.Text = "plotView1";
            PeriodicTab_ChartPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
            PeriodicTab_ChartPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            PeriodicTab_ChartPlotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(PeriodicTab_HeaderPanel, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel16, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel7.Size = new Size(786, 120);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // PeriodicTab_HeaderPanel
            // 
            PeriodicTab_HeaderPanel.ColumnCount = 5;
            PeriodicTab_HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            PeriodicTab_HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            PeriodicTab_HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            PeriodicTab_HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            PeriodicTab_HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            PeriodicTab_HeaderPanel.Controls.Add(PeriodicTab_SendConfigToBoard, 3, 0);
            PeriodicTab_HeaderPanel.Controls.Add(PeriodicTab_StartStimulation, 4, 0);
            PeriodicTab_HeaderPanel.Controls.Add(PeriodicTab_LoadRoutine, 1, 0);
            PeriodicTab_HeaderPanel.Controls.Add(PeriodicTab_SaveRoutine, 0, 0);
            PeriodicTab_HeaderPanel.Dock = DockStyle.Fill;
            PeriodicTab_HeaderPanel.Location = new Point(0, 0);
            PeriodicTab_HeaderPanel.Margin = new Padding(0);
            PeriodicTab_HeaderPanel.Name = "PeriodicTab_HeaderPanel";
            PeriodicTab_HeaderPanel.RowCount = 1;
            PeriodicTab_HeaderPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PeriodicTab_HeaderPanel.Size = new Size(786, 50);
            PeriodicTab_HeaderPanel.TabIndex = 5;
            PeriodicTab_HeaderPanel.TabStop = true;
            // 
            // PeriodicTab_SendConfigToBoard
            // 
            PeriodicTab_SendConfigToBoard.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PeriodicTab_SendConfigToBoard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PeriodicTab_SendConfigToBoard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            PeriodicTab_SendConfigToBoard.Depth = 0;
            PeriodicTab_SendConfigToBoard.Enabled = false;
            PeriodicTab_SendConfigToBoard.HighEmphasis = true;
            PeriodicTab_SendConfigToBoard.Icon = null;
            PeriodicTab_SendConfigToBoard.Location = new Point(410, 7);
            PeriodicTab_SendConfigToBoard.Margin = new Padding(4, 6, 4, 6);
            PeriodicTab_SendConfigToBoard.MouseState = MaterialSkin.MouseState.HOVER;
            PeriodicTab_SendConfigToBoard.Name = "PeriodicTab_SendConfigToBoard";
            PeriodicTab_SendConfigToBoard.NoAccentTextColor = Color.Empty;
            PeriodicTab_SendConfigToBoard.Size = new Size(180, 36);
            PeriodicTab_SendConfigToBoard.TabIndex = 8;
            PeriodicTab_SendConfigToBoard.Text = "Enviar Config à placa";
            PeriodicTab_SendConfigToBoard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            PeriodicTab_SendConfigToBoard.UseAccentColor = false;
            PeriodicTab_SendConfigToBoard.UseVisualStyleBackColor = true;
            PeriodicTab_SendConfigToBoard.Click += PeriodicTab_SendConfigToBoard_Click;
            // 
            // PeriodicTab_StartStimulation
            // 
            PeriodicTab_StartStimulation.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PeriodicTab_StartStimulation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PeriodicTab_StartStimulation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            PeriodicTab_StartStimulation.Depth = 0;
            PeriodicTab_StartStimulation.Enabled = false;
            PeriodicTab_StartStimulation.HighEmphasis = true;
            PeriodicTab_StartStimulation.Icon = null;
            PeriodicTab_StartStimulation.Location = new Point(598, 7);
            PeriodicTab_StartStimulation.Margin = new Padding(4, 6, 4, 6);
            PeriodicTab_StartStimulation.MouseState = MaterialSkin.MouseState.HOVER;
            PeriodicTab_StartStimulation.Name = "PeriodicTab_StartStimulation";
            PeriodicTab_StartStimulation.NoAccentTextColor = Color.Empty;
            PeriodicTab_StartStimulation.Size = new Size(184, 36);
            PeriodicTab_StartStimulation.TabIndex = 31;
            PeriodicTab_StartStimulation.Text = "Começar Estimulação";
            PeriodicTab_StartStimulation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            PeriodicTab_StartStimulation.UseAccentColor = false;
            PeriodicTab_StartStimulation.UseVisualStyleBackColor = true;
            PeriodicTab_StartStimulation.Click += PeriodicTab_StartStimulation_Click;
            // 
            // PeriodicTab_LoadRoutine
            // 
            PeriodicTab_LoadRoutine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PeriodicTab_LoadRoutine.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PeriodicTab_LoadRoutine.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            PeriodicTab_LoadRoutine.Depth = 0;
            PeriodicTab_LoadRoutine.HighEmphasis = true;
            PeriodicTab_LoadRoutine.Icon = null;
            PeriodicTab_LoadRoutine.Location = new Point(176, 7);
            PeriodicTab_LoadRoutine.Margin = new Padding(4, 6, 4, 6);
            PeriodicTab_LoadRoutine.MouseState = MaterialSkin.MouseState.HOVER;
            PeriodicTab_LoadRoutine.Name = "PeriodicTab_LoadRoutine";
            PeriodicTab_LoadRoutine.NoAccentTextColor = Color.Empty;
            PeriodicTab_LoadRoutine.Size = new Size(164, 36);
            PeriodicTab_LoadRoutine.TabIndex = 33;
            PeriodicTab_LoadRoutine.Text = "Carregar rotina";
            PeriodicTab_LoadRoutine.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            PeriodicTab_LoadRoutine.UseAccentColor = false;
            PeriodicTab_LoadRoutine.UseVisualStyleBackColor = true;
            PeriodicTab_LoadRoutine.Click += PeriodicTab_LoadRoutine_Click;
            // 
            // PeriodicTab_SaveRoutine
            // 
            PeriodicTab_SaveRoutine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PeriodicTab_SaveRoutine.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PeriodicTab_SaveRoutine.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            PeriodicTab_SaveRoutine.Depth = 0;
            PeriodicTab_SaveRoutine.Enabled = false;
            PeriodicTab_SaveRoutine.HighEmphasis = true;
            PeriodicTab_SaveRoutine.Icon = null;
            PeriodicTab_SaveRoutine.Location = new Point(4, 7);
            PeriodicTab_SaveRoutine.Margin = new Padding(4, 6, 4, 6);
            PeriodicTab_SaveRoutine.MouseState = MaterialSkin.MouseState.HOVER;
            PeriodicTab_SaveRoutine.Name = "PeriodicTab_SaveRoutine";
            PeriodicTab_SaveRoutine.NoAccentTextColor = Color.Empty;
            PeriodicTab_SaveRoutine.Size = new Size(164, 36);
            PeriodicTab_SaveRoutine.TabIndex = 32;
            PeriodicTab_SaveRoutine.Text = "Salvar Rotina";
            PeriodicTab_SaveRoutine.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            PeriodicTab_SaveRoutine.UseAccentColor = false;
            PeriodicTab_SaveRoutine.UseVisualStyleBackColor = true;
            PeriodicTab_SaveRoutine.Click += PeriodicTab_SaveRoutine_Click;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 5;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            tableLayoutPanel16.Controls.Add(PeriodicTab_RemovePulse, 1, 0);
            tableLayoutPanel16.Controls.Add(PeriodicTab_AddPulse, 0, 0);
            tableLayoutPanel16.Controls.Add(PeriodicTab_CbCurrents, 4, 0);
            tableLayoutPanel16.Controls.Add(PeriodicTab_SwitchCurrent, 3, 0);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(3, 53);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 1;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.Size = new Size(780, 64);
            tableLayoutPanel16.TabIndex = 7;
            // 
            // PeriodicTab_RemovePulse
            // 
            PeriodicTab_RemovePulse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PeriodicTab_RemovePulse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PeriodicTab_RemovePulse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            PeriodicTab_RemovePulse.Depth = 0;
            PeriodicTab_RemovePulse.Enabled = false;
            PeriodicTab_RemovePulse.HighEmphasis = true;
            PeriodicTab_RemovePulse.Icon = null;
            PeriodicTab_RemovePulse.Location = new Point(175, 14);
            PeriodicTab_RemovePulse.Margin = new Padding(4, 6, 4, 6);
            PeriodicTab_RemovePulse.MouseState = MaterialSkin.MouseState.HOVER;
            PeriodicTab_RemovePulse.Name = "PeriodicTab_RemovePulse";
            PeriodicTab_RemovePulse.NoAccentTextColor = Color.Empty;
            PeriodicTab_RemovePulse.Size = new Size(163, 36);
            PeriodicTab_RemovePulse.TabIndex = 5;
            PeriodicTab_RemovePulse.Text = "Remover pulsos";
            PeriodicTab_RemovePulse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            PeriodicTab_RemovePulse.UseAccentColor = false;
            PeriodicTab_RemovePulse.UseVisualStyleBackColor = true;
            PeriodicTab_RemovePulse.Click += PeriodicTab_RemovePulse_Click;
            // 
            // PeriodicTab_AddPulse
            // 
            PeriodicTab_AddPulse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PeriodicTab_AddPulse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PeriodicTab_AddPulse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            PeriodicTab_AddPulse.Depth = 0;
            PeriodicTab_AddPulse.HighEmphasis = true;
            PeriodicTab_AddPulse.Icon = null;
            PeriodicTab_AddPulse.Location = new Point(4, 14);
            PeriodicTab_AddPulse.Margin = new Padding(4, 6, 4, 6);
            PeriodicTab_AddPulse.MouseState = MaterialSkin.MouseState.HOVER;
            PeriodicTab_AddPulse.Name = "PeriodicTab_AddPulse";
            PeriodicTab_AddPulse.NoAccentTextColor = Color.Empty;
            PeriodicTab_AddPulse.Size = new Size(163, 36);
            PeriodicTab_AddPulse.TabIndex = 0;
            PeriodicTab_AddPulse.Text = "adicionar pulsos";
            PeriodicTab_AddPulse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            PeriodicTab_AddPulse.UseAccentColor = false;
            PeriodicTab_AddPulse.UseVisualStyleBackColor = true;
            PeriodicTab_AddPulse.Click += PeriodicTab_AddPulse_Click;
            // 
            // PeriodicTab_CbCurrents
            // 
            PeriodicTab_CbCurrents.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PeriodicTab_CbCurrents.AutoResize = false;
            PeriodicTab_CbCurrents.BackColor = SystemColors.Control;
            PeriodicTab_CbCurrents.Depth = 0;
            PeriodicTab_CbCurrents.DrawMode = DrawMode.OwnerDrawVariable;
            PeriodicTab_CbCurrents.DropDownHeight = 118;
            PeriodicTab_CbCurrents.DropDownStyle = ComboBoxStyle.DropDownList;
            PeriodicTab_CbCurrents.DropDownWidth = 121;
            PeriodicTab_CbCurrents.Enabled = false;
            PeriodicTab_CbCurrents.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            PeriodicTab_CbCurrents.ForeColor = SystemColors.ControlText;
            PeriodicTab_CbCurrents.FormattingEnabled = true;
            PeriodicTab_CbCurrents.IntegralHeight = false;
            PeriodicTab_CbCurrents.ItemHeight = 29;
            PeriodicTab_CbCurrents.Location = new Point(594, 14);
            PeriodicTab_CbCurrents.MaxDropDownItems = 4;
            PeriodicTab_CbCurrents.MouseState = MaterialSkin.MouseState.OUT;
            PeriodicTab_CbCurrents.Name = "PeriodicTab_CbCurrents";
            PeriodicTab_CbCurrents.Size = new Size(183, 35);
            PeriodicTab_CbCurrents.StartIndex = 0;
            PeriodicTab_CbCurrents.TabIndex = 22;
            PeriodicTab_CbCurrents.UseTallSize = false;
            PeriodicTab_CbCurrents.SelectedIndexChanged += PeriodicTab_CbCurrents_SelectedIndexChanged;
            // 
            // PeriodicTab_SwitchCurrent
            // 
            PeriodicTab_SwitchCurrent.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PeriodicTab_SwitchCurrent.AutoSize = true;
            PeriodicTab_SwitchCurrent.BackColor = SystemColors.Control;
            PeriodicTab_SwitchCurrent.Checked = true;
            PeriodicTab_SwitchCurrent.CheckState = CheckState.Checked;
            PeriodicTab_SwitchCurrent.Depth = 0;
            PeriodicTab_SwitchCurrent.Enabled = false;
            PeriodicTab_SwitchCurrent.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PeriodicTab_SwitchCurrent.ForeColor = SystemColors.ControlText;
            PeriodicTab_SwitchCurrent.Location = new Point(404, 13);
            PeriodicTab_SwitchCurrent.Margin = new Padding(0);
            PeriodicTab_SwitchCurrent.MouseLocation = new Point(-1, -1);
            PeriodicTab_SwitchCurrent.MouseState = MaterialSkin.MouseState.HOVER;
            PeriodicTab_SwitchCurrent.Name = "PeriodicTab_SwitchCurrent";
            PeriodicTab_SwitchCurrent.Ripple = true;
            PeriodicTab_SwitchCurrent.Size = new Size(187, 37);
            PeriodicTab_SwitchCurrent.TabIndex = 21;
            PeriodicTab_SwitchCurrent.Text = "Fixar corrente";
            PeriodicTab_SwitchCurrent.TextAlign = ContentAlignment.MiddleCenter;
            PeriodicTab_SwitchCurrent.UseVisualStyleBackColor = false;
            PeriodicTab_SwitchCurrent.CheckedChanged += PeriodicTab_SwitchGlobalCurrent_CheckedChanged;
            // 
            // tabChaos
            // 
            tabChaos.Controls.Add(tableLayoutPanel2);
            tabChaos.Location = new Point(4, 24);
            tabChaos.Name = "tabChaos";
            tabChaos.Padding = new Padding(3);
            tabChaos.Size = new Size(792, 505);
            tabChaos.TabIndex = 1;
            tabChaos.Text = "Trem de Pulso";
            tabChaos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.53403F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.4659653F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40.28056F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 59.71944F));
            tableLayoutPanel2.Size = new Size(786, 499);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel3.Controls.Add(groupBox4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 194F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(786, 499);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel5);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 197);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(780, 299);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informações dos Trens de Pulsos";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(ChaosTab_ChartPlotView_Train, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 197F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(774, 277);
            tableLayoutPanel5.TabIndex = 10;
            // 
            // ChaosTab_ChartPlotView_Train
            // 
            ChaosTab_ChartPlotView_Train.Dock = DockStyle.Fill;
            ChaosTab_ChartPlotView_Train.Location = new Point(3, 58);
            ChaosTab_ChartPlotView_Train.Name = "ChaosTab_ChartPlotView_Train";
            ChaosTab_ChartPlotView_Train.PanCursor = Cursors.Hand;
            ChaosTab_ChartPlotView_Train.Size = new Size(768, 216);
            ChaosTab_ChartPlotView_Train.TabIndex = 28;
            ChaosTab_ChartPlotView_Train.Text = "plotView1";
            ChaosTab_ChartPlotView_Train.ZoomHorizontalCursor = Cursors.SizeWE;
            ChaosTab_ChartPlotView_Train.ZoomRectangleCursor = Cursors.SizeNWSE;
            ChaosTab_ChartPlotView_Train.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.8385429F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.1614571F));
            tableLayoutPanel6.Controls.Add(ChaosTab_LblInterval, 0, 0);
            tableLayoutPanel6.Controls.Add(ChaosTab_CbPulseTrains, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(768, 49);
            tableLayoutPanel6.TabIndex = 29;
            // 
            // ChaosTab_LblInterval
            // 
            ChaosTab_LblInterval.AutoSize = true;
            ChaosTab_LblInterval.BackColor = SystemColors.Control;
            ChaosTab_LblInterval.Depth = 0;
            ChaosTab_LblInterval.Dock = DockStyle.Fill;
            ChaosTab_LblInterval.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ChaosTab_LblInterval.Location = new Point(3, 0);
            ChaosTab_LblInterval.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_LblInterval.Name = "ChaosTab_LblInterval";
            ChaosTab_LblInterval.Size = new Size(323, 49);
            ChaosTab_LblInterval.TabIndex = 27;
            ChaosTab_LblInterval.Text = "Dados do gráfico:";
            ChaosTab_LblInterval.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChaosTab_CbPulseTrains
            // 
            ChaosTab_CbPulseTrains.AutoResize = false;
            ChaosTab_CbPulseTrains.BackColor = SystemColors.Control;
            ChaosTab_CbPulseTrains.Depth = 0;
            ChaosTab_CbPulseTrains.Dock = DockStyle.Fill;
            ChaosTab_CbPulseTrains.DrawMode = DrawMode.OwnerDrawVariable;
            ChaosTab_CbPulseTrains.DropDownHeight = 118;
            ChaosTab_CbPulseTrains.DropDownStyle = ComboBoxStyle.DropDownList;
            ChaosTab_CbPulseTrains.DropDownWidth = 121;
            ChaosTab_CbPulseTrains.Enabled = false;
            ChaosTab_CbPulseTrains.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ChaosTab_CbPulseTrains.ForeColor = SystemColors.ControlText;
            ChaosTab_CbPulseTrains.FormattingEnabled = true;
            ChaosTab_CbPulseTrains.IntegralHeight = false;
            ChaosTab_CbPulseTrains.ItemHeight = 29;
            ChaosTab_CbPulseTrains.Location = new Point(332, 3);
            ChaosTab_CbPulseTrains.MaxDropDownItems = 4;
            ChaosTab_CbPulseTrains.MouseState = MaterialSkin.MouseState.OUT;
            ChaosTab_CbPulseTrains.Name = "ChaosTab_CbPulseTrains";
            ChaosTab_CbPulseTrains.Size = new Size(433, 35);
            ChaosTab_CbPulseTrains.StartIndex = 0;
            ChaosTab_CbPulseTrains.TabIndex = 32;
            ChaosTab_CbPulseTrains.UseTallSize = false;
            ChaosTab_CbPulseTrains.SelectedIndexChanged += ChaosTab_CbPulseTrains_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(TbPanel_Chaos);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(780, 188);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Configuração do Estimulador";
            // 
            // TbPanel_Chaos
            // 
            TbPanel_Chaos.ColumnCount = 3;
            TbPanel_Chaos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.429863F));
            TbPanel_Chaos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.570137F));
            TbPanel_Chaos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 332F));
            TbPanel_Chaos.Controls.Add(tableLayoutPanel18, 2, 2);
            TbPanel_Chaos.Controls.Add(ChaosTab_btnStartStimulus, 2, 1);
            TbPanel_Chaos.Controls.Add(ChaosTab_btnLoadPulses, 2, 0);
            TbPanel_Chaos.Controls.Add(ChaosTab_LblInterpulseInterval, 0, 2);
            TbPanel_Chaos.Controls.Add(ChaosTab_CbCurrent, 1, 0);
            TbPanel_Chaos.Controls.Add(ChaosTab_LblCurrent, 0, 0);
            TbPanel_Chaos.Controls.Add(ChaosTab_LblPulseLarge, 0, 1);
            TbPanel_Chaos.Controls.Add(ChaosTab_TxtPulseLength, 1, 1);
            TbPanel_Chaos.Controls.Add(ChaosTab_TxtInterpulseInterval, 1, 2);
            TbPanel_Chaos.Dock = DockStyle.Fill;
            TbPanel_Chaos.Location = new Point(3, 19);
            TbPanel_Chaos.Margin = new Padding(0);
            TbPanel_Chaos.Name = "TbPanel_Chaos";
            TbPanel_Chaos.RowCount = 3;
            TbPanel_Chaos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TbPanel_Chaos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TbPanel_Chaos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TbPanel_Chaos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TbPanel_Chaos.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            TbPanel_Chaos.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TbPanel_Chaos.Size = new Size(774, 166);
            TbPanel_Chaos.TabIndex = 13;
            // 
            // tableLayoutPanel18
            // 
            tableLayoutPanel18.ColumnCount = 2;
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.6F));
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4F));
            tableLayoutPanel18.Controls.Add(ChaosTab_LabelStatus, 0, 0);
            tableLayoutPanel18.Controls.Add(ChaosTab_Status, 1, 0);
            tableLayoutPanel18.Dock = DockStyle.Fill;
            tableLayoutPanel18.Location = new Point(445, 113);
            tableLayoutPanel18.Name = "tableLayoutPanel18";
            tableLayoutPanel18.RowCount = 1;
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel18.Size = new Size(326, 50);
            tableLayoutPanel18.TabIndex = 32;
            // 
            // ChaosTab_LabelStatus
            // 
            ChaosTab_LabelStatus.AutoSize = true;
            ChaosTab_LabelStatus.BackColor = SystemColors.Control;
            ChaosTab_LabelStatus.Depth = 0;
            ChaosTab_LabelStatus.Dock = DockStyle.Fill;
            ChaosTab_LabelStatus.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ChaosTab_LabelStatus.Location = new Point(3, 0);
            ChaosTab_LabelStatus.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_LabelStatus.Name = "ChaosTab_LabelStatus";
            ChaosTab_LabelStatus.Size = new Size(155, 50);
            ChaosTab_LabelStatus.TabIndex = 31;
            ChaosTab_LabelStatus.Text = "Status:";
            ChaosTab_LabelStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChaosTab_Status
            // 
            ChaosTab_Status.AutoSize = true;
            ChaosTab_Status.BackColor = Color.Firebrick;
            ChaosTab_Status.Depth = 0;
            ChaosTab_Status.Dock = DockStyle.Fill;
            ChaosTab_Status.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ChaosTab_Status.ForeColor = Color.White;
            ChaosTab_Status.Location = new Point(164, 0);
            ChaosTab_Status.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_Status.Name = "ChaosTab_Status";
            ChaosTab_Status.Size = new Size(159, 50);
            ChaosTab_Status.TabIndex = 32;
            ChaosTab_Status.Text = "Não iniciou";
            ChaosTab_Status.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChaosTab_btnStartStimulus
            // 
            ChaosTab_btnStartStimulus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ChaosTab_btnStartStimulus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChaosTab_btnStartStimulus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ChaosTab_btnStartStimulus.Depth = 0;
            ChaosTab_btnStartStimulus.Enabled = false;
            ChaosTab_btnStartStimulus.HighEmphasis = true;
            ChaosTab_btnStartStimulus.Icon = null;
            ChaosTab_btnStartStimulus.Location = new Point(446, 64);
            ChaosTab_btnStartStimulus.Margin = new Padding(4, 6, 4, 6);
            ChaosTab_btnStartStimulus.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_btnStartStimulus.Name = "ChaosTab_btnStartStimulus";
            ChaosTab_btnStartStimulus.NoAccentTextColor = Color.Empty;
            ChaosTab_btnStartStimulus.Size = new Size(324, 36);
            ChaosTab_btnStartStimulus.TabIndex = 30;
            ChaosTab_btnStartStimulus.Text = "Começar Estimulação";
            ChaosTab_btnStartStimulus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ChaosTab_btnStartStimulus.UseAccentColor = false;
            ChaosTab_btnStartStimulus.UseVisualStyleBackColor = true;
            ChaosTab_btnStartStimulus.Click += ChaosTab_btnStartStimulus_Click;
            // 
            // ChaosTab_btnLoadPulses
            // 
            ChaosTab_btnLoadPulses.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ChaosTab_btnLoadPulses.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChaosTab_btnLoadPulses.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ChaosTab_btnLoadPulses.Depth = 0;
            ChaosTab_btnLoadPulses.HighEmphasis = true;
            ChaosTab_btnLoadPulses.Icon = null;
            ChaosTab_btnLoadPulses.Location = new Point(446, 9);
            ChaosTab_btnLoadPulses.Margin = new Padding(4, 6, 4, 6);
            ChaosTab_btnLoadPulses.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_btnLoadPulses.Name = "ChaosTab_btnLoadPulses";
            ChaosTab_btnLoadPulses.NoAccentTextColor = Color.Empty;
            ChaosTab_btnLoadPulses.Size = new Size(324, 36);
            ChaosTab_btnLoadPulses.TabIndex = 23;
            ChaosTab_btnLoadPulses.Text = "Carregar Trens de Pulsos";
            ChaosTab_btnLoadPulses.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ChaosTab_btnLoadPulses.UseAccentColor = false;
            ChaosTab_btnLoadPulses.UseVisualStyleBackColor = true;
            ChaosTab_btnLoadPulses.Click += ChaosTab_LoadPulses_Click;
            // 
            // ChaosTab_LblInterpulseInterval
            // 
            ChaosTab_LblInterpulseInterval.AutoSize = true;
            ChaosTab_LblInterpulseInterval.BackColor = SystemColors.Control;
            ChaosTab_LblInterpulseInterval.Depth = 0;
            ChaosTab_LblInterpulseInterval.Dock = DockStyle.Fill;
            ChaosTab_LblInterpulseInterval.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ChaosTab_LblInterpulseInterval.Location = new Point(3, 110);
            ChaosTab_LblInterpulseInterval.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_LblInterpulseInterval.Name = "ChaosTab_LblInterpulseInterval";
            ChaosTab_LblInterpulseInterval.Size = new Size(239, 56);
            ChaosTab_LblInterpulseInterval.TabIndex = 28;
            ChaosTab_LblInterpulseInterval.Text = "Intervalo entre trens de pulso [ms]:";
            ChaosTab_LblInterpulseInterval.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChaosTab_CbCurrent
            // 
            ChaosTab_CbCurrent.AutoResize = false;
            ChaosTab_CbCurrent.BackColor = SystemColors.Control;
            ChaosTab_CbCurrent.Depth = 0;
            ChaosTab_CbCurrent.Dock = DockStyle.Fill;
            ChaosTab_CbCurrent.DrawMode = DrawMode.OwnerDrawVariable;
            ChaosTab_CbCurrent.DropDownHeight = 118;
            ChaosTab_CbCurrent.DropDownStyle = ComboBoxStyle.DropDownList;
            ChaosTab_CbCurrent.DropDownWidth = 121;
            ChaosTab_CbCurrent.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ChaosTab_CbCurrent.ForeColor = SystemColors.ControlText;
            ChaosTab_CbCurrent.FormattingEnabled = true;
            ChaosTab_CbCurrent.IntegralHeight = false;
            ChaosTab_CbCurrent.ItemHeight = 29;
            ChaosTab_CbCurrent.Location = new Point(248, 3);
            ChaosTab_CbCurrent.MaxDropDownItems = 4;
            ChaosTab_CbCurrent.MouseState = MaterialSkin.MouseState.OUT;
            ChaosTab_CbCurrent.Name = "ChaosTab_CbCurrent";
            ChaosTab_CbCurrent.Size = new Size(191, 35);
            ChaosTab_CbCurrent.StartIndex = 0;
            ChaosTab_CbCurrent.TabIndex = 22;
            ChaosTab_CbCurrent.UseTallSize = false;
            ChaosTab_CbCurrent.SelectedIndexChanged += ChaosTab_CbCurrent_SelectedIndexChanged;
            // 
            // ChaosTab_LblCurrent
            // 
            ChaosTab_LblCurrent.AutoSize = true;
            ChaosTab_LblCurrent.BackColor = SystemColors.Control;
            ChaosTab_LblCurrent.Depth = 0;
            ChaosTab_LblCurrent.Dock = DockStyle.Fill;
            ChaosTab_LblCurrent.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ChaosTab_LblCurrent.Location = new Point(3, 0);
            ChaosTab_LblCurrent.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_LblCurrent.Name = "ChaosTab_LblCurrent";
            ChaosTab_LblCurrent.Size = new Size(239, 55);
            ChaosTab_LblCurrent.TabIndex = 24;
            ChaosTab_LblCurrent.Text = "Corrente [uA]:";
            ChaosTab_LblCurrent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChaosTab_LblPulseLarge
            // 
            ChaosTab_LblPulseLarge.AutoSize = true;
            ChaosTab_LblPulseLarge.BackColor = SystemColors.Control;
            ChaosTab_LblPulseLarge.Depth = 0;
            ChaosTab_LblPulseLarge.Dock = DockStyle.Fill;
            ChaosTab_LblPulseLarge.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ChaosTab_LblPulseLarge.Location = new Point(3, 55);
            ChaosTab_LblPulseLarge.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_LblPulseLarge.Name = "ChaosTab_LblPulseLarge";
            ChaosTab_LblPulseLarge.Size = new Size(239, 55);
            ChaosTab_LblPulseLarge.TabIndex = 25;
            ChaosTab_LblPulseLarge.Text = "Largura do Pulso [us]:";
            ChaosTab_LblPulseLarge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChaosTab_TxtPulseLength
            // 
            ChaosTab_TxtPulseLength.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ChaosTab_TxtPulseLength.AnimateReadOnly = false;
            ChaosTab_TxtPulseLength.BorderStyle = BorderStyle.None;
            ChaosTab_TxtPulseLength.Depth = 0;
            ChaosTab_TxtPulseLength.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChaosTab_TxtPulseLength.LeadingIcon = null;
            ChaosTab_TxtPulseLength.Location = new Point(248, 64);
            ChaosTab_TxtPulseLength.MaxLength = 50;
            ChaosTab_TxtPulseLength.MouseState = MaterialSkin.MouseState.OUT;
            ChaosTab_TxtPulseLength.Multiline = false;
            ChaosTab_TxtPulseLength.Name = "ChaosTab_TxtPulseLength";
            ChaosTab_TxtPulseLength.Size = new Size(191, 36);
            ChaosTab_TxtPulseLength.TabIndex = 26;
            ChaosTab_TxtPulseLength.Text = "100";
            ChaosTab_TxtPulseLength.TrailingIcon = null;
            ChaosTab_TxtPulseLength.UseTallSize = false;
            ChaosTab_TxtPulseLength.Leave += ChaosTab_TxtPulseLength_Leave;
            // 
            // ChaosTab_TxtInterpulseInterval
            // 
            ChaosTab_TxtInterpulseInterval.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ChaosTab_TxtInterpulseInterval.AnimateReadOnly = false;
            ChaosTab_TxtInterpulseInterval.BorderStyle = BorderStyle.None;
            ChaosTab_TxtInterpulseInterval.Depth = 0;
            ChaosTab_TxtInterpulseInterval.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChaosTab_TxtInterpulseInterval.LeadingIcon = null;
            ChaosTab_TxtInterpulseInterval.Location = new Point(248, 120);
            ChaosTab_TxtInterpulseInterval.MaxLength = 50;
            ChaosTab_TxtInterpulseInterval.MouseState = MaterialSkin.MouseState.OUT;
            ChaosTab_TxtInterpulseInterval.Multiline = false;
            ChaosTab_TxtInterpulseInterval.Name = "ChaosTab_TxtInterpulseInterval";
            ChaosTab_TxtInterpulseInterval.Size = new Size(191, 36);
            ChaosTab_TxtInterpulseInterval.TabIndex = 29;
            ChaosTab_TxtInterpulseInterval.Text = "50000";
            ChaosTab_TxtInterpulseInterval.TrailingIcon = null;
            ChaosTab_TxtInterpulseInterval.UseTallSize = false;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Controls.Add(tableLayoutPanel13, 0, 0);
            tableLayoutPanel14.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(0, 0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Size = new Size(590, 533);
            tableLayoutPanel14.TabIndex = 28;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Controls.Add(materialLabel1, 0, 0);
            tableLayoutPanel13.Controls.Add(tableLayoutPanel12, 0, 4);
            tableLayoutPanel13.Controls.Add(tableLayoutPanel11, 0, 1);
            tableLayoutPanel13.Controls.Add(switchDefaultParameters, 0, 2);
            tableLayoutPanel13.Controls.Add(groupBox1, 0, 3);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 5;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel13.Size = new Size(289, 527);
            tableLayoutPanel13.TabIndex = 27;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(3, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(99, 19);
            materialLabel1.TabIndex = 18;
            materialLabel1.Text = "Portas Seriais";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(btnDisconnect, 1, 0);
            tableLayoutPanel12.Controls.Add(btnConnect, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 480);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(283, 44);
            tableLayoutPanel12.TabIndex = 26;
            // 
            // btnDisconnect
            // 
            btnDisconnect.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDisconnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDisconnect.Depth = 0;
            btnDisconnect.Dock = DockStyle.Fill;
            btnDisconnect.Enabled = false;
            btnDisconnect.HighEmphasis = true;
            btnDisconnect.Icon = null;
            btnDisconnect.Location = new Point(145, 6);
            btnDisconnect.Margin = new Padding(4, 6, 4, 6);
            btnDisconnect.MouseState = MaterialSkin.MouseState.HOVER;
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.NoAccentTextColor = Color.Empty;
            btnDisconnect.Size = new Size(134, 32);
            btnDisconnect.TabIndex = 23;
            btnDisconnect.Text = "Desconectar";
            btnDisconnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDisconnect.UseAccentColor = false;
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += BtnDisconnect_Click;
            // 
            // btnConnect
            // 
            btnConnect.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConnect.Depth = 0;
            btnConnect.Dock = DockStyle.Fill;
            btnConnect.HighEmphasis = true;
            btnConnect.Icon = null;
            btnConnect.Location = new Point(4, 6);
            btnConnect.Margin = new Padding(4, 6, 4, 6);
            btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            btnConnect.Name = "btnConnect";
            btnConnect.NoAccentTextColor = Color.Empty;
            btnConnect.Size = new Size(133, 32);
            btnConnect.TabIndex = 22;
            btnConnect.Text = "Conectar";
            btnConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConnect.UseAccentColor = false;
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += BtnConnect_Click;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(cbComPortsList, 0, 0);
            tableLayoutPanel11.Controls.Add(btnUpdate, 1, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 23);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(283, 44);
            tableLayoutPanel11.TabIndex = 25;
            // 
            // cbComPortsList
            // 
            cbComPortsList.AutoResize = false;
            cbComPortsList.BackColor = Color.FromArgb(255, 255, 255);
            cbComPortsList.Depth = 0;
            cbComPortsList.Dock = DockStyle.Fill;
            cbComPortsList.DrawMode = DrawMode.OwnerDrawVariable;
            cbComPortsList.DropDownHeight = 118;
            cbComPortsList.DropDownStyle = ComboBoxStyle.DropDownList;
            cbComPortsList.DropDownWidth = 121;
            cbComPortsList.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbComPortsList.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbComPortsList.FormattingEnabled = true;
            cbComPortsList.IntegralHeight = false;
            cbComPortsList.ItemHeight = 29;
            cbComPortsList.Location = new Point(3, 3);
            cbComPortsList.MaxDropDownItems = 4;
            cbComPortsList.MouseState = MaterialSkin.MouseState.OUT;
            cbComPortsList.Name = "cbComPortsList";
            cbComPortsList.Size = new Size(135, 35);
            cbComPortsList.StartIndex = 0;
            cbComPortsList.TabIndex = 17;
            cbComPortsList.UseTallSize = false;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.Dock = DockStyle.Fill;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(145, 6);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(134, 32);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Atualizar";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // switchDefaultParameters
            // 
            switchDefaultParameters.AutoSize = true;
            switchDefaultParameters.Checked = true;
            switchDefaultParameters.CheckState = CheckState.Checked;
            switchDefaultParameters.Depth = 0;
            switchDefaultParameters.Location = new Point(0, 70);
            switchDefaultParameters.Margin = new Padding(0);
            switchDefaultParameters.MouseLocation = new Point(-1, -1);
            switchDefaultParameters.MouseState = MaterialSkin.MouseState.HOVER;
            switchDefaultParameters.Name = "switchDefaultParameters";
            switchDefaultParameters.Ripple = true;
            switchDefaultParameters.Size = new Size(229, 30);
            switchDefaultParameters.TabIndex = 20;
            switchDefaultParameters.Text = "Usar parâmetros padrão";
            switchDefaultParameters.UseVisualStyleBackColor = true;
            switchDefaultParameters.CheckedChanged += SwitchDefaultParameters_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel9);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 371);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parâmetros";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 29);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 37.68546F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 62.31454F));
            tableLayoutPanel9.Size = new Size(277, 339);
            tableLayoutPanel9.TabIndex = 25;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(txtWriteTimeOut, 1, 3);
            tableLayoutPanel8.Controls.Add(txtReadTimeOut, 0, 3);
            tableLayoutPanel8.Controls.Add(txtDataBits, 1, 1);
            tableLayoutPanel8.Controls.Add(txtBaudRate, 0, 1);
            tableLayoutPanel8.Controls.Add(materialLabel5, 1, 0);
            tableLayoutPanel8.Controls.Add(materialLabel4, 0, 0);
            tableLayoutPanel8.Controls.Add(materialLabel7, 1, 2);
            tableLayoutPanel8.Controls.Add(materialLabel6, 0, 2);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 4;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(271, 121);
            tableLayoutPanel8.TabIndex = 24;
            // 
            // txtWriteTimeOut
            // 
            txtWriteTimeOut.AnimateReadOnly = false;
            txtWriteTimeOut.BorderStyle = BorderStyle.None;
            txtWriteTimeOut.Depth = 0;
            txtWriteTimeOut.Dock = DockStyle.Fill;
            txtWriteTimeOut.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtWriteTimeOut.LeadingIcon = null;
            txtWriteTimeOut.Location = new Point(138, 83);
            txtWriteTimeOut.MaxLength = 50;
            txtWriteTimeOut.MouseState = MaterialSkin.MouseState.OUT;
            txtWriteTimeOut.Multiline = false;
            txtWriteTimeOut.Name = "txtWriteTimeOut";
            txtWriteTimeOut.Size = new Size(130, 36);
            txtWriteTimeOut.TabIndex = 17;
            txtWriteTimeOut.Text = "";
            txtWriteTimeOut.TrailingIcon = null;
            txtWriteTimeOut.UseTallSize = false;
            // 
            // txtReadTimeOut
            // 
            txtReadTimeOut.AnimateReadOnly = false;
            txtReadTimeOut.BorderStyle = BorderStyle.None;
            txtReadTimeOut.Depth = 0;
            txtReadTimeOut.Dock = DockStyle.Fill;
            txtReadTimeOut.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtReadTimeOut.LeadingIcon = null;
            txtReadTimeOut.Location = new Point(3, 83);
            txtReadTimeOut.MaxLength = 50;
            txtReadTimeOut.MouseState = MaterialSkin.MouseState.OUT;
            txtReadTimeOut.Multiline = false;
            txtReadTimeOut.Name = "txtReadTimeOut";
            txtReadTimeOut.Size = new Size(129, 36);
            txtReadTimeOut.TabIndex = 16;
            txtReadTimeOut.Text = "";
            txtReadTimeOut.TrailingIcon = null;
            txtReadTimeOut.UseTallSize = false;
            // 
            // txtDataBits
            // 
            txtDataBits.AnimateReadOnly = false;
            txtDataBits.BorderStyle = BorderStyle.None;
            txtDataBits.Depth = 0;
            txtDataBits.Dock = DockStyle.Fill;
            txtDataBits.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataBits.LeadingIcon = null;
            txtDataBits.Location = new Point(138, 23);
            txtDataBits.MaxLength = 50;
            txtDataBits.MouseState = MaterialSkin.MouseState.OUT;
            txtDataBits.Multiline = false;
            txtDataBits.Name = "txtDataBits";
            txtDataBits.Size = new Size(130, 36);
            txtDataBits.TabIndex = 18;
            txtDataBits.Text = "";
            txtDataBits.TrailingIcon = null;
            txtDataBits.UseTallSize = false;
            // 
            // txtBaudRate
            // 
            txtBaudRate.AnimateReadOnly = false;
            txtBaudRate.BorderStyle = BorderStyle.None;
            txtBaudRate.Depth = 0;
            txtBaudRate.Dock = DockStyle.Fill;
            txtBaudRate.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBaudRate.LeadingIcon = null;
            txtBaudRate.Location = new Point(3, 23);
            txtBaudRate.MaxLength = 50;
            txtBaudRate.MouseState = MaterialSkin.MouseState.OUT;
            txtBaudRate.Multiline = false;
            txtBaudRate.Name = "txtBaudRate";
            txtBaudRate.Size = new Size(129, 36);
            txtBaudRate.TabIndex = 15;
            txtBaudRate.Text = "";
            txtBaudRate.TrailingIcon = null;
            txtBaudRate.UseTallSize = false;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(138, 0);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(70, 19);
            materialLabel5.TabIndex = 9;
            materialLabel5.Text = "Data Bits:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(3, 0);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(78, 19);
            materialLabel4.TabIndex = 8;
            materialLabel4.Text = "Baud Rate:";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(138, 60);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(110, 19);
            materialLabel7.TabIndex = 11;
            materialLabel7.Text = "Write Time Out:";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(3, 60);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(110, 19);
            materialLabel6.TabIndex = 10;
            materialLabel6.Text = "Read Time Out:";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(materialLabel8, 0, 0);
            tableLayoutPanel10.Controls.Add(cbParity, 0, 1);
            tableLayoutPanel10.Controls.Add(cbHandShake, 0, 5);
            tableLayoutPanel10.Controls.Add(materialLabel10, 0, 4);
            tableLayoutPanel10.Controls.Add(cbStopBits, 0, 3);
            tableLayoutPanel10.Controls.Add(materialLabel9, 0, 2);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 130);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 6;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel10.Size = new Size(271, 206);
            tableLayoutPanel10.TabIndex = 25;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(3, 0);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(46, 19);
            materialLabel8.TabIndex = 12;
            materialLabel8.Text = "Parity:";
            // 
            // cbParity
            // 
            cbParity.AutoResize = false;
            cbParity.BackColor = Color.FromArgb(255, 255, 255);
            cbParity.Depth = 0;
            cbParity.Dock = DockStyle.Fill;
            cbParity.DrawMode = DrawMode.OwnerDrawVariable;
            cbParity.DropDownHeight = 118;
            cbParity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbParity.DropDownWidth = 121;
            cbParity.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbParity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbParity.FormattingEnabled = true;
            cbParity.IntegralHeight = false;
            cbParity.ItemHeight = 29;
            cbParity.Location = new Point(3, 23);
            cbParity.MaxDropDownItems = 4;
            cbParity.MouseState = MaterialSkin.MouseState.OUT;
            cbParity.Name = "cbParity";
            cbParity.Size = new Size(265, 35);
            cbParity.StartIndex = 0;
            cbParity.TabIndex = 15;
            cbParity.UseTallSize = false;
            // 
            // cbHandShake
            // 
            cbHandShake.AutoResize = false;
            cbHandShake.BackColor = Color.FromArgb(255, 255, 255);
            cbHandShake.Depth = 0;
            cbHandShake.Dock = DockStyle.Fill;
            cbHandShake.DrawMode = DrawMode.OwnerDrawVariable;
            cbHandShake.DropDownHeight = 118;
            cbHandShake.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHandShake.DropDownWidth = 121;
            cbHandShake.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbHandShake.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbHandShake.FormattingEnabled = true;
            cbHandShake.IntegralHeight = false;
            cbHandShake.ItemHeight = 29;
            cbHandShake.Location = new Point(3, 159);
            cbHandShake.MaxDropDownItems = 4;
            cbHandShake.MouseState = MaterialSkin.MouseState.OUT;
            cbHandShake.Name = "cbHandShake";
            cbHandShake.Size = new Size(265, 35);
            cbHandShake.StartIndex = 0;
            cbHandShake.TabIndex = 23;
            cbHandShake.UseTallSize = false;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(3, 136);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(91, 19);
            materialLabel10.TabIndex = 14;
            materialLabel10.Text = "Hand Shake:";
            // 
            // cbStopBits
            // 
            cbStopBits.AutoResize = false;
            cbStopBits.BackColor = Color.FromArgb(255, 255, 255);
            cbStopBits.Depth = 0;
            cbStopBits.Dock = DockStyle.Fill;
            cbStopBits.DrawMode = DrawMode.OwnerDrawVariable;
            cbStopBits.DropDownHeight = 118;
            cbStopBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStopBits.DropDownWidth = 121;
            cbStopBits.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbStopBits.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbStopBits.FormattingEnabled = true;
            cbStopBits.IntegralHeight = false;
            cbStopBits.ItemHeight = 29;
            cbStopBits.Location = new Point(3, 91);
            cbStopBits.MaxDropDownItems = 4;
            cbStopBits.MouseState = MaterialSkin.MouseState.OUT;
            cbStopBits.Name = "cbStopBits";
            cbStopBits.Size = new Size(265, 35);
            cbStopBits.StartIndex = 0;
            cbStopBits.TabIndex = 22;
            cbStopBits.UseTallSize = false;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(3, 68);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(69, 19);
            materialLabel9.TabIndex = 13;
            materialLabel9.Text = "Stop Bits:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel15);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(298, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(289, 527);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados Recebidos";
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 1;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel15.Controls.Add(btnCleanTxtReceive, 0, 0);
            tableLayoutPanel15.Controls.Add(txtReceivedData, 0, 1);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(3, 28);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 2;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel15.Size = new Size(283, 496);
            tableLayoutPanel15.TabIndex = 29;
            // 
            // btnCleanTxtReceive
            // 
            btnCleanTxtReceive.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCleanTxtReceive.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCleanTxtReceive.Depth = 0;
            btnCleanTxtReceive.Dock = DockStyle.Top;
            btnCleanTxtReceive.HighEmphasis = true;
            btnCleanTxtReceive.Icon = null;
            btnCleanTxtReceive.Location = new Point(4, 6);
            btnCleanTxtReceive.Margin = new Padding(4, 6, 4, 6);
            btnCleanTxtReceive.MouseState = MaterialSkin.MouseState.HOVER;
            btnCleanTxtReceive.Name = "btnCleanTxtReceive";
            btnCleanTxtReceive.NoAccentTextColor = Color.Empty;
            btnCleanTxtReceive.Size = new Size(275, 36);
            btnCleanTxtReceive.TabIndex = 21;
            btnCleanTxtReceive.Text = "Limpar";
            btnCleanTxtReceive.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCleanTxtReceive.UseAccentColor = false;
            btnCleanTxtReceive.UseVisualStyleBackColor = true;
            btnCleanTxtReceive.Click += BtnCleanTxtReceive_Click;
            // 
            // txtReceivedData
            // 
            txtReceivedData.BackColor = Color.FromArgb(255, 255, 255);
            txtReceivedData.BorderStyle = BorderStyle.None;
            txtReceivedData.Depth = 0;
            txtReceivedData.Dock = DockStyle.Fill;
            txtReceivedData.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtReceivedData.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtReceivedData.Location = new Point(3, 53);
            txtReceivedData.MouseState = MaterialSkin.MouseState.HOVER;
            txtReceivedData.Name = "txtReceivedData";
            txtReceivedData.ReadOnly = true;
            txtReceivedData.Size = new Size(277, 440);
            txtReceivedData.TabIndex = 0;
            txtReceivedData.Text = "";
            txtReceivedData.TextChanged += TxtReceivedData_TextChanged;
            // 
            // SynaptiPulse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 600);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SynaptiPulse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estimulador Cerebral - SynaptiPulse";
            FormClosing += BrainStimulator_FormClosing;
            FormClosed += BrainStimulator_FormClosed;
            Load += BrainStimulator_Load;
            tableLayoutPanel1.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            tabPeriodic.ResumeLayout(false);
            tbPanel_PeriodicTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PeriodicTab_GridMain).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            PeriodicTab_HeaderPanel.ResumeLayout(false);
            PeriodicTab_HeaderPanel.PerformLayout();
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            tabChaos.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            groupBox4.ResumeLayout(false);
            TbPanel_Chaos.ResumeLayout(false);
            TbPanel_Chaos.PerformLayout();
            tableLayoutPanel18.ResumeLayout(false);
            tableLayoutPanel18.PerformLayout();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtReceivedData;
        private MaterialSkin.Controls.MaterialButton btnDisconnect;
        private MaterialSkin.Controls.MaterialButton btnConnect;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialComboBox cbHandShake;
        private MaterialSkin.Controls.MaterialComboBox cbStopBits;
        private MaterialSkin.Controls.MaterialComboBox cbParity;
        private MaterialSkin.Controls.MaterialTextBox txtDataBits;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox txtWriteTimeOut;
        private MaterialSkin.Controls.MaterialTextBox txtReadTimeOut;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txtBaudRate;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSwitch switchDefaultParameters;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cbComPortsList;
        private TabControl TabControl;
        private TabPage tabPeriodic;
        private TableLayoutPanel tbPanel_PeriodicTab;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel PeriodicTab_HeaderPanel;
        private MaterialSkin.Controls.MaterialButton PeriodicTab_AddPulse;
        private MaterialSkin.Controls.MaterialButton PeriodicTab_RemovePulse;
        private MaterialSkin.Controls.MaterialButton PeriodicTab_SendConfigToBoard;
        private MaterialSkin.Controls.MaterialComboBox PeriodicTab_CbCurrents;
        private MaterialSkin.Controls.MaterialSwitch PeriodicTab_SwitchCurrent;
        private TabPage tabChaos;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton PeriodicTab_StartStimulation;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel13;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel14;
        private TableLayoutPanel tableLayoutPanel15;
        private MaterialSkin.Controls.MaterialButton btnCleanTxtReceive;
        private OxyPlot.WindowsForms.PlotView PeriodicTab_ChartPlotView;
        private TableLayoutPanel tableLayoutPanel16;
        private MaterialSkin.Controls.MaterialButton PeriodicTab_LoadRoutine;
        private MaterialSkin.Controls.MaterialButton PeriodicTab_SaveRoutine;
        private DataGridView PeriodicTab_GridMain;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel5;
        private OxyPlot.WindowsForms.PlotView ChaosTab_ChartPlotView_Train;
        private TableLayoutPanel tableLayoutPanel6;
        private MaterialSkin.Controls.MaterialLabel ChaosTab_LblInterval;
        private MaterialSkin.Controls.MaterialComboBox ChaosTab_CbPulseTrains;
        private GroupBox groupBox4;
        private TableLayoutPanel TbPanel_Chaos;
        private TableLayoutPanel tableLayoutPanel18;
        private MaterialSkin.Controls.MaterialButton ChaosTab_btnStartStimulus;
        private MaterialSkin.Controls.MaterialButton ChaosTab_btnLoadPulses;
        private MaterialSkin.Controls.MaterialLabel ChaosTab_LblInterpulseInterval;
        private MaterialSkin.Controls.MaterialComboBox ChaosTab_CbCurrent;
        private MaterialSkin.Controls.MaterialLabel ChaosTab_LblCurrent;
        private MaterialSkin.Controls.MaterialLabel ChaosTab_LblPulseLarge;
        private MaterialSkin.Controls.MaterialTextBox ChaosTab_TxtPulseLength;
        private MaterialSkin.Controls.MaterialTextBox ChaosTab_TxtInterpulseInterval;
        private MaterialSkin.Controls.MaterialLabel ChaosTab_LabelStatus;
        private MaterialSkin.Controls.MaterialLabel ChaosTab_Status;
    }
}