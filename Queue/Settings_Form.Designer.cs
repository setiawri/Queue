namespace Queue
{
    partial class Settings_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_Form));
            this.btnUpdateCategories = new System.Windows.Forms.Button();
            this.btnCounterAddresses = new System.Windows.Forms.Button();
            this.gbRefreshInterval = new System.Windows.Forms.GroupBox();
            this.lblRefreshInterval = new System.Windows.Forms.Label();
            this.btnDecreaseRefreshInterval = new System.Windows.Forms.Button();
            this.btnIncreaseRefreshInterval = new System.Windows.Forms.Button();
            this.btnSaveDatabaseInfo = new System.Windows.Forms.Button();
            this.gbPrinterSettings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddPrintLine = new System.Windows.Forms.Button();
            this.btnTestPrinter = new System.Windows.Forms.Button();
            this.gridPrintLayout = new System.Windows.Forms.DataGridView();
            this.col_gridPrintLayout_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gridPrintLayout_delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_gridPrintLayout_LineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gridPrintLayout_Hide = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_gridPrintLayout_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gridPrintLayout_FontSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gridPrintLayout_TextAlign_enumid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gridPrintLayout_TextAlign_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSavePrinterSettings = new System.Windows.Forms.Button();
            this.lblRollingTextSpeed = new System.Windows.Forms.Label();
            this.txtRollingText = new System.Windows.Forms.TextBox();
            this.btnSaveRollingText = new System.Windows.Forms.Button();
            this.gbRollingText = new System.Windows.Forms.GroupBox();
            this.btnRollingTextSpeedDown = new System.Windows.Forms.Button();
            this.btnRollingTextSpeedUp = new System.Windows.Forms.Button();
            this.gbSpeed = new System.Windows.Forms.GroupBox();
            this.gbAdsFolder = new System.Windows.Forms.GroupBox();
            this.txtAdsFolder = new System.Windows.Forms.TextBox();
            this.gbInterval = new System.Windows.Forms.GroupBox();
            this.lblAdInterval = new System.Windows.Forms.Label();
            this.btnAdIntervalSpeedDown = new System.Windows.Forms.Button();
            this.btnAdIntervalSpeedUp = new System.Windows.Forms.Button();
            this.gbHeaderText = new System.Windows.Forms.GroupBox();
            this.btnSaveHeaderText = new System.Windows.Forms.Button();
            this.txtHeaderText = new System.Windows.Forms.TextBox();
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.gbQueueCutOffTime = new System.Windows.Forms.GroupBox();
            this.btnResetQueueNumber = new System.Windows.Forms.Button();
            this.lblQueueNoCutoffTimestamp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAutomaticQueueNoReset = new System.Windows.Forms.RadioButton();
            this.rbManualQueueNoReset = new System.Windows.Forms.RadioButton();
            this.tpData = new System.Windows.Forms.TabPage();
            this.btnHistory = new System.Windows.Forms.Button();
            this.tpPrinter = new System.Windows.Forms.TabPage();
            this.tpSounds = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTransitionSoundFilepath = new System.Windows.Forms.TextBox();
            this.chkNotificationSound = new System.Windows.Forms.CheckBox();
            this.chkCounter = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSoundFiles = new System.Windows.Forms.DataGridView();
            this.col_dgvSoundFiles_Filename = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_dgvSoundFiles_Filepath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSoundList = new System.Windows.Forms.Panel();
            this.btnLoadSoundFiles = new System.Windows.Forms.Button();
            this.txtSoundFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpDatabase = new System.Windows.Forms.TabPage();
            this.pnlLicense = new System.Windows.Forms.Panel();
            this.btnSubmitLicense = new System.Windows.Forms.Button();
            this.pnlDatabaseConnection = new System.Windows.Forms.Panel();
            this.scSound = new System.Windows.Forms.SplitContainer();
            this.in_AutomaticQueueNoResetHour = new LIBUtil.Desktop.UserControls.InputControl_Numeric();
            this.in_PrintAreaWidth = new LIBUtil.Desktop.UserControls.InputControl_Numeric();
            this.in_PrintQty = new LIBUtil.Desktop.UserControls.InputControl_Numeric();
            this.itxt_License = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_ServerName = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_DatabaseName = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.gbRefreshInterval.SuspendLayout();
            this.gbPrinterSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrintLayout)).BeginInit();
            this.gbRollingText.SuspendLayout();
            this.gbSpeed.SuspendLayout();
            this.gbAdsFolder.SuspendLayout();
            this.gbInterval.SuspendLayout();
            this.gbHeaderText.SuspendLayout();
            this.tcSettings.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.gbQueueCutOffTime.SuspendLayout();
            this.tpData.SuspendLayout();
            this.tpPrinter.SuspendLayout();
            this.tpSounds.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoundFiles)).BeginInit();
            this.pnlSoundList.SuspendLayout();
            this.tpDatabase.SuspendLayout();
            this.pnlLicense.SuspendLayout();
            this.pnlDatabaseConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSound)).BeginInit();
            this.scSound.Panel1.SuspendLayout();
            this.scSound.Panel2.SuspendLayout();
            this.scSound.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateCategories
            // 
            this.btnUpdateCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategories.Location = new System.Drawing.Point(178, 6);
            this.btnUpdateCategories.Name = "btnUpdateCategories";
            this.btnUpdateCategories.Size = new System.Drawing.Size(170, 56);
            this.btnUpdateCategories.TabIndex = 2;
            this.btnUpdateCategories.Text = "CATEGORIES";
            this.btnUpdateCategories.UseVisualStyleBackColor = true;
            this.btnUpdateCategories.Click += new System.EventHandler(this.btnUpdateCategories_Click);
            // 
            // btnCounterAddresses
            // 
            this.btnCounterAddresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCounterAddresses.Location = new System.Drawing.Point(6, 6);
            this.btnCounterAddresses.Name = "btnCounterAddresses";
            this.btnCounterAddresses.Size = new System.Drawing.Size(170, 56);
            this.btnCounterAddresses.TabIndex = 1;
            this.btnCounterAddresses.Text = "COUNTERS";
            this.btnCounterAddresses.UseVisualStyleBackColor = true;
            this.btnCounterAddresses.Click += new System.EventHandler(this.btnCounterAddresses_Click);
            // 
            // gbRefreshInterval
            // 
            this.gbRefreshInterval.Controls.Add(this.lblRefreshInterval);
            this.gbRefreshInterval.Controls.Add(this.btnDecreaseRefreshInterval);
            this.gbRefreshInterval.Controls.Add(this.btnIncreaseRefreshInterval);
            this.gbRefreshInterval.Location = new System.Drawing.Point(8, 136);
            this.gbRefreshInterval.Name = "gbRefreshInterval";
            this.gbRefreshInterval.Size = new System.Drawing.Size(141, 56);
            this.gbRefreshInterval.TabIndex = 5;
            this.gbRefreshInterval.TabStop = false;
            this.gbRefreshInterval.Text = "Data Refresh Interval (s)";
            // 
            // lblRefreshInterval
            // 
            this.lblRefreshInterval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRefreshInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefreshInterval.Location = new System.Drawing.Point(56, 21);
            this.lblRefreshInterval.Name = "lblRefreshInterval";
            this.lblRefreshInterval.Size = new System.Drawing.Size(30, 25);
            this.lblRefreshInterval.TabIndex = 20;
            this.lblRefreshInterval.Text = "X";
            this.lblRefreshInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDecreaseRefreshInterval
            // 
            this.btnDecreaseRefreshInterval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDecreaseRefreshInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseRefreshInterval.Location = new System.Drawing.Point(30, 21);
            this.btnDecreaseRefreshInterval.Name = "btnDecreaseRefreshInterval";
            this.btnDecreaseRefreshInterval.Size = new System.Drawing.Size(25, 25);
            this.btnDecreaseRefreshInterval.TabIndex = 22;
            this.btnDecreaseRefreshInterval.Text = "-";
            this.btnDecreaseRefreshInterval.UseVisualStyleBackColor = true;
            this.btnDecreaseRefreshInterval.Click += new System.EventHandler(this.btnDecreaseRefreshInterval_Click);
            // 
            // btnIncreaseRefreshInterval
            // 
            this.btnIncreaseRefreshInterval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIncreaseRefreshInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseRefreshInterval.Location = new System.Drawing.Point(85, 21);
            this.btnIncreaseRefreshInterval.Name = "btnIncreaseRefreshInterval";
            this.btnIncreaseRefreshInterval.Size = new System.Drawing.Size(25, 25);
            this.btnIncreaseRefreshInterval.TabIndex = 21;
            this.btnIncreaseRefreshInterval.Text = "+";
            this.btnIncreaseRefreshInterval.UseVisualStyleBackColor = true;
            this.btnIncreaseRefreshInterval.Click += new System.EventHandler(this.btnIncreaseRefreshInterval_Click);
            // 
            // btnSaveDatabaseInfo
            // 
            this.btnSaveDatabaseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDatabaseInfo.Location = new System.Drawing.Point(68, 85);
            this.btnSaveDatabaseInfo.Name = "btnSaveDatabaseInfo";
            this.btnSaveDatabaseInfo.Size = new System.Drawing.Size(64, 26);
            this.btnSaveDatabaseInfo.TabIndex = 2;
            this.btnSaveDatabaseInfo.Text = "SAVE";
            this.btnSaveDatabaseInfo.UseVisualStyleBackColor = true;
            this.btnSaveDatabaseInfo.Click += new System.EventHandler(this.btnSaveDatabaseInfo_Click);
            // 
            // gbPrinterSettings
            // 
            this.gbPrinterSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPrinterSettings.Controls.Add(this.in_PrintAreaWidth);
            this.gbPrinterSettings.Controls.Add(this.in_PrintQty);
            this.gbPrinterSettings.Controls.Add(this.label4);
            this.gbPrinterSettings.Controls.Add(this.btnAddPrintLine);
            this.gbPrinterSettings.Controls.Add(this.btnTestPrinter);
            this.gbPrinterSettings.Controls.Add(this.gridPrintLayout);
            this.gbPrinterSettings.Controls.Add(this.btnSavePrinterSettings);
            this.gbPrinterSettings.Location = new System.Drawing.Point(3, 3);
            this.gbPrinterSettings.Name = "gbPrinterSettings";
            this.gbPrinterSettings.Size = new System.Drawing.Size(348, 305);
            this.gbPrinterSettings.TabIndex = 7;
            this.gbPrinterSettings.TabStop = false;
            this.gbPrinterSettings.Text = "Printer Settings";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "{no}: no antrian, {day}: Monday, {date}: 31/01/17, {time}: 15:20\r\n";
            // 
            // btnAddPrintLine
            // 
            this.btnAddPrintLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPrintLine.Location = new System.Drawing.Point(6, 258);
            this.btnAddPrintLine.Name = "btnAddPrintLine";
            this.btnAddPrintLine.Size = new System.Drawing.Size(46, 41);
            this.btnAddPrintLine.TabIndex = 9;
            this.btnAddPrintLine.Text = "ADD LINE";
            this.btnAddPrintLine.UseVisualStyleBackColor = true;
            this.btnAddPrintLine.Click += new System.EventHandler(this.btnAddPrintLine_Click);
            // 
            // btnTestPrinter
            // 
            this.btnTestPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestPrinter.Location = new System.Drawing.Point(287, 258);
            this.btnTestPrinter.Name = "btnTestPrinter";
            this.btnTestPrinter.Size = new System.Drawing.Size(55, 41);
            this.btnTestPrinter.TabIndex = 2;
            this.btnTestPrinter.Text = "TEST PRINT";
            this.btnTestPrinter.UseVisualStyleBackColor = true;
            this.btnTestPrinter.Click += new System.EventHandler(this.btnTestPrinter_Click);
            // 
            // gridPrintLayout
            // 
            this.gridPrintLayout.AllowUserToAddRows = false;
            this.gridPrintLayout.AllowUserToDeleteRows = false;
            this.gridPrintLayout.AllowUserToResizeColumns = false;
            this.gridPrintLayout.AllowUserToResizeRows = false;
            this.gridPrintLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPrintLayout.BackgroundColor = System.Drawing.Color.White;
            this.gridPrintLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrintLayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_gridPrintLayout_Id,
            this.col_gridPrintLayout_delete,
            this.col_gridPrintLayout_LineNumber,
            this.col_gridPrintLayout_Hide,
            this.col_gridPrintLayout_Text,
            this.col_gridPrintLayout_FontSize,
            this.col_gridPrintLayout_TextAlign_enumid,
            this.col_gridPrintLayout_TextAlign_description});
            this.gridPrintLayout.Location = new System.Drawing.Point(6, 32);
            this.gridPrintLayout.Name = "gridPrintLayout";
            this.gridPrintLayout.RowHeadersVisible = false;
            this.gridPrintLayout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPrintLayout.Size = new System.Drawing.Size(336, 221);
            this.gridPrintLayout.TabIndex = 1;
            this.gridPrintLayout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPrintLayout_CellContentClick);
            this.gridPrintLayout.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPrintLayout_CellMouseDown);
            this.gridPrintLayout.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridPrintLayout_DataError);
            // 
            // col_gridPrintLayout_Id
            // 
            this.col_gridPrintLayout_Id.HeaderText = "Id";
            this.col_gridPrintLayout_Id.Name = "col_gridPrintLayout_Id";
            this.col_gridPrintLayout_Id.Visible = false;
            // 
            // col_gridPrintLayout_delete
            // 
            this.col_gridPrintLayout_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_gridPrintLayout_delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_gridPrintLayout_delete.HeaderText = "";
            this.col_gridPrintLayout_delete.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.col_gridPrintLayout_delete.LinkColor = System.Drawing.Color.Red;
            this.col_gridPrintLayout_delete.MinimumWidth = 20;
            this.col_gridPrintLayout_delete.Name = "col_gridPrintLayout_delete";
            this.col_gridPrintLayout_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_gridPrintLayout_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_gridPrintLayout_delete.Text = "X";
            this.col_gridPrintLayout_delete.UseColumnTextForLinkValue = true;
            this.col_gridPrintLayout_delete.VisitedLinkColor = System.Drawing.Color.Red;
            this.col_gridPrintLayout_delete.Width = 20;
            // 
            // col_gridPrintLayout_LineNumber
            // 
            this.col_gridPrintLayout_LineNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_gridPrintLayout_LineNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_gridPrintLayout_LineNumber.HeaderText = "Line";
            this.col_gridPrintLayout_LineNumber.MinimumWidth = 30;
            this.col_gridPrintLayout_LineNumber.Name = "col_gridPrintLayout_LineNumber";
            this.col_gridPrintLayout_LineNumber.ReadOnly = true;
            this.col_gridPrintLayout_LineNumber.Width = 30;
            // 
            // col_gridPrintLayout_Hide
            // 
            this.col_gridPrintLayout_Hide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_gridPrintLayout_Hide.HeaderText = "Hide";
            this.col_gridPrintLayout_Hide.MinimumWidth = 30;
            this.col_gridPrintLayout_Hide.Name = "col_gridPrintLayout_Hide";
            this.col_gridPrintLayout_Hide.Width = 30;
            // 
            // col_gridPrintLayout_Text
            // 
            this.col_gridPrintLayout_Text.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_gridPrintLayout_Text.HeaderText = "Text";
            this.col_gridPrintLayout_Text.Name = "col_gridPrintLayout_Text";
            // 
            // col_gridPrintLayout_FontSize
            // 
            this.col_gridPrintLayout_FontSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_gridPrintLayout_FontSize.HeaderText = "Font";
            this.col_gridPrintLayout_FontSize.MinimumWidth = 30;
            this.col_gridPrintLayout_FontSize.Name = "col_gridPrintLayout_FontSize";
            this.col_gridPrintLayout_FontSize.Width = 30;
            // 
            // col_gridPrintLayout_TextAlign_enumid
            // 
            this.col_gridPrintLayout_TextAlign_enumid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_gridPrintLayout_TextAlign_enumid.HeaderText = "Align Enum ID";
            this.col_gridPrintLayout_TextAlign_enumid.MinimumWidth = 40;
            this.col_gridPrintLayout_TextAlign_enumid.Name = "col_gridPrintLayout_TextAlign_enumid";
            this.col_gridPrintLayout_TextAlign_enumid.Visible = false;
            this.col_gridPrintLayout_TextAlign_enumid.Width = 40;
            // 
            // col_gridPrintLayout_TextAlign_description
            // 
            this.col_gridPrintLayout_TextAlign_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_gridPrintLayout_TextAlign_description.HeaderText = "Align";
            this.col_gridPrintLayout_TextAlign_description.MinimumWidth = 40;
            this.col_gridPrintLayout_TextAlign_description.Name = "col_gridPrintLayout_TextAlign_description";
            this.col_gridPrintLayout_TextAlign_description.ReadOnly = true;
            this.col_gridPrintLayout_TextAlign_description.Width = 40;
            // 
            // btnSavePrinterSettings
            // 
            this.btnSavePrinterSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePrinterSettings.Location = new System.Drawing.Point(220, 258);
            this.btnSavePrinterSettings.Name = "btnSavePrinterSettings";
            this.btnSavePrinterSettings.Size = new System.Drawing.Size(61, 41);
            this.btnSavePrinterSettings.TabIndex = 0;
            this.btnSavePrinterSettings.Text = "SAVE";
            this.btnSavePrinterSettings.UseVisualStyleBackColor = true;
            this.btnSavePrinterSettings.Click += new System.EventHandler(this.btnSavePrinterSettings_Click);
            // 
            // lblRollingTextSpeed
            // 
            this.lblRollingTextSpeed.Location = new System.Drawing.Point(29, 20);
            this.lblRollingTextSpeed.Name = "lblRollingTextSpeed";
            this.lblRollingTextSpeed.Size = new System.Drawing.Size(12, 13);
            this.lblRollingTextSpeed.TabIndex = 16;
            this.lblRollingTextSpeed.Text = "X";
            this.lblRollingTextSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRollingText
            // 
            this.txtRollingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRollingText.Location = new System.Drawing.Point(2, 15);
            this.txtRollingText.Name = "txtRollingText";
            this.txtRollingText.Size = new System.Drawing.Size(211, 20);
            this.txtRollingText.TabIndex = 14;
            this.txtRollingText.MouseLeave += new System.EventHandler(this.txtRollingText_MouseLeave);
            this.txtRollingText.MouseHover += new System.EventHandler(this.txtRollingText_MouseHover);
            // 
            // btnSaveRollingText
            // 
            this.btnSaveRollingText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveRollingText.Location = new System.Drawing.Point(213, 14);
            this.btnSaveRollingText.Name = "btnSaveRollingText";
            this.btnSaveRollingText.Size = new System.Drawing.Size(49, 22);
            this.btnSaveRollingText.TabIndex = 15;
            this.btnSaveRollingText.Text = "SAVE";
            this.btnSaveRollingText.UseVisualStyleBackColor = true;
            this.btnSaveRollingText.Click += new System.EventHandler(this.btnSaveRollingText_Click);
            // 
            // gbRollingText
            // 
            this.gbRollingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRollingText.Controls.Add(this.btnSaveRollingText);
            this.gbRollingText.Controls.Add(this.txtRollingText);
            this.gbRollingText.Location = new System.Drawing.Point(6, 49);
            this.gbRollingText.Name = "gbRollingText";
            this.gbRollingText.Size = new System.Drawing.Size(264, 40);
            this.gbRollingText.TabIndex = 13;
            this.gbRollingText.TabStop = false;
            this.gbRollingText.Text = "Rolling Text";
            // 
            // btnRollingTextSpeedDown
            // 
            this.btnRollingTextSpeedDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollingTextSpeedDown.Location = new System.Drawing.Point(6, 16);
            this.btnRollingTextSpeedDown.Name = "btnRollingTextSpeedDown";
            this.btnRollingTextSpeedDown.Size = new System.Drawing.Size(20, 20);
            this.btnRollingTextSpeedDown.TabIndex = 19;
            this.btnRollingTextSpeedDown.Text = "-";
            this.btnRollingTextSpeedDown.UseVisualStyleBackColor = true;
            this.btnRollingTextSpeedDown.Click += new System.EventHandler(this.btnRollingTextSpeedDown_Click);
            // 
            // btnRollingTextSpeedUp
            // 
            this.btnRollingTextSpeedUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollingTextSpeedUp.Location = new System.Drawing.Point(44, 16);
            this.btnRollingTextSpeedUp.Name = "btnRollingTextSpeedUp";
            this.btnRollingTextSpeedUp.Size = new System.Drawing.Size(20, 20);
            this.btnRollingTextSpeedUp.TabIndex = 18;
            this.btnRollingTextSpeedUp.Text = "+";
            this.btnRollingTextSpeedUp.UseVisualStyleBackColor = true;
            this.btnRollingTextSpeedUp.Click += new System.EventHandler(this.btnRollingTextSpeedUp_Click);
            // 
            // gbSpeed
            // 
            this.gbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSpeed.Controls.Add(this.lblRollingTextSpeed);
            this.gbSpeed.Controls.Add(this.btnRollingTextSpeedDown);
            this.gbSpeed.Controls.Add(this.btnRollingTextSpeedUp);
            this.gbSpeed.Location = new System.Drawing.Point(276, 49);
            this.gbSpeed.Name = "gbSpeed";
            this.gbSpeed.Size = new System.Drawing.Size(70, 40);
            this.gbSpeed.TabIndex = 14;
            this.gbSpeed.TabStop = false;
            this.gbSpeed.Text = "Speed";
            // 
            // gbAdsFolder
            // 
            this.gbAdsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAdsFolder.Controls.Add(this.txtAdsFolder);
            this.gbAdsFolder.Location = new System.Drawing.Point(6, 90);
            this.gbAdsFolder.Name = "gbAdsFolder";
            this.gbAdsFolder.Size = new System.Drawing.Size(264, 40);
            this.gbAdsFolder.TabIndex = 15;
            this.gbAdsFolder.TabStop = false;
            this.gbAdsFolder.Text = "Ad Folder";
            // 
            // txtAdsFolder
            // 
            this.txtAdsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdsFolder.Location = new System.Drawing.Point(2, 15);
            this.txtAdsFolder.Name = "txtAdsFolder";
            this.txtAdsFolder.Size = new System.Drawing.Size(260, 20);
            this.txtAdsFolder.TabIndex = 14;
            this.txtAdsFolder.Click += new System.EventHandler(this.txtAdsFolder_Click);
            // 
            // gbInterval
            // 
            this.gbInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInterval.Controls.Add(this.lblAdInterval);
            this.gbInterval.Controls.Add(this.btnAdIntervalSpeedDown);
            this.gbInterval.Controls.Add(this.btnAdIntervalSpeedUp);
            this.gbInterval.Location = new System.Drawing.Point(276, 90);
            this.gbInterval.Name = "gbInterval";
            this.gbInterval.Size = new System.Drawing.Size(70, 40);
            this.gbInterval.TabIndex = 20;
            this.gbInterval.TabStop = false;
            this.gbInterval.Text = "Interval (s)";
            // 
            // lblAdInterval
            // 
            this.lblAdInterval.Location = new System.Drawing.Point(29, 20);
            this.lblAdInterval.Name = "lblAdInterval";
            this.lblAdInterval.Size = new System.Drawing.Size(12, 13);
            this.lblAdInterval.TabIndex = 16;
            this.lblAdInterval.Text = "X";
            this.lblAdInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdIntervalSpeedDown
            // 
            this.btnAdIntervalSpeedDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdIntervalSpeedDown.Location = new System.Drawing.Point(6, 16);
            this.btnAdIntervalSpeedDown.Name = "btnAdIntervalSpeedDown";
            this.btnAdIntervalSpeedDown.Size = new System.Drawing.Size(20, 20);
            this.btnAdIntervalSpeedDown.TabIndex = 19;
            this.btnAdIntervalSpeedDown.Text = "-";
            this.btnAdIntervalSpeedDown.UseVisualStyleBackColor = true;
            this.btnAdIntervalSpeedDown.Click += new System.EventHandler(this.btnAdIntervalSpeedDown_Click);
            // 
            // btnAdIntervalSpeedUp
            // 
            this.btnAdIntervalSpeedUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdIntervalSpeedUp.Location = new System.Drawing.Point(44, 16);
            this.btnAdIntervalSpeedUp.Name = "btnAdIntervalSpeedUp";
            this.btnAdIntervalSpeedUp.Size = new System.Drawing.Size(20, 20);
            this.btnAdIntervalSpeedUp.TabIndex = 18;
            this.btnAdIntervalSpeedUp.Text = "+";
            this.btnAdIntervalSpeedUp.UseVisualStyleBackColor = true;
            this.btnAdIntervalSpeedUp.Click += new System.EventHandler(this.btnAdIntervalSpeedUp_Click);
            // 
            // gbHeaderText
            // 
            this.gbHeaderText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHeaderText.Controls.Add(this.btnSaveHeaderText);
            this.gbHeaderText.Controls.Add(this.txtHeaderText);
            this.gbHeaderText.Location = new System.Drawing.Point(6, 6);
            this.gbHeaderText.Name = "gbHeaderText";
            this.gbHeaderText.Size = new System.Drawing.Size(340, 40);
            this.gbHeaderText.TabIndex = 16;
            this.gbHeaderText.TabStop = false;
            this.gbHeaderText.Text = "Header Text";
            // 
            // btnSaveHeaderText
            // 
            this.btnSaveHeaderText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveHeaderText.Location = new System.Drawing.Point(295, 15);
            this.btnSaveHeaderText.Name = "btnSaveHeaderText";
            this.btnSaveHeaderText.Size = new System.Drawing.Size(43, 20);
            this.btnSaveHeaderText.TabIndex = 15;
            this.btnSaveHeaderText.Text = "SAVE";
            this.btnSaveHeaderText.UseVisualStyleBackColor = true;
            this.btnSaveHeaderText.Click += new System.EventHandler(this.btnSaveHeaderText_Click);
            // 
            // txtHeaderText
            // 
            this.txtHeaderText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeaderText.Location = new System.Drawing.Point(2, 15);
            this.txtHeaderText.Name = "txtHeaderText";
            this.txtHeaderText.Size = new System.Drawing.Size(292, 20);
            this.txtHeaderText.TabIndex = 14;
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tpGeneral);
            this.tcSettings.Controls.Add(this.tpData);
            this.tcSettings.Controls.Add(this.tpPrinter);
            this.tcSettings.Controls.Add(this.tpSounds);
            this.tcSettings.Controls.Add(this.tpDatabase);
            this.tcSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSettings.Location = new System.Drawing.Point(0, 0);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(362, 337);
            this.tcSettings.TabIndex = 21;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.gbQueueCutOffTime);
            this.tpGeneral.Controls.Add(this.gbHeaderText);
            this.tpGeneral.Controls.Add(this.gbRollingText);
            this.tpGeneral.Controls.Add(this.gbInterval);
            this.tpGeneral.Controls.Add(this.gbRefreshInterval);
            this.tpGeneral.Controls.Add(this.gbSpeed);
            this.tpGeneral.Controls.Add(this.gbAdsFolder);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(354, 311);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // gbQueueCutOffTime
            // 
            this.gbQueueCutOffTime.Controls.Add(this.btnResetQueueNumber);
            this.gbQueueCutOffTime.Controls.Add(this.lblQueueNoCutoffTimestamp);
            this.gbQueueCutOffTime.Controls.Add(this.label2);
            this.gbQueueCutOffTime.Controls.Add(this.in_AutomaticQueueNoResetHour);
            this.gbQueueCutOffTime.Controls.Add(this.rbAutomaticQueueNoReset);
            this.gbQueueCutOffTime.Controls.Add(this.rbManualQueueNoReset);
            this.gbQueueCutOffTime.Location = new System.Drawing.Point(8, 198);
            this.gbQueueCutOffTime.Name = "gbQueueCutOffTime";
            this.gbQueueCutOffTime.Size = new System.Drawing.Size(338, 87);
            this.gbQueueCutOffTime.TabIndex = 21;
            this.gbQueueCutOffTime.TabStop = false;
            this.gbQueueCutOffTime.Text = "Queue Number Reset";
            // 
            // btnResetQueueNumber
            // 
            this.btnResetQueueNumber.Location = new System.Drawing.Point(234, 43);
            this.btnResetQueueNumber.Name = "btnResetQueueNumber";
            this.btnResetQueueNumber.Size = new System.Drawing.Size(75, 23);
            this.btnResetQueueNumber.TabIndex = 26;
            this.btnResetQueueNumber.Text = "RESET";
            this.btnResetQueueNumber.UseVisualStyleBackColor = true;
            this.btnResetQueueNumber.Click += new System.EventHandler(this.btnResetQueueNumber_Click);
            // 
            // lblQueueNoCutoffTimestamp
            // 
            this.lblQueueNoCutoffTimestamp.AutoSize = true;
            this.lblQueueNoCutoffTimestamp.Location = new System.Drawing.Point(6, 66);
            this.lblQueueNoCutoffTimestamp.Name = "lblQueueNoCutoffTimestamp";
            this.lblQueueNoCutoffTimestamp.Size = new System.Drawing.Size(142, 13);
            this.lblQueueNoCutoffTimestamp.TabIndex = 25;
            this.lblQueueNoCutoffTimestamp.Text = "lblQueueNoCutoffTimestamp";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "WARNING! Nomor antrian akan di VOID sesuai perubahan pada setting ini! Reset berj" +
    "alan saat tiket antrian di print.";
            // 
            // rbAutomaticQueueNoReset
            // 
            this.rbAutomaticQueueNoReset.AutoSize = true;
            this.rbAutomaticQueueNoReset.Location = new System.Drawing.Point(75, 46);
            this.rbAutomaticQueueNoReset.Name = "rbAutomaticQueueNoReset";
            this.rbAutomaticQueueNoReset.Size = new System.Drawing.Size(111, 17);
            this.rbAutomaticQueueNoReset.TabIndex = 23;
            this.rbAutomaticQueueNoReset.TabStop = true;
            this.rbAutomaticQueueNoReset.Text = "Automatic at hour:";
            this.rbAutomaticQueueNoReset.UseVisualStyleBackColor = true;
            this.rbAutomaticQueueNoReset.CheckedChanged += new System.EventHandler(this.QueueNoReset_Changed);
            // 
            // rbManualQueueNoReset
            // 
            this.rbManualQueueNoReset.AutoSize = true;
            this.rbManualQueueNoReset.Location = new System.Drawing.Point(9, 46);
            this.rbManualQueueNoReset.Name = "rbManualQueueNoReset";
            this.rbManualQueueNoReset.Size = new System.Drawing.Size(60, 17);
            this.rbManualQueueNoReset.TabIndex = 22;
            this.rbManualQueueNoReset.TabStop = true;
            this.rbManualQueueNoReset.Text = "Manual";
            this.rbManualQueueNoReset.UseVisualStyleBackColor = true;
            this.rbManualQueueNoReset.CheckedChanged += new System.EventHandler(this.QueueNoReset_Changed);
            // 
            // tpData
            // 
            this.tpData.Controls.Add(this.btnHistory);
            this.tpData.Controls.Add(this.btnCounterAddresses);
            this.tpData.Controls.Add(this.btnUpdateCategories);
            this.tpData.Location = new System.Drawing.Point(4, 22);
            this.tpData.Name = "tpData";
            this.tpData.Padding = new System.Windows.Forms.Padding(3);
            this.tpData.Size = new System.Drawing.Size(354, 311);
            this.tpData.TabIndex = 1;
            this.tpData.Text = "DATA";
            this.tpData.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(6, 68);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(170, 56);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "HISTORY";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // tpPrinter
            // 
            this.tpPrinter.Controls.Add(this.gbPrinterSettings);
            this.tpPrinter.Location = new System.Drawing.Point(4, 22);
            this.tpPrinter.Name = "tpPrinter";
            this.tpPrinter.Size = new System.Drawing.Size(354, 311);
            this.tpPrinter.TabIndex = 3;
            this.tpPrinter.Text = "Printer";
            this.tpPrinter.UseVisualStyleBackColor = true;
            // 
            // tpSounds
            // 
            this.tpSounds.Controls.Add(this.groupBox2);
            this.tpSounds.Controls.Add(this.chkNotificationSound);
            this.tpSounds.Controls.Add(this.chkCounter);
            this.tpSounds.Controls.Add(this.groupBox1);
            this.tpSounds.Location = new System.Drawing.Point(4, 22);
            this.tpSounds.Name = "tpSounds";
            this.tpSounds.Size = new System.Drawing.Size(354, 311);
            this.tpSounds.TabIndex = 4;
            this.tpSounds.Text = "Sounds";
            this.tpSounds.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtTransitionSoundFilepath);
            this.groupBox2.Location = new System.Drawing.Point(8, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(338, 40);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sound file untuk transisi ke counter";
            // 
            // txtTransitionSoundFilepath
            // 
            this.txtTransitionSoundFilepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransitionSoundFilepath.Location = new System.Drawing.Point(5, 15);
            this.txtTransitionSoundFilepath.Name = "txtTransitionSoundFilepath";
            this.txtTransitionSoundFilepath.Size = new System.Drawing.Size(328, 20);
            this.txtTransitionSoundFilepath.TabIndex = 14;
            this.txtTransitionSoundFilepath.Click += new System.EventHandler(this.txtFilepathForTransitionSound_Click);
            // 
            // chkNotificationSound
            // 
            this.chkNotificationSound.AutoSize = true;
            this.chkNotificationSound.Location = new System.Drawing.Point(8, 3);
            this.chkNotificationSound.Name = "chkNotificationSound";
            this.chkNotificationSound.Size = new System.Drawing.Size(113, 17);
            this.chkNotificationSound.TabIndex = 0;
            this.chkNotificationSound.Text = "Notification Sound";
            this.chkNotificationSound.UseVisualStyleBackColor = true;
            this.chkNotificationSound.CheckedChanged += new System.EventHandler(this.ChkNotificationSound_CheckedChanged);
            // 
            // chkCounter
            // 
            this.chkCounter.AutoSize = true;
            this.chkCounter.Location = new System.Drawing.Point(127, 3);
            this.chkCounter.Name = "chkCounter";
            this.chkCounter.Size = new System.Drawing.Size(63, 17);
            this.chkCounter.TabIndex = 4;
            this.chkCounter.Text = "Counter";
            this.chkCounter.UseVisualStyleBackColor = true;
            this.chkCounter.CheckedChanged += new System.EventHandler(this.ChkCounter_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.scSound);
            this.groupBox1.Location = new System.Drawing.Point(8, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(338, 242);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sound Folder";
            // 
            // dgvSoundFiles
            // 
            this.dgvSoundFiles.AllowUserToAddRows = false;
            this.dgvSoundFiles.AllowUserToDeleteRows = false;
            this.dgvSoundFiles.AllowUserToResizeColumns = false;
            this.dgvSoundFiles.AllowUserToResizeRows = false;
            this.dgvSoundFiles.BackgroundColor = System.Drawing.Color.White;
            this.dgvSoundFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoundFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvSoundFiles_Filename,
            this.col_dgvSoundFiles_Filepath});
            this.dgvSoundFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoundFiles.Location = new System.Drawing.Point(0, 36);
            this.dgvSoundFiles.Name = "dgvSoundFiles";
            this.dgvSoundFiles.RowHeadersVisible = false;
            this.dgvSoundFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoundFiles.Size = new System.Drawing.Size(326, 162);
            this.dgvSoundFiles.TabIndex = 17;
            this.dgvSoundFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSoundFiles_CellContentClick);
            // 
            // col_dgvSoundFiles_Filename
            // 
            this.col_dgvSoundFiles_Filename.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.col_dgvSoundFiles_Filename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_dgvSoundFiles_Filename.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_dgvSoundFiles_Filename.HeaderText = "Filename";
            this.col_dgvSoundFiles_Filename.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.col_dgvSoundFiles_Filename.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.col_dgvSoundFiles_Filename.Name = "col_dgvSoundFiles_Filename";
            this.col_dgvSoundFiles_Filename.ReadOnly = true;
            this.col_dgvSoundFiles_Filename.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_dgvSoundFiles_Filename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_dgvSoundFiles_Filename.VisitedLinkColor = System.Drawing.Color.CornflowerBlue;
            // 
            // col_dgvSoundFiles_Filepath
            // 
            this.col_dgvSoundFiles_Filepath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvSoundFiles_Filepath.HeaderText = "Path";
            this.col_dgvSoundFiles_Filepath.Name = "col_dgvSoundFiles_Filepath";
            this.col_dgvSoundFiles_Filepath.Visible = false;
            this.col_dgvSoundFiles_Filepath.Width = 5;
            // 
            // pnlSoundList
            // 
            this.pnlSoundList.Controls.Add(this.btnLoadSoundFiles);
            this.pnlSoundList.Controls.Add(this.label1);
            this.pnlSoundList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSoundList.Location = new System.Drawing.Point(0, 0);
            this.pnlSoundList.Name = "pnlSoundList";
            this.pnlSoundList.Size = new System.Drawing.Size(326, 36);
            this.pnlSoundList.TabIndex = 16;
            // 
            // btnLoadSoundFiles
            // 
            this.btnLoadSoundFiles.Location = new System.Drawing.Point(-1, 3);
            this.btnLoadSoundFiles.Name = "btnLoadSoundFiles";
            this.btnLoadSoundFiles.Size = new System.Drawing.Size(45, 30);
            this.btnLoadSoundFiles.TabIndex = 16;
            this.btnLoadSoundFiles.Text = "LOAD";
            this.btnLoadSoundFiles.UseVisualStyleBackColor = true;
            this.btnLoadSoundFiles.Click += new System.EventHandler(this.BtnLoadSoundFiles_Click);
            // 
            // txtSoundFolder
            // 
            this.txtSoundFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSoundFolder.Location = new System.Drawing.Point(0, 0);
            this.txtSoundFolder.Name = "txtSoundFolder";
            this.txtSoundFolder.Size = new System.Drawing.Size(326, 20);
            this.txtSoundFolder.TabIndex = 14;
            this.txtSoundFolder.Click += new System.EventHandler(this.txtSoundFolder_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(42, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Penamaan file sesuai suara. Contoh: 1.wav, 2.wav, A.wav, B.wav, Counter 1.wav, Ka" +
    "sir.wav, etc.";
            // 
            // tpDatabase
            // 
            this.tpDatabase.Controls.Add(this.pnlLicense);
            this.tpDatabase.Controls.Add(this.pnlDatabaseConnection);
            this.tpDatabase.Location = new System.Drawing.Point(4, 22);
            this.tpDatabase.Name = "tpDatabase";
            this.tpDatabase.Size = new System.Drawing.Size(354, 311);
            this.tpDatabase.TabIndex = 2;
            this.tpDatabase.Text = "Database";
            this.tpDatabase.UseVisualStyleBackColor = true;
            // 
            // pnlLicense
            // 
            this.pnlLicense.Controls.Add(this.itxt_License);
            this.pnlLicense.Controls.Add(this.btnSubmitLicense);
            this.pnlLicense.Location = new System.Drawing.Point(60, 11);
            this.pnlLicense.Name = "pnlLicense";
            this.pnlLicense.Size = new System.Drawing.Size(234, 52);
            this.pnlLicense.TabIndex = 2;
            this.pnlLicense.Visible = false;
            // 
            // btnSubmitLicense
            // 
            this.btnSubmitLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitLicense.Location = new System.Drawing.Point(146, 8);
            this.btnSubmitLicense.Name = "btnSubmitLicense";
            this.btnSubmitLicense.Size = new System.Drawing.Size(81, 38);
            this.btnSubmitLicense.TabIndex = 1;
            this.btnSubmitLicense.Text = "SUBMIT";
            this.btnSubmitLicense.UseVisualStyleBackColor = true;
            this.btnSubmitLicense.Click += new System.EventHandler(this.BtnSaveLicense_Click);
            // 
            // pnlDatabaseConnection
            // 
            this.pnlDatabaseConnection.Controls.Add(this.itxt_ServerName);
            this.pnlDatabaseConnection.Controls.Add(this.itxt_DatabaseName);
            this.pnlDatabaseConnection.Controls.Add(this.btnSaveDatabaseInfo);
            this.pnlDatabaseConnection.Location = new System.Drawing.Point(77, 66);
            this.pnlDatabaseConnection.Name = "pnlDatabaseConnection";
            this.pnlDatabaseConnection.Size = new System.Drawing.Size(200, 115);
            this.pnlDatabaseConnection.TabIndex = 1;
            // 
            // scSound
            // 
            this.scSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSound.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scSound.IsSplitterFixed = true;
            this.scSound.Location = new System.Drawing.Point(6, 16);
            this.scSound.Name = "scSound";
            this.scSound.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scSound.Panel1
            // 
            this.scSound.Panel1.Controls.Add(this.txtSoundFolder);
            this.scSound.Panel1MinSize = 21;
            // 
            // scSound.Panel2
            // 
            this.scSound.Panel2.Controls.Add(this.dgvSoundFiles);
            this.scSound.Panel2.Controls.Add(this.pnlSoundList);
            this.scSound.Size = new System.Drawing.Size(326, 220);
            this.scSound.SplitterDistance = 21;
            this.scSound.SplitterWidth = 1;
            this.scSound.TabIndex = 17;
            // 
            // in_AutomaticQueueNoResetHour
            // 
            this.in_AutomaticQueueNoResetHour.Checked = false;
            this.in_AutomaticQueueNoResetHour.DecimalPlaces = 0;
            this.in_AutomaticQueueNoResetHour.HideUpDown = false;
            this.in_AutomaticQueueNoResetHour.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.in_AutomaticQueueNoResetHour.LabelText = "numeric";
            this.in_AutomaticQueueNoResetHour.Location = new System.Drawing.Point(184, 42);
            this.in_AutomaticQueueNoResetHour.MaximumValue = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.in_AutomaticQueueNoResetHour.MinimumValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.in_AutomaticQueueNoResetHour.Name = "in_AutomaticQueueNoResetHour";
            this.in_AutomaticQueueNoResetHour.ShowAllowDecimalCheckbox = false;
            this.in_AutomaticQueueNoResetHour.ShowCheckbox = false;
            this.in_AutomaticQueueNoResetHour.ShowTextboxOnly = true;
            this.in_AutomaticQueueNoResetHour.Size = new System.Drawing.Size(37, 24);
            this.in_AutomaticQueueNoResetHour.TabIndex = 22;
            this.in_AutomaticQueueNoResetHour.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.in_AutomaticQueueNoResetHour.ValueChanged += new System.EventHandler(this.QueueNoReset_Changed);
            // 
            // in_PrintAreaWidth
            // 
            this.in_PrintAreaWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.in_PrintAreaWidth.Checked = false;
            this.in_PrintAreaWidth.DecimalPlaces = 0;
            this.in_PrintAreaWidth.HideUpDown = false;
            this.in_PrintAreaWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.in_PrintAreaWidth.LabelText = "Lebar kertas";
            this.in_PrintAreaWidth.Location = new System.Drawing.Point(136, 258);
            this.in_PrintAreaWidth.MaximumValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.in_PrintAreaWidth.MinimumValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.in_PrintAreaWidth.Name = "in_PrintAreaWidth";
            this.in_PrintAreaWidth.ShowAllowDecimalCheckbox = false;
            this.in_PrintAreaWidth.ShowCheckbox = false;
            this.in_PrintAreaWidth.ShowTextboxOnly = false;
            this.in_PrintAreaWidth.Size = new System.Drawing.Size(78, 41);
            this.in_PrintAreaWidth.TabIndex = 14;
            this.in_PrintAreaWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // in_PrintQty
            // 
            this.in_PrintQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.in_PrintQty.Checked = false;
            this.in_PrintQty.DecimalPlaces = 0;
            this.in_PrintQty.HideUpDown = false;
            this.in_PrintQty.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.in_PrintQty.LabelText = "Qty print";
            this.in_PrintQty.Location = new System.Drawing.Point(58, 258);
            this.in_PrintQty.MaximumValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.in_PrintQty.MinimumValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.in_PrintQty.Name = "in_PrintQty";
            this.in_PrintQty.ShowAllowDecimalCheckbox = false;
            this.in_PrintQty.ShowCheckbox = false;
            this.in_PrintQty.ShowTextboxOnly = false;
            this.in_PrintQty.Size = new System.Drawing.Size(72, 41);
            this.in_PrintQty.TabIndex = 13;
            this.in_PrintQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // itxt_License
            // 
            this.itxt_License.IsBrowseMode = false;
            this.itxt_License.LabelText = "License";
            this.itxt_License.Location = new System.Drawing.Point(8, 8);
            this.itxt_License.MaxLength = 32767;
            this.itxt_License.MultiLine = false;
            this.itxt_License.Name = "itxt_License";
            this.itxt_License.PasswordChar = '*';
            this.itxt_License.RowCount = 1;
            this.itxt_License.ShowDeleteButton = false;
            this.itxt_License.ShowFilter = false;
            this.itxt_License.ShowTextboxOnly = false;
            this.itxt_License.Size = new System.Drawing.Size(132, 37);
            this.itxt_License.TabIndex = 0;
            this.itxt_License.ValueText = "";
            this.itxt_License.onKeyDown += new System.Windows.Forms.KeyEventHandler(this.itxt_License_onKeyDown);
            // 
            // itxt_ServerName
            // 
            this.itxt_ServerName.IsBrowseMode = false;
            this.itxt_ServerName.LabelText = "Server Name";
            this.itxt_ServerName.Location = new System.Drawing.Point(25, 3);
            this.itxt_ServerName.MaxLength = 32767;
            this.itxt_ServerName.MultiLine = false;
            this.itxt_ServerName.Name = "itxt_ServerName";
            this.itxt_ServerName.PasswordChar = '\0';
            this.itxt_ServerName.RowCount = 1;
            this.itxt_ServerName.ShowDeleteButton = false;
            this.itxt_ServerName.ShowFilter = false;
            this.itxt_ServerName.ShowTextboxOnly = false;
            this.itxt_ServerName.Size = new System.Drawing.Size(151, 37);
            this.itxt_ServerName.TabIndex = 0;
            this.itxt_ServerName.ValueText = "";
            this.itxt_ServerName.onKeyDown += new System.Windows.Forms.KeyEventHandler(this.itxt_ServerName_onKeyDown);
            // 
            // itxt_DatabaseName
            // 
            this.itxt_DatabaseName.IsBrowseMode = false;
            this.itxt_DatabaseName.LabelText = "Database Name";
            this.itxt_DatabaseName.Location = new System.Drawing.Point(25, 44);
            this.itxt_DatabaseName.MaxLength = 32767;
            this.itxt_DatabaseName.MultiLine = false;
            this.itxt_DatabaseName.Name = "itxt_DatabaseName";
            this.itxt_DatabaseName.PasswordChar = '\0';
            this.itxt_DatabaseName.RowCount = 1;
            this.itxt_DatabaseName.ShowDeleteButton = false;
            this.itxt_DatabaseName.ShowFilter = false;
            this.itxt_DatabaseName.ShowTextboxOnly = false;
            this.itxt_DatabaseName.Size = new System.Drawing.Size(151, 37);
            this.itxt_DatabaseName.TabIndex = 1;
            this.itxt_DatabaseName.ValueText = "";
            this.itxt_DatabaseName.onKeyDown += new System.Windows.Forms.KeyEventHandler(this.itxt_ServerName_onKeyDown);
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 337);
            this.Controls.Add(this.tcSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.gbRefreshInterval.ResumeLayout(false);
            this.gbPrinterSettings.ResumeLayout(false);
            this.gbPrinterSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrintLayout)).EndInit();
            this.gbRollingText.ResumeLayout(false);
            this.gbRollingText.PerformLayout();
            this.gbSpeed.ResumeLayout(false);
            this.gbAdsFolder.ResumeLayout(false);
            this.gbAdsFolder.PerformLayout();
            this.gbInterval.ResumeLayout(false);
            this.gbHeaderText.ResumeLayout(false);
            this.gbHeaderText.PerformLayout();
            this.tcSettings.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.gbQueueCutOffTime.ResumeLayout(false);
            this.gbQueueCutOffTime.PerformLayout();
            this.tpData.ResumeLayout(false);
            this.tpPrinter.ResumeLayout(false);
            this.tpSounds.ResumeLayout(false);
            this.tpSounds.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoundFiles)).EndInit();
            this.pnlSoundList.ResumeLayout(false);
            this.tpDatabase.ResumeLayout(false);
            this.pnlLicense.ResumeLayout(false);
            this.pnlDatabaseConnection.ResumeLayout(false);
            this.scSound.Panel1.ResumeLayout(false);
            this.scSound.Panel1.PerformLayout();
            this.scSound.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSound)).EndInit();
            this.scSound.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateCategories;
        private System.Windows.Forms.Button btnCounterAddresses;
        private System.Windows.Forms.GroupBox gbRefreshInterval;
        private System.Windows.Forms.Button btnSaveDatabaseInfo;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_DatabaseName;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_ServerName;
        private System.Windows.Forms.GroupBox gbPrinterSettings;
        private System.Windows.Forms.Button btnTestPrinter;
        private System.Windows.Forms.DataGridView gridPrintLayout;
        private System.Windows.Forms.Button btnSavePrinterSettings;
        private System.Windows.Forms.Button btnAddPrintLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRollingTextSpeed;
        private System.Windows.Forms.TextBox txtRollingText;
        private System.Windows.Forms.Button btnSaveRollingText;
        private System.Windows.Forms.GroupBox gbRollingText;
        private System.Windows.Forms.Button btnRollingTextSpeedDown;
        private System.Windows.Forms.Button btnRollingTextSpeedUp;
        private System.Windows.Forms.GroupBox gbSpeed;
        private System.Windows.Forms.Label lblRefreshInterval;
        private System.Windows.Forms.Button btnDecreaseRefreshInterval;
        private System.Windows.Forms.Button btnIncreaseRefreshInterval;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gridPrintLayout_Id;
        private System.Windows.Forms.DataGridViewLinkColumn col_gridPrintLayout_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gridPrintLayout_LineNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_gridPrintLayout_Hide;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gridPrintLayout_Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gridPrintLayout_FontSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gridPrintLayout_TextAlign_enumid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gridPrintLayout_TextAlign_description;
        private System.Windows.Forms.GroupBox gbAdsFolder;
        private System.Windows.Forms.TextBox txtAdsFolder;
        private System.Windows.Forms.GroupBox gbInterval;
        private System.Windows.Forms.Label lblAdInterval;
        private System.Windows.Forms.Button btnAdIntervalSpeedDown;
        private System.Windows.Forms.Button btnAdIntervalSpeedUp;
        private System.Windows.Forms.GroupBox gbHeaderText;
        private System.Windows.Forms.Button btnSaveHeaderText;
        private System.Windows.Forms.TextBox txtHeaderText;
        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpData;
        private System.Windows.Forms.TabPage tpPrinter;
        private System.Windows.Forms.TabPage tpDatabase;
        private LIBUtil.Desktop.UserControls.InputControl_Numeric in_PrintAreaWidth;
        private LIBUtil.Desktop.UserControls.InputControl_Numeric in_PrintQty;
        private System.Windows.Forms.TabPage tpSounds;
        private System.Windows.Forms.CheckBox chkNotificationSound;
        private System.Windows.Forms.CheckBox chkCounter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoundFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTransitionSoundFilepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnSubmitLicense;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_License;
        private System.Windows.Forms.Panel pnlDatabaseConnection;
        private System.Windows.Forms.Panel pnlSoundList;
        private System.Windows.Forms.DataGridView dgvSoundFiles;
        private System.Windows.Forms.Button btnLoadSoundFiles;
        private System.Windows.Forms.DataGridViewLinkColumn col_dgvSoundFiles_Filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvSoundFiles_Filepath;
        private System.Windows.Forms.GroupBox gbQueueCutOffTime;
        private LIBUtil.Desktop.UserControls.InputControl_Numeric in_AutomaticQueueNoResetHour;
        private System.Windows.Forms.RadioButton rbAutomaticQueueNoReset;
        private System.Windows.Forms.RadioButton rbManualQueueNoReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQueueNoCutoffTimestamp;
        private System.Windows.Forms.Panel pnlLicense;
        private System.Windows.Forms.Button btnResetQueueNumber;
        private System.Windows.Forms.SplitContainer scSound;
    }
}