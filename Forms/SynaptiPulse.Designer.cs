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
            tableLayoutPanel7 = new TableLayoutPanel();
            PeriodicTab_HeaderPanel = new TableLayoutPanel();
            PeriodicTab_AddPulse = new MaterialSkin.Controls.MaterialButton();
            PeriodicTab_RemovePulse = new MaterialSkin.Controls.MaterialButton();
            PeriodicTab_SendConfigToBoard = new MaterialSkin.Controls.MaterialButton();
            PeriodicTab_CbCurrents = new MaterialSkin.Controls.MaterialComboBox();
            PeriodicTab_SwitchCurrent = new MaterialSkin.Controls.MaterialSwitch();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            PeriodicTab_GridMain = new DataGridView();
            PeriodicTab_ChartPlotView = new OxyPlot.WindowsForms.PlotView();
            tabChaos = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            ChaosTab_GridMain = new DataGridView();
            TbPanel_Chaos = new TableLayoutPanel();
            ChaosTab_CbPulseTrains = new MaterialSkin.Controls.MaterialComboBox();
            ChaosTab_LblInterpulseInterval = new MaterialSkin.Controls.MaterialLabel();
            ChaosTab_CbCurrent = new MaterialSkin.Controls.MaterialComboBox();
            ChaosTab_LblCurrent = new MaterialSkin.Controls.MaterialLabel();
            ChaosTab_LblPulseLarge = new MaterialSkin.Controls.MaterialLabel();
            ChaosTab_TxtPulseLength = new MaterialSkin.Controls.MaterialTextBox();
            ChaosTab_btnLoadPulses = new MaterialSkin.Controls.MaterialButton();
            ChaosTab_btnStartStimulus = new MaterialSkin.Controls.MaterialButton();
            ChaosTab_btnSendConfigToBoard = new MaterialSkin.Controls.MaterialButton();
            ChaosTab_TxtInterpulseInterval = new MaterialSkin.Controls.MaterialTextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            ChaosTab_ChartPlotView_Train = new OxyPlot.WindowsForms.PlotView();
            tableLayoutPanel6 = new TableLayoutPanel();
            ChaosTab_LblInterval = new MaterialSkin.Controls.MaterialLabel();
            ChaosTab_LblPulseTrain = new MaterialSkin.Controls.MaterialLabel();
            groupBox2 = new GroupBox();
            txtReceivedData = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            btnDisconnect = new MaterialSkin.Controls.MaterialButton();
            btnConnect = new MaterialSkin.Controls.MaterialButton();
            groupBox1 = new GroupBox();
            cbHandShake = new MaterialSkin.Controls.MaterialComboBox();
            cbStopBits = new MaterialSkin.Controls.MaterialComboBox();
            cbParity = new MaterialSkin.Controls.MaterialComboBox();
            txtDataBits = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            txtWriteTimeOut = new MaterialSkin.Controls.MaterialTextBox();
            txtReadTimeOut = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            txtBaudRate = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            switchDefaultParameters = new MaterialSkin.Controls.MaterialSwitch();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            cbComPortsList = new MaterialSkin.Controls.MaterialComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            TabControl.SuspendLayout();
            tabPeriodic.SuspendLayout();
            tbPanel_PeriodicTab.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            PeriodicTab_HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PeriodicTab_GridMain).BeginInit();
            tabChaos.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChaosTab_GridMain).BeginInit();
            TbPanel_Chaos.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            splitContainer.Panel2.Controls.Add(groupBox2);
            splitContainer.Panel2.Controls.Add(btnDisconnect);
            splitContainer.Panel2.Controls.Add(btnConnect);
            splitContainer.Panel2.Controls.Add(groupBox1);
            splitContainer.Panel2.Controls.Add(switchDefaultParameters);
            splitContainer.Panel2.Controls.Add(btnUpdate);
            splitContainer.Panel2.Controls.Add(materialLabel1);
            splitContainer.Panel2.Controls.Add(cbComPortsList);
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
            tbPanel_PeriodicTab.Controls.Add(tableLayoutPanel7, 0, 0);
            tbPanel_PeriodicTab.Controls.Add(PeriodicTab_ChartPlotView, 0, 1);
            tbPanel_PeriodicTab.Dock = DockStyle.Fill;
            tbPanel_PeriodicTab.Location = new Point(3, 3);
            tbPanel_PeriodicTab.Margin = new Padding(0);
            tbPanel_PeriodicTab.Name = "tbPanel_PeriodicTab";
            tbPanel_PeriodicTab.RowCount = 2;
            tbPanel_PeriodicTab.RowStyles.Add(new RowStyle(SizeType.Percent, 46.7666359F));
            tbPanel_PeriodicTab.RowStyles.Add(new RowStyle(SizeType.Percent, 53.2333641F));
            tbPanel_PeriodicTab.Size = new Size(786, 499);
            tbPanel_PeriodicTab.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.43979F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.56021F));
            tableLayoutPanel7.Controls.Add(PeriodicTab_HeaderPanel, 0, 0);
            tableLayoutPanel7.Controls.Add(PeriodicTab_GridMain, 1, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 21.393034F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 78.6069641F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(786, 233);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // PeriodicTab_HeaderPanel
            // 
            PeriodicTab_HeaderPanel.ColumnCount = 6;
            PeriodicTab_HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.8320608F));
            PeriodicTab_HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.9949112F));
            PeriodicTab_HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            PeriodicTab_HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.70229F));
            PeriodicTab_HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.0101776F));
            PeriodicTab_HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            PeriodicTab_HeaderPanel.Controls.Add(PeriodicTab_AddPulse, 0, 0);
            PeriodicTab_HeaderPanel.Controls.Add(PeriodicTab_RemovePulse, 1, 0);
            PeriodicTab_HeaderPanel.Controls.Add(PeriodicTab_SendConfigToBoard, 2, 0);
            PeriodicTab_HeaderPanel.Controls.Add(PeriodicTab_CbCurrents, 5, 0);
            PeriodicTab_HeaderPanel.Controls.Add(PeriodicTab_SwitchCurrent, 4, 0);
            PeriodicTab_HeaderPanel.Controls.Add(materialButton1, 3, 0);
            PeriodicTab_HeaderPanel.Dock = DockStyle.Fill;
            PeriodicTab_HeaderPanel.Location = new Point(0, 0);
            PeriodicTab_HeaderPanel.Margin = new Padding(0);
            PeriodicTab_HeaderPanel.Name = "PeriodicTab_HeaderPanel";
            PeriodicTab_HeaderPanel.RowCount = 1;
            PeriodicTab_HeaderPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PeriodicTab_HeaderPanel.Size = new Size(786, 49);
            PeriodicTab_HeaderPanel.TabIndex = 6;
            // 
            // PeriodicTab_AddPulse
            // 
            PeriodicTab_AddPulse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PeriodicTab_AddPulse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PeriodicTab_AddPulse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            PeriodicTab_AddPulse.Depth = 0;
            PeriodicTab_AddPulse.HighEmphasis = true;
            PeriodicTab_AddPulse.Icon = null;
            PeriodicTab_AddPulse.Location = new Point(4, 6);
            PeriodicTab_AddPulse.Margin = new Padding(4, 6, 4, 6);
            PeriodicTab_AddPulse.MouseState = MaterialSkin.MouseState.HOVER;
            PeriodicTab_AddPulse.Name = "PeriodicTab_AddPulse";
            PeriodicTab_AddPulse.NoAccentTextColor = Color.Empty;
            PeriodicTab_AddPulse.Size = new Size(85, 36);
            PeriodicTab_AddPulse.TabIndex = 0;
            PeriodicTab_AddPulse.Text = "adicionar pulsos";
            PeriodicTab_AddPulse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            PeriodicTab_AddPulse.UseAccentColor = false;
            PeriodicTab_AddPulse.UseVisualStyleBackColor = true;
            PeriodicTab_AddPulse.Click += PeriodicTab_AddPulse_Click;
            // 
            // PeriodicTab_RemovePulse
            // 
            PeriodicTab_RemovePulse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PeriodicTab_RemovePulse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PeriodicTab_RemovePulse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            PeriodicTab_RemovePulse.Depth = 0;
            PeriodicTab_RemovePulse.HighEmphasis = true;
            PeriodicTab_RemovePulse.Icon = null;
            PeriodicTab_RemovePulse.Location = new Point(97, 6);
            PeriodicTab_RemovePulse.Margin = new Padding(4, 6, 4, 6);
            PeriodicTab_RemovePulse.MouseState = MaterialSkin.MouseState.HOVER;
            PeriodicTab_RemovePulse.Name = "PeriodicTab_RemovePulse";
            PeriodicTab_RemovePulse.NoAccentTextColor = Color.Empty;
            PeriodicTab_RemovePulse.Size = new Size(102, 36);
            PeriodicTab_RemovePulse.TabIndex = 5;
            PeriodicTab_RemovePulse.Text = "Remover pulsos";
            PeriodicTab_RemovePulse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            PeriodicTab_RemovePulse.UseAccentColor = false;
            PeriodicTab_RemovePulse.UseVisualStyleBackColor = true;
            PeriodicTab_RemovePulse.Click += PeriodicTab_RemovePulse_Click;
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
            PeriodicTab_SendConfigToBoard.Location = new Point(207, 6);
            PeriodicTab_SendConfigToBoard.Margin = new Padding(4, 6, 4, 6);
            PeriodicTab_SendConfigToBoard.MouseState = MaterialSkin.MouseState.HOVER;
            PeriodicTab_SendConfigToBoard.Name = "PeriodicTab_SendConfigToBoard";
            PeriodicTab_SendConfigToBoard.NoAccentTextColor = Color.Empty;
            PeriodicTab_SendConfigToBoard.Size = new Size(123, 36);
            PeriodicTab_SendConfigToBoard.TabIndex = 8;
            PeriodicTab_SendConfigToBoard.Text = "Enviar Config à placa";
            PeriodicTab_SendConfigToBoard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            PeriodicTab_SendConfigToBoard.UseAccentColor = false;
            PeriodicTab_SendConfigToBoard.UseVisualStyleBackColor = true;
            PeriodicTab_SendConfigToBoard.Click += PeriodicTab_SendConfigToBoard_Click;
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
            PeriodicTab_CbCurrents.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            PeriodicTab_CbCurrents.ForeColor = SystemColors.ControlText;
            PeriodicTab_CbCurrents.FormattingEnabled = true;
            PeriodicTab_CbCurrents.IntegralHeight = false;
            PeriodicTab_CbCurrents.ItemHeight = 29;
            PeriodicTab_CbCurrents.Location = new Point(657, 6);
            PeriodicTab_CbCurrents.MaxDropDownItems = 4;
            PeriodicTab_CbCurrents.MouseState = MaterialSkin.MouseState.OUT;
            PeriodicTab_CbCurrents.Name = "PeriodicTab_CbCurrents";
            PeriodicTab_CbCurrents.Size = new Size(126, 35);
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
            PeriodicTab_SwitchCurrent.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PeriodicTab_SwitchCurrent.ForeColor = SystemColors.ControlText;
            PeriodicTab_SwitchCurrent.Location = new Point(481, 6);
            PeriodicTab_SwitchCurrent.Margin = new Padding(0);
            PeriodicTab_SwitchCurrent.MouseLocation = new Point(-1, -1);
            PeriodicTab_SwitchCurrent.MouseState = MaterialSkin.MouseState.HOVER;
            PeriodicTab_SwitchCurrent.Name = "PeriodicTab_SwitchCurrent";
            PeriodicTab_SwitchCurrent.Ripple = true;
            PeriodicTab_SwitchCurrent.Size = new Size(173, 37);
            PeriodicTab_SwitchCurrent.TabIndex = 21;
            PeriodicTab_SwitchCurrent.Text = "Fixar corrente";
            PeriodicTab_SwitchCurrent.TextAlign = ContentAlignment.MiddleCenter;
            PeriodicTab_SwitchCurrent.UseVisualStyleBackColor = false;
            PeriodicTab_SwitchCurrent.CheckedChanged += PeriodicTab_SwitchGlobalCurrent_CheckedChanged;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Enabled = false;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(338, 6);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(139, 36);
            materialButton1.TabIndex = 31;
            materialButton1.Text = "Começar Estimulação";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
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
            PeriodicTab_GridMain.Location = new Point(0, 49);
            PeriodicTab_GridMain.Margin = new Padding(0);
            PeriodicTab_GridMain.Name = "PeriodicTab_GridMain";
            PeriodicTab_GridMain.RowTemplate.Height = 25;
            PeriodicTab_GridMain.Size = new Size(786, 184);
            PeriodicTab_GridMain.TabIndex = 1;
            PeriodicTab_GridMain.CellEndEdit += PeriodicTab_GridMain_CellEndEdit;
            PeriodicTab_GridMain.ColumnDataPropertyNameChanged += PeriodicTab_GridMain_ColumnDataPropertyNameChanged;
            PeriodicTab_GridMain.DataError += PeriodicTab_GridMain_DataError;
            // 
            // PeriodicTab_ChartPlotView
            // 
            PeriodicTab_ChartPlotView.Dock = DockStyle.Fill;
            PeriodicTab_ChartPlotView.Location = new Point(3, 236);
            PeriodicTab_ChartPlotView.Name = "PeriodicTab_ChartPlotView";
            PeriodicTab_ChartPlotView.PanCursor = Cursors.Hand;
            PeriodicTab_ChartPlotView.Size = new Size(780, 260);
            PeriodicTab_ChartPlotView.TabIndex = 1;
            PeriodicTab_ChartPlotView.Text = "plotView1";
            PeriodicTab_ChartPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
            PeriodicTab_ChartPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            PeriodicTab_ChartPlotView.ZoomVerticalCursor = Cursors.SizeNS;
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
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.43979F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.56021F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 39.47896F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60.52104F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(786, 499);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.3460541F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.6539459F));
            tableLayoutPanel4.Controls.Add(ChaosTab_GridMain, 0, 0);
            tableLayoutPanel4.Controls.Add(TbPanel_Chaos, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(786, 197);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // ChaosTab_GridMain
            // 
            ChaosTab_GridMain.AllowUserToAddRows = false;
            ChaosTab_GridMain.AllowUserToDeleteRows = false;
            ChaosTab_GridMain.AllowUserToOrderColumns = true;
            ChaosTab_GridMain.AllowUserToResizeRows = false;
            ChaosTab_GridMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ChaosTab_GridMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ChaosTab_GridMain.Dock = DockStyle.Fill;
            ChaosTab_GridMain.Location = new Point(380, 0);
            ChaosTab_GridMain.Margin = new Padding(0);
            ChaosTab_GridMain.Name = "ChaosTab_GridMain";
            ChaosTab_GridMain.ReadOnly = true;
            ChaosTab_GridMain.RowTemplate.Height = 25;
            ChaosTab_GridMain.Size = new Size(406, 197);
            ChaosTab_GridMain.TabIndex = 27;
            // 
            // TbPanel_Chaos
            // 
            TbPanel_Chaos.ColumnCount = 2;
            TbPanel_Chaos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.6174126F));
            TbPanel_Chaos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.3825874F));
            TbPanel_Chaos.Controls.Add(ChaosTab_CbPulseTrains, 1, 3);
            TbPanel_Chaos.Controls.Add(ChaosTab_LblInterpulseInterval, 0, 2);
            TbPanel_Chaos.Controls.Add(ChaosTab_CbCurrent, 1, 0);
            TbPanel_Chaos.Controls.Add(ChaosTab_LblCurrent, 0, 0);
            TbPanel_Chaos.Controls.Add(ChaosTab_LblPulseLarge, 0, 1);
            TbPanel_Chaos.Controls.Add(ChaosTab_TxtPulseLength, 1, 1);
            TbPanel_Chaos.Controls.Add(ChaosTab_btnLoadPulses, 0, 3);
            TbPanel_Chaos.Controls.Add(ChaosTab_btnStartStimulus, 1, 4);
            TbPanel_Chaos.Controls.Add(ChaosTab_btnSendConfigToBoard, 0, 4);
            TbPanel_Chaos.Controls.Add(ChaosTab_TxtInterpulseInterval, 1, 2);
            TbPanel_Chaos.Dock = DockStyle.Fill;
            TbPanel_Chaos.Location = new Point(0, 0);
            TbPanel_Chaos.Margin = new Padding(0);
            TbPanel_Chaos.Name = "TbPanel_Chaos";
            TbPanel_Chaos.RowCount = 5;
            TbPanel_Chaos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TbPanel_Chaos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TbPanel_Chaos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TbPanel_Chaos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TbPanel_Chaos.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            TbPanel_Chaos.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TbPanel_Chaos.Size = new Size(380, 197);
            TbPanel_Chaos.TabIndex = 7;
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
            ChaosTab_CbPulseTrains.Location = new Point(210, 123);
            ChaosTab_CbPulseTrains.MaxDropDownItems = 4;
            ChaosTab_CbPulseTrains.MouseState = MaterialSkin.MouseState.OUT;
            ChaosTab_CbPulseTrains.Name = "ChaosTab_CbPulseTrains";
            ChaosTab_CbPulseTrains.Size = new Size(167, 35);
            ChaosTab_CbPulseTrains.StartIndex = 0;
            ChaosTab_CbPulseTrains.TabIndex = 31;
            ChaosTab_CbPulseTrains.UseTallSize = false;
            ChaosTab_CbPulseTrains.SelectedIndexChanged += ChaosTab_CbPulseTrains_SelectedIndexChanged;
            // 
            // ChaosTab_LblInterpulseInterval
            // 
            ChaosTab_LblInterpulseInterval.AutoSize = true;
            ChaosTab_LblInterpulseInterval.BackColor = SystemColors.Control;
            ChaosTab_LblInterpulseInterval.Depth = 0;
            ChaosTab_LblInterpulseInterval.Dock = DockStyle.Fill;
            ChaosTab_LblInterpulseInterval.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ChaosTab_LblInterpulseInterval.Location = new Point(3, 80);
            ChaosTab_LblInterpulseInterval.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_LblInterpulseInterval.Name = "ChaosTab_LblInterpulseInterval";
            ChaosTab_LblInterpulseInterval.Size = new Size(201, 40);
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
            ChaosTab_CbCurrent.Location = new Point(210, 3);
            ChaosTab_CbCurrent.MaxDropDownItems = 4;
            ChaosTab_CbCurrent.MouseState = MaterialSkin.MouseState.OUT;
            ChaosTab_CbCurrent.Name = "ChaosTab_CbCurrent";
            ChaosTab_CbCurrent.Size = new Size(167, 35);
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
            ChaosTab_LblCurrent.Size = new Size(201, 40);
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
            ChaosTab_LblPulseLarge.Location = new Point(3, 40);
            ChaosTab_LblPulseLarge.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_LblPulseLarge.Name = "ChaosTab_LblPulseLarge";
            ChaosTab_LblPulseLarge.Size = new Size(201, 40);
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
            ChaosTab_TxtPulseLength.Location = new Point(210, 43);
            ChaosTab_TxtPulseLength.MaxLength = 50;
            ChaosTab_TxtPulseLength.MouseState = MaterialSkin.MouseState.OUT;
            ChaosTab_TxtPulseLength.Multiline = false;
            ChaosTab_TxtPulseLength.Name = "ChaosTab_TxtPulseLength";
            ChaosTab_TxtPulseLength.Size = new Size(167, 36);
            ChaosTab_TxtPulseLength.TabIndex = 26;
            ChaosTab_TxtPulseLength.Text = "100";
            ChaosTab_TxtPulseLength.TrailingIcon = null;
            ChaosTab_TxtPulseLength.UseTallSize = false;
            ChaosTab_TxtPulseLength.Leave += ChaosTab_TxtPulseLength_Leave;
            // 
            // ChaosTab_btnLoadPulses
            // 
            ChaosTab_btnLoadPulses.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ChaosTab_btnLoadPulses.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChaosTab_btnLoadPulses.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ChaosTab_btnLoadPulses.Depth = 0;
            ChaosTab_btnLoadPulses.HighEmphasis = true;
            ChaosTab_btnLoadPulses.Icon = null;
            ChaosTab_btnLoadPulses.Location = new Point(4, 126);
            ChaosTab_btnLoadPulses.Margin = new Padding(4, 6, 4, 6);
            ChaosTab_btnLoadPulses.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_btnLoadPulses.Name = "ChaosTab_btnLoadPulses";
            ChaosTab_btnLoadPulses.NoAccentTextColor = Color.Empty;
            ChaosTab_btnLoadPulses.Size = new Size(199, 28);
            ChaosTab_btnLoadPulses.TabIndex = 23;
            ChaosTab_btnLoadPulses.Text = "Carregar Trens de Pulsos";
            ChaosTab_btnLoadPulses.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ChaosTab_btnLoadPulses.UseAccentColor = false;
            ChaosTab_btnLoadPulses.UseVisualStyleBackColor = true;
            ChaosTab_btnLoadPulses.Click += ChaosTab_LoadPulses_Click;
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
            ChaosTab_btnStartStimulus.Location = new Point(211, 166);
            ChaosTab_btnStartStimulus.Margin = new Padding(4, 6, 4, 6);
            ChaosTab_btnStartStimulus.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_btnStartStimulus.Name = "ChaosTab_btnStartStimulus";
            ChaosTab_btnStartStimulus.NoAccentTextColor = Color.Empty;
            ChaosTab_btnStartStimulus.Size = new Size(165, 25);
            ChaosTab_btnStartStimulus.TabIndex = 30;
            ChaosTab_btnStartStimulus.Text = "Começar Estimulação";
            ChaosTab_btnStartStimulus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ChaosTab_btnStartStimulus.UseAccentColor = false;
            ChaosTab_btnStartStimulus.UseVisualStyleBackColor = true;
            ChaosTab_btnStartStimulus.Click += ChaosTab_btnStartStimulus_Click;
            // 
            // ChaosTab_btnSendConfigToBoard
            // 
            ChaosTab_btnSendConfigToBoard.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ChaosTab_btnSendConfigToBoard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChaosTab_btnSendConfigToBoard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ChaosTab_btnSendConfigToBoard.Depth = 0;
            ChaosTab_btnSendConfigToBoard.Enabled = false;
            ChaosTab_btnSendConfigToBoard.HighEmphasis = true;
            ChaosTab_btnSendConfigToBoard.Icon = null;
            ChaosTab_btnSendConfigToBoard.Location = new Point(4, 166);
            ChaosTab_btnSendConfigToBoard.Margin = new Padding(4, 6, 4, 6);
            ChaosTab_btnSendConfigToBoard.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_btnSendConfigToBoard.Name = "ChaosTab_btnSendConfigToBoard";
            ChaosTab_btnSendConfigToBoard.NoAccentTextColor = Color.Empty;
            ChaosTab_btnSendConfigToBoard.Size = new Size(199, 25);
            ChaosTab_btnSendConfigToBoard.TabIndex = 8;
            ChaosTab_btnSendConfigToBoard.Text = "Enviar Config à placa";
            ChaosTab_btnSendConfigToBoard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ChaosTab_btnSendConfigToBoard.UseAccentColor = false;
            ChaosTab_btnSendConfigToBoard.UseVisualStyleBackColor = true;
            ChaosTab_btnSendConfigToBoard.Click += ChaosTab_SendConfigToBoard_Click;
            // 
            // ChaosTab_TxtInterpulseInterval
            // 
            ChaosTab_TxtInterpulseInterval.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ChaosTab_TxtInterpulseInterval.AnimateReadOnly = false;
            ChaosTab_TxtInterpulseInterval.BorderStyle = BorderStyle.None;
            ChaosTab_TxtInterpulseInterval.Depth = 0;
            ChaosTab_TxtInterpulseInterval.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChaosTab_TxtInterpulseInterval.LeadingIcon = null;
            ChaosTab_TxtInterpulseInterval.Location = new Point(210, 83);
            ChaosTab_TxtInterpulseInterval.MaxLength = 50;
            ChaosTab_TxtInterpulseInterval.MouseState = MaterialSkin.MouseState.OUT;
            ChaosTab_TxtInterpulseInterval.Multiline = false;
            ChaosTab_TxtInterpulseInterval.Name = "ChaosTab_TxtInterpulseInterval";
            ChaosTab_TxtInterpulseInterval.Size = new Size(167, 36);
            ChaosTab_TxtInterpulseInterval.TabIndex = 29;
            ChaosTab_TxtInterpulseInterval.Text = "50000";
            ChaosTab_TxtInterpulseInterval.TrailingIcon = null;
            ChaosTab_TxtInterpulseInterval.UseTallSize = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(ChaosTab_ChartPlotView_Train, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 200);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(780, 296);
            tableLayoutPanel5.TabIndex = 9;
            // 
            // ChaosTab_ChartPlotView_Train
            // 
            ChaosTab_ChartPlotView_Train.Dock = DockStyle.Fill;
            ChaosTab_ChartPlotView_Train.Location = new Point(3, 43);
            ChaosTab_ChartPlotView_Train.Name = "ChaosTab_ChartPlotView_Train";
            ChaosTab_ChartPlotView_Train.PanCursor = Cursors.Hand;
            ChaosTab_ChartPlotView_Train.Size = new Size(774, 250);
            ChaosTab_ChartPlotView_Train.TabIndex = 28;
            ChaosTab_ChartPlotView_Train.Text = "plotView1";
            ChaosTab_ChartPlotView_Train.ZoomHorizontalCursor = Cursors.SizeWE;
            ChaosTab_ChartPlotView_Train.ZoomRectangleCursor = Cursors.SizeNWSE;
            ChaosTab_ChartPlotView_Train.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(ChaosTab_LblInterval, 0, 0);
            tableLayoutPanel6.Controls.Add(ChaosTab_LblPulseTrain, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(774, 34);
            tableLayoutPanel6.TabIndex = 29;
            // 
            // ChaosTab_LblInterval
            // 
            ChaosTab_LblInterval.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ChaosTab_LblInterval.AutoSize = true;
            ChaosTab_LblInterval.BackColor = SystemColors.Control;
            ChaosTab_LblInterval.Depth = 0;
            ChaosTab_LblInterval.Enabled = false;
            ChaosTab_LblInterval.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ChaosTab_LblInterval.Location = new Point(549, 0);
            ChaosTab_LblInterval.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_LblInterval.Name = "ChaosTab_LblInterval";
            ChaosTab_LblInterval.Size = new Size(62, 34);
            ChaosTab_LblInterval.TabIndex = 27;
            ChaosTab_LblInterval.Text = "Intervalo";
            // 
            // ChaosTab_LblPulseTrain
            // 
            ChaosTab_LblPulseTrain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ChaosTab_LblPulseTrain.AutoSize = true;
            ChaosTab_LblPulseTrain.BackColor = SystemColors.Control;
            ChaosTab_LblPulseTrain.Depth = 0;
            ChaosTab_LblPulseTrain.Enabled = false;
            ChaosTab_LblPulseTrain.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ChaosTab_LblPulseTrain.Location = new Point(130, 0);
            ChaosTab_LblPulseTrain.MouseState = MaterialSkin.MouseState.HOVER;
            ChaosTab_LblPulseTrain.Name = "ChaosTab_LblPulseTrain";
            ChaosTab_LblPulseTrain.Size = new Size(127, 34);
            ChaosTab_LblPulseTrain.TabIndex = 26;
            ChaosTab_LblPulseTrain.Text = "Trem de pulsos: 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtReceivedData);
            groupBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(272, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 519);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados Recebidos";
            // 
            // txtReceivedData
            // 
            txtReceivedData.BackColor = Color.FromArgb(255, 255, 255);
            txtReceivedData.BorderStyle = BorderStyle.None;
            txtReceivedData.Depth = 0;
            txtReceivedData.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtReceivedData.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtReceivedData.Location = new Point(6, 31);
            txtReceivedData.MouseState = MaterialSkin.MouseState.HOVER;
            txtReceivedData.Name = "txtReceivedData";
            txtReceivedData.ReadOnly = true;
            txtReceivedData.Size = new Size(306, 481);
            txtReceivedData.TabIndex = 0;
            txtReceivedData.Text = "";
            txtReceivedData.TextChanged += TxtReceivedData_TextChanged;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDisconnect.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDisconnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDisconnect.Depth = 0;
            btnDisconnect.Enabled = false;
            btnDisconnect.HighEmphasis = true;
            btnDisconnect.Icon = null;
            btnDisconnect.Location = new Point(140, 480);
            btnDisconnect.Margin = new Padding(4, 6, 4, 6);
            btnDisconnect.MouseState = MaterialSkin.MouseState.HOVER;
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.NoAccentTextColor = Color.Empty;
            btnDisconnect.Size = new Size(125, 36);
            btnDisconnect.TabIndex = 23;
            btnDisconnect.Text = "Desconectar";
            btnDisconnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDisconnect.UseAccentColor = false;
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += BtnDisconnect_Click;
            // 
            // btnConnect
            // 
            btnConnect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConnect.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConnect.Depth = 0;
            btnConnect.HighEmphasis = true;
            btnConnect.Icon = null;
            btnConnect.Location = new Point(5, 480);
            btnConnect.Margin = new Padding(4, 6, 4, 6);
            btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            btnConnect.Name = "btnConnect";
            btnConnect.NoAccentTextColor = Color.Empty;
            btnConnect.Size = new Size(98, 36);
            btnConnect.TabIndex = 22;
            btnConnect.Text = "Conectar";
            btnConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConnect.UseAccentColor = false;
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += BtnConnect_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbHandShake);
            groupBox1.Controls.Add(cbStopBits);
            groupBox1.Controls.Add(cbParity);
            groupBox1.Controls.Add(txtDataBits);
            groupBox1.Controls.Add(materialLabel10);
            groupBox1.Controls.Add(txtWriteTimeOut);
            groupBox1.Controls.Add(txtReadTimeOut);
            groupBox1.Controls.Add(materialLabel9);
            groupBox1.Controls.Add(txtBaudRate);
            groupBox1.Controls.Add(materialLabel4);
            groupBox1.Controls.Add(materialLabel5);
            groupBox1.Controls.Add(materialLabel6);
            groupBox1.Controls.Add(materialLabel7);
            groupBox1.Controls.Add(materialLabel8);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(5, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 369);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parâmetros";
            // 
            // cbHandShake
            // 
            cbHandShake.AutoResize = false;
            cbHandShake.BackColor = Color.FromArgb(255, 255, 255);
            cbHandShake.Depth = 0;
            cbHandShake.DrawMode = DrawMode.OwnerDrawVariable;
            cbHandShake.DropDownHeight = 118;
            cbHandShake.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHandShake.DropDownWidth = 121;
            cbHandShake.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbHandShake.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbHandShake.FormattingEnabled = true;
            cbHandShake.IntegralHeight = false;
            cbHandShake.ItemHeight = 29;
            cbHandShake.Location = new Point(6, 326);
            cbHandShake.MaxDropDownItems = 4;
            cbHandShake.MouseState = MaterialSkin.MouseState.OUT;
            cbHandShake.Name = "cbHandShake";
            cbHandShake.Size = new Size(248, 35);
            cbHandShake.StartIndex = 0;
            cbHandShake.TabIndex = 23;
            cbHandShake.UseTallSize = false;
            // 
            // cbStopBits
            // 
            cbStopBits.AutoResize = false;
            cbStopBits.BackColor = Color.FromArgb(255, 255, 255);
            cbStopBits.Depth = 0;
            cbStopBits.DrawMode = DrawMode.OwnerDrawVariable;
            cbStopBits.DropDownHeight = 118;
            cbStopBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStopBits.DropDownWidth = 121;
            cbStopBits.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbStopBits.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbStopBits.FormattingEnabled = true;
            cbStopBits.IntegralHeight = false;
            cbStopBits.ItemHeight = 29;
            cbStopBits.Location = new Point(6, 258);
            cbStopBits.MaxDropDownItems = 4;
            cbStopBits.MouseState = MaterialSkin.MouseState.OUT;
            cbStopBits.Name = "cbStopBits";
            cbStopBits.Size = new Size(248, 35);
            cbStopBits.StartIndex = 0;
            cbStopBits.TabIndex = 22;
            cbStopBits.UseTallSize = false;
            // 
            // cbParity
            // 
            cbParity.AutoResize = false;
            cbParity.BackColor = Color.FromArgb(255, 255, 255);
            cbParity.Depth = 0;
            cbParity.DrawMode = DrawMode.OwnerDrawVariable;
            cbParity.DropDownHeight = 118;
            cbParity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbParity.DropDownWidth = 121;
            cbParity.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbParity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbParity.FormattingEnabled = true;
            cbParity.IntegralHeight = false;
            cbParity.ItemHeight = 29;
            cbParity.Location = new Point(6, 188);
            cbParity.MaxDropDownItems = 4;
            cbParity.MouseState = MaterialSkin.MouseState.OUT;
            cbParity.Name = "cbParity";
            cbParity.Size = new Size(248, 35);
            cbParity.StartIndex = 0;
            cbParity.TabIndex = 15;
            cbParity.UseTallSize = false;
            // 
            // txtDataBits
            // 
            txtDataBits.AnimateReadOnly = false;
            txtDataBits.BorderStyle = BorderStyle.None;
            txtDataBits.Depth = 0;
            txtDataBits.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataBits.LeadingIcon = null;
            txtDataBits.Location = new Point(144, 47);
            txtDataBits.MaxLength = 50;
            txtDataBits.MouseState = MaterialSkin.MouseState.OUT;
            txtDataBits.Multiline = false;
            txtDataBits.Name = "txtDataBits";
            txtDataBits.Size = new Size(110, 36);
            txtDataBits.TabIndex = 18;
            txtDataBits.Text = "";
            txtDataBits.TrailingIcon = null;
            txtDataBits.UseTallSize = false;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(6, 306);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(91, 19);
            materialLabel10.TabIndex = 14;
            materialLabel10.Text = "Hand Shake:";
            // 
            // txtWriteTimeOut
            // 
            txtWriteTimeOut.AnimateReadOnly = false;
            txtWriteTimeOut.BorderStyle = BorderStyle.None;
            txtWriteTimeOut.Depth = 0;
            txtWriteTimeOut.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtWriteTimeOut.LeadingIcon = null;
            txtWriteTimeOut.Location = new Point(144, 118);
            txtWriteTimeOut.MaxLength = 50;
            txtWriteTimeOut.MouseState = MaterialSkin.MouseState.OUT;
            txtWriteTimeOut.Multiline = false;
            txtWriteTimeOut.Name = "txtWriteTimeOut";
            txtWriteTimeOut.Size = new Size(110, 36);
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
            txtReadTimeOut.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtReadTimeOut.LeadingIcon = null;
            txtReadTimeOut.Location = new Point(6, 118);
            txtReadTimeOut.MaxLength = 50;
            txtReadTimeOut.MouseState = MaterialSkin.MouseState.OUT;
            txtReadTimeOut.Multiline = false;
            txtReadTimeOut.Name = "txtReadTimeOut";
            txtReadTimeOut.Size = new Size(110, 36);
            txtReadTimeOut.TabIndex = 16;
            txtReadTimeOut.Text = "";
            txtReadTimeOut.TrailingIcon = null;
            txtReadTimeOut.UseTallSize = false;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(6, 236);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(69, 19);
            materialLabel9.TabIndex = 13;
            materialLabel9.Text = "Stop Bits:";
            // 
            // txtBaudRate
            // 
            txtBaudRate.AnimateReadOnly = false;
            txtBaudRate.BorderStyle = BorderStyle.None;
            txtBaudRate.Depth = 0;
            txtBaudRate.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBaudRate.LeadingIcon = null;
            txtBaudRate.Location = new Point(6, 47);
            txtBaudRate.MaxLength = 50;
            txtBaudRate.MouseState = MaterialSkin.MouseState.OUT;
            txtBaudRate.Multiline = false;
            txtBaudRate.Name = "txtBaudRate";
            txtBaudRate.Size = new Size(110, 36);
            txtBaudRate.TabIndex = 15;
            txtBaudRate.Text = "";
            txtBaudRate.TrailingIcon = null;
            txtBaudRate.UseTallSize = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(6, 25);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(78, 19);
            materialLabel4.TabIndex = 8;
            materialLabel4.Text = "Baud Rate:";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(144, 25);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(70, 19);
            materialLabel5.TabIndex = 9;
            materialLabel5.Text = "Data Bits:";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(6, 96);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(110, 19);
            materialLabel6.TabIndex = 10;
            materialLabel6.Text = "Read Time Out:";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(144, 96);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(110, 19);
            materialLabel7.TabIndex = 11;
            materialLabel7.Text = "Write Time Out:";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(6, 166);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(46, 19);
            materialLabel8.TabIndex = 12;
            materialLabel8.Text = "Parity:";
            // 
            // switchDefaultParameters
            // 
            switchDefaultParameters.AutoSize = true;
            switchDefaultParameters.Checked = true;
            switchDefaultParameters.CheckState = CheckState.Checked;
            switchDefaultParameters.Depth = 0;
            switchDefaultParameters.Location = new Point(5, 65);
            switchDefaultParameters.Margin = new Padding(0);
            switchDefaultParameters.MouseLocation = new Point(-1, -1);
            switchDefaultParameters.MouseState = MaterialSkin.MouseState.HOVER;
            switchDefaultParameters.Name = "switchDefaultParameters";
            switchDefaultParameters.Ripple = true;
            switchDefaultParameters.Size = new Size(229, 37);
            switchDefaultParameters.TabIndex = 20;
            switchDefaultParameters.Text = "Usar parâmetros padrão";
            switchDefaultParameters.UseVisualStyleBackColor = true;
            switchDefaultParameters.CheckedChanged += SwitchDefaultParameters_CheckedChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(166, 23);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(99, 36);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Atualizar";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(5, 2);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(99, 19);
            materialLabel1.TabIndex = 18;
            materialLabel1.Text = "Portas Seriais";
            // 
            // cbComPortsList
            // 
            cbComPortsList.AutoResize = false;
            cbComPortsList.BackColor = Color.FromArgb(255, 255, 255);
            cbComPortsList.Depth = 0;
            cbComPortsList.DrawMode = DrawMode.OwnerDrawVariable;
            cbComPortsList.DropDownHeight = 118;
            cbComPortsList.DropDownStyle = ComboBoxStyle.DropDownList;
            cbComPortsList.DropDownWidth = 121;
            cbComPortsList.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbComPortsList.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbComPortsList.FormattingEnabled = true;
            cbComPortsList.IntegralHeight = false;
            cbComPortsList.ItemHeight = 29;
            cbComPortsList.Location = new Point(5, 24);
            cbComPortsList.MaxDropDownItems = 4;
            cbComPortsList.MouseState = MaterialSkin.MouseState.OUT;
            cbComPortsList.Name = "cbComPortsList";
            cbComPortsList.Size = new Size(154, 35);
            cbComPortsList.StartIndex = 0;
            cbComPortsList.TabIndex = 17;
            cbComPortsList.UseTallSize = false;
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
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            tabPeriodic.ResumeLayout(false);
            tbPanel_PeriodicTab.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            PeriodicTab_HeaderPanel.ResumeLayout(false);
            PeriodicTab_HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PeriodicTab_GridMain).EndInit();
            tabChaos.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ChaosTab_GridMain).EndInit();
            TbPanel_Chaos.ResumeLayout(false);
            TbPanel_Chaos.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private DataGridView PeriodicTab_GridMain;
        private OxyPlot.WindowsForms.PlotView PeriodicTab_ChartPlotView;
        private TabPage tabChaos;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel TbPanel_Chaos;
        private MaterialSkin.Controls.MaterialComboBox ChaosTab_CbCurrent;
        private MaterialSkin.Controls.MaterialButton ChaosTab_btnLoadPulses;
        private MaterialSkin.Controls.MaterialButton ChaosTab_btnSendConfigToBoard;
        private MaterialSkin.Controls.MaterialLabel ChaosTab_LblCurrent;
        private MaterialSkin.Controls.MaterialLabel ChaosTab_LblPulseLarge;
        private MaterialSkin.Controls.MaterialTextBox ChaosTab_TxtPulseLength;
        private DataGridView ChaosTab_GridMain;
        private MaterialSkin.Controls.MaterialLabel ChaosTab_LblInterpulseInterval;
        private MaterialSkin.Controls.MaterialTextBox ChaosTab_TxtInterpulseInterval;
        private TableLayoutPanel tableLayoutPanel5;
        private MaterialSkin.Controls.MaterialButton ChaosTab_btnStartStimulus;
        private OxyPlot.WindowsForms.PlotView ChaosTab_ChartPlotView_Train;
        private MaterialSkin.Controls.MaterialComboBox ChaosTab_CbPulseTrains;
        private TableLayoutPanel tableLayoutPanel6;
        private MaterialSkin.Controls.MaterialLabel ChaosTab_LblInterval;
        private MaterialSkin.Controls.MaterialLabel ChaosTab_LblPulseTrain;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}