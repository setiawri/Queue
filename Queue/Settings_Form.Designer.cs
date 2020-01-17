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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_Form));
            this.btnResetQueues = new System.Windows.Forms.Button();
            this.btnUpdateCategories = new System.Windows.Forms.Button();
            this.btnCounterAddresses = new System.Windows.Forms.Button();
            this.gbRefreshInterval = new System.Windows.Forms.GroupBox();
            this.lblRefreshInterval = new System.Windows.Forms.Label();
            this.btnDecreaseRefreshInterval = new System.Windows.Forms.Button();
            this.btnIncreaseRefreshInterval = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveDatabaseInfo = new System.Windows.Forms.Button();
            this.itxt_DatabaseName = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_ServerName = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.gbPrinterSettings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddPrintLine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrintAreaWidth = new System.Windows.Forms.TextBox();
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
            this.gbRefreshInterval.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbPrinterSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrintLayout)).BeginInit();
            this.gbRollingText.SuspendLayout();
            this.gbSpeed.SuspendLayout();
            this.gbAdsFolder.SuspendLayout();
            this.gbInterval.SuspendLayout();
            this.gbHeaderText.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResetQueues
            // 
            this.btnResetQueues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetQueues.Location = new System.Drawing.Point(12, 135);
            this.btnResetQueues.Name = "btnResetQueues";
            this.btnResetQueues.Size = new System.Drawing.Size(157, 56);
            this.btnResetQueues.TabIndex = 0;
            this.btnResetQueues.Text = "RESET ANTRIAN";
            this.btnResetQueues.UseVisualStyleBackColor = true;
            this.btnResetQueues.Click += new System.EventHandler(this.btnResetQueues_Click);
            // 
            // btnUpdateCategories
            // 
            this.btnUpdateCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategories.Location = new System.Drawing.Point(12, 275);
            this.btnUpdateCategories.Name = "btnUpdateCategories";
            this.btnUpdateCategories.Size = new System.Drawing.Size(157, 56);
            this.btnUpdateCategories.TabIndex = 2;
            this.btnUpdateCategories.Text = "CATEGORIES";
            this.btnUpdateCategories.UseVisualStyleBackColor = true;
            this.btnUpdateCategories.Click += new System.EventHandler(this.btnUpdateCategories_Click);
            // 
            // btnCounterAddresses
            // 
            this.btnCounterAddresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCounterAddresses.Location = new System.Drawing.Point(12, 205);
            this.btnCounterAddresses.Name = "btnCounterAddresses";
            this.btnCounterAddresses.Size = new System.Drawing.Size(157, 56);
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
            this.gbRefreshInterval.Location = new System.Drawing.Point(183, 134);
            this.gbRefreshInterval.Name = "gbRefreshInterval";
            this.gbRefreshInterval.Size = new System.Drawing.Size(173, 56);
            this.gbRefreshInterval.TabIndex = 5;
            this.gbRefreshInterval.TabStop = false;
            this.gbRefreshInterval.Text = "Refresh interval (detik)";
            // 
            // lblRefreshInterval
            // 
            this.lblRefreshInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefreshInterval.Location = new System.Drawing.Point(72, 21);
            this.lblRefreshInterval.Name = "lblRefreshInterval";
            this.lblRefreshInterval.Size = new System.Drawing.Size(30, 25);
            this.lblRefreshInterval.TabIndex = 20;
            this.lblRefreshInterval.Text = "X";
            this.lblRefreshInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDecreaseRefreshInterval
            // 
            this.btnDecreaseRefreshInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseRefreshInterval.Location = new System.Drawing.Point(46, 21);
            this.btnDecreaseRefreshInterval.Name = "btnDecreaseRefreshInterval";
            this.btnDecreaseRefreshInterval.Size = new System.Drawing.Size(25, 25);
            this.btnDecreaseRefreshInterval.TabIndex = 22;
            this.btnDecreaseRefreshInterval.Text = "-";
            this.btnDecreaseRefreshInterval.UseVisualStyleBackColor = true;
            this.btnDecreaseRefreshInterval.Click += new System.EventHandler(this.btnDecreaseRefreshInterval_Click);
            // 
            // btnIncreaseRefreshInterval
            // 
            this.btnIncreaseRefreshInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseRefreshInterval.Location = new System.Drawing.Point(101, 21);
            this.btnIncreaseRefreshInterval.Name = "btnIncreaseRefreshInterval";
            this.btnIncreaseRefreshInterval.Size = new System.Drawing.Size(25, 25);
            this.btnIncreaseRefreshInterval.TabIndex = 21;
            this.btnIncreaseRefreshInterval.Text = "+";
            this.btnIncreaseRefreshInterval.UseVisualStyleBackColor = true;
            this.btnIncreaseRefreshInterval.Click += new System.EventHandler(this.btnIncreaseRefreshInterval_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveDatabaseInfo);
            this.groupBox1.Controls.Add(this.itxt_DatabaseName);
            this.groupBox1.Controls.Add(this.itxt_ServerName);
            this.groupBox1.Location = new System.Drawing.Point(183, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 135);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            // 
            // btnSaveDatabaseInfo
            // 
            this.btnSaveDatabaseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDatabaseInfo.Location = new System.Drawing.Point(54, 101);
            this.btnSaveDatabaseInfo.Name = "btnSaveDatabaseInfo";
            this.btnSaveDatabaseInfo.Size = new System.Drawing.Size(64, 26);
            this.btnSaveDatabaseInfo.TabIndex = 5;
            this.btnSaveDatabaseInfo.Text = "SAVE";
            this.btnSaveDatabaseInfo.UseVisualStyleBackColor = true;
            this.btnSaveDatabaseInfo.Click += new System.EventHandler(this.btnSaveDatabaseInfo_Click);
            // 
            // itxt_DatabaseName
            // 
            this.itxt_DatabaseName.IsBrowseMode = false;
            this.itxt_DatabaseName.LabelText = "Database Name";
            this.itxt_DatabaseName.Location = new System.Drawing.Point(11, 60);
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
            // 
            // itxt_ServerName
            // 
            this.itxt_ServerName.IsBrowseMode = false;
            this.itxt_ServerName.LabelText = "Server Name";
            this.itxt_ServerName.Location = new System.Drawing.Point(11, 19);
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
            // 
            // gbPrinterSettings
            // 
            this.gbPrinterSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPrinterSettings.Controls.Add(this.label4);
            this.gbPrinterSettings.Controls.Add(this.btnAddPrintLine);
            this.gbPrinterSettings.Controls.Add(this.label2);
            this.gbPrinterSettings.Controls.Add(this.txtPrintAreaWidth);
            this.gbPrinterSettings.Controls.Add(this.btnTestPrinter);
            this.gbPrinterSettings.Controls.Add(this.gridPrintLayout);
            this.gbPrinterSettings.Controls.Add(this.btnSavePrinterSettings);
            this.gbPrinterSettings.Location = new System.Drawing.Point(12, 336);
            this.gbPrinterSettings.Name = "gbPrinterSettings";
            this.gbPrinterSettings.Size = new System.Drawing.Size(344, 190);
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
            this.btnAddPrintLine.Location = new System.Drawing.Point(6, 161);
            this.btnAddPrintLine.Name = "btnAddPrintLine";
            this.btnAddPrintLine.Size = new System.Drawing.Size(66, 23);
            this.btnAddPrintLine.TabIndex = 9;
            this.btnAddPrintLine.Text = "ADD LINE";
            this.btnAddPrintLine.UseVisualStyleBackColor = true;
            this.btnAddPrintLine.Click += new System.EventHandler(this.btnAddPrintLine_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "lebar kertas";
            // 
            // txtPrintAreaWidth
            // 
            this.txtPrintAreaWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrintAreaWidth.Location = new System.Drawing.Point(141, 163);
            this.txtPrintAreaWidth.Name = "txtPrintAreaWidth";
            this.txtPrintAreaWidth.Size = new System.Drawing.Size(45, 20);
            this.txtPrintAreaWidth.TabIndex = 8;
            // 
            // btnTestPrinter
            // 
            this.btnTestPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestPrinter.Location = new System.Drawing.Point(255, 161);
            this.btnTestPrinter.Name = "btnTestPrinter";
            this.btnTestPrinter.Size = new System.Drawing.Size(83, 23);
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
            this.gridPrintLayout.Size = new System.Drawing.Size(332, 123);
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
            this.btnSavePrinterSettings.Location = new System.Drawing.Point(192, 161);
            this.btnSavePrinterSettings.Name = "btnSavePrinterSettings";
            this.btnSavePrinterSettings.Size = new System.Drawing.Size(57, 23);
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
            this.txtRollingText.Location = new System.Drawing.Point(2, 15);
            this.txtRollingText.Name = "txtRollingText";
            this.txtRollingText.Size = new System.Drawing.Size(220, 20);
            this.txtRollingText.TabIndex = 14;
            this.txtRollingText.MouseLeave += new System.EventHandler(this.txtRollingText_MouseLeave);
            this.txtRollingText.MouseHover += new System.EventHandler(this.txtRollingText_MouseHover);
            // 
            // btnSaveRollingText
            // 
            this.btnSaveRollingText.Location = new System.Drawing.Point(223, 15);
            this.btnSaveRollingText.Name = "btnSaveRollingText";
            this.btnSaveRollingText.Size = new System.Drawing.Size(43, 20);
            this.btnSaveRollingText.TabIndex = 15;
            this.btnSaveRollingText.Text = "SAVE";
            this.btnSaveRollingText.UseVisualStyleBackColor = true;
            this.btnSaveRollingText.Click += new System.EventHandler(this.btnSaveRollingText_Click);
            // 
            // gbRollingText
            // 
            this.gbRollingText.Controls.Add(this.btnSaveRollingText);
            this.gbRollingText.Controls.Add(this.txtRollingText);
            this.gbRollingText.Location = new System.Drawing.Point(12, 48);
            this.gbRollingText.Name = "gbRollingText";
            this.gbRollingText.Size = new System.Drawing.Size(268, 40);
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
            this.gbSpeed.Controls.Add(this.lblRollingTextSpeed);
            this.gbSpeed.Controls.Add(this.btnRollingTextSpeedDown);
            this.gbSpeed.Controls.Add(this.btnRollingTextSpeedUp);
            this.gbSpeed.Location = new System.Drawing.Point(286, 48);
            this.gbSpeed.Name = "gbSpeed";
            this.gbSpeed.Size = new System.Drawing.Size(70, 40);
            this.gbSpeed.TabIndex = 14;
            this.gbSpeed.TabStop = false;
            this.gbSpeed.Text = "Speed";
            // 
            // gbAdsFolder
            // 
            this.gbAdsFolder.Controls.Add(this.txtAdsFolder);
            this.gbAdsFolder.Location = new System.Drawing.Point(14, 89);
            this.gbAdsFolder.Name = "gbAdsFolder";
            this.gbAdsFolder.Size = new System.Drawing.Size(266, 40);
            this.gbAdsFolder.TabIndex = 15;
            this.gbAdsFolder.TabStop = false;
            this.gbAdsFolder.Text = "Ad Folder";
            // 
            // txtAdsFolder
            // 
            this.txtAdsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdsFolder.Location = new System.Drawing.Point(0, 15);
            this.txtAdsFolder.Name = "txtAdsFolder";
            this.txtAdsFolder.Size = new System.Drawing.Size(264, 20);
            this.txtAdsFolder.TabIndex = 14;
            this.txtAdsFolder.Click += new System.EventHandler(this.txtAdsFolder_Click);
            // 
            // gbInterval
            // 
            this.gbInterval.Controls.Add(this.lblAdInterval);
            this.gbInterval.Controls.Add(this.btnAdIntervalSpeedDown);
            this.gbInterval.Controls.Add(this.btnAdIntervalSpeedUp);
            this.gbInterval.Location = new System.Drawing.Point(286, 89);
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
            this.gbHeaderText.Controls.Add(this.btnSaveHeaderText);
            this.gbHeaderText.Controls.Add(this.txtHeaderText);
            this.gbHeaderText.Location = new System.Drawing.Point(12, 5);
            this.gbHeaderText.Name = "gbHeaderText";
            this.gbHeaderText.Size = new System.Drawing.Size(344, 40);
            this.gbHeaderText.TabIndex = 16;
            this.gbHeaderText.TabStop = false;
            this.gbHeaderText.Text = "Header Text";
            // 
            // btnSaveHeaderText
            // 
            this.btnSaveHeaderText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveHeaderText.Location = new System.Drawing.Point(299, 15);
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
            this.txtHeaderText.Size = new System.Drawing.Size(296, 20);
            this.txtHeaderText.TabIndex = 14;
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 536);
            this.Controls.Add(this.gbHeaderText);
            this.Controls.Add(this.gbInterval);
            this.Controls.Add(this.gbAdsFolder);
            this.Controls.Add(this.gbSpeed);
            this.Controls.Add(this.gbRollingText);
            this.Controls.Add(this.gbPrinterSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbRefreshInterval);
            this.Controls.Add(this.btnCounterAddresses);
            this.Controls.Add(this.btnUpdateCategories);
            this.Controls.Add(this.btnResetQueues);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form_Load);
            this.gbRefreshInterval.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResetQueues;
        private System.Windows.Forms.Button btnUpdateCategories;
        private System.Windows.Forms.Button btnCounterAddresses;
        private System.Windows.Forms.GroupBox gbRefreshInterval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveDatabaseInfo;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_DatabaseName;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_ServerName;
        private System.Windows.Forms.GroupBox gbPrinterSettings;
        private System.Windows.Forms.Button btnTestPrinter;
        private System.Windows.Forms.DataGridView gridPrintLayout;
        private System.Windows.Forms.Button btnSavePrinterSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrintAreaWidth;
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
    }
}