namespace Queue.Reports
{
    partial class History_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.col_dgvQueues_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvQueues_CallNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvQueues_Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvQueues_CounterAddresses_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvQueues_CallTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvQueues_WaitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_VoidTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.idtp_EndDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_StartDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvQueues_Id,
            this.col_dgvQueues_CallNo,
            this.col_dgvQueues_Timestamp,
            this.col_dgvQueues_CounterAddresses_Name,
            this.col_dgvQueues_CallTimestamp,
            this.col_dgvQueues_WaitTime,
            this.col_dgv_VoidTimestamp});
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(0, 66);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(610, 384);
            this.dgvHistory.TabIndex = 4;
            // 
            // col_dgvQueues_Id
            // 
            this.col_dgvQueues_Id.HeaderText = "Id";
            this.col_dgvQueues_Id.Name = "col_dgvQueues_Id";
            this.col_dgvQueues_Id.Visible = false;
            // 
            // col_dgvQueues_CallNo
            // 
            this.col_dgvQueues_CallNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_dgvQueues_CallNo.HeaderText = "No";
            this.col_dgvQueues_CallNo.Name = "col_dgvQueues_CallNo";
            this.col_dgvQueues_CallNo.ReadOnly = true;
            this.col_dgvQueues_CallNo.Width = 46;
            // 
            // col_dgvQueues_Timestamp
            // 
            this.col_dgvQueues_Timestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Format = "dd/MM/yy HH:mm";
            this.col_dgvQueues_Timestamp.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_dgvQueues_Timestamp.HeaderText = "Request";
            this.col_dgvQueues_Timestamp.Name = "col_dgvQueues_Timestamp";
            this.col_dgvQueues_Timestamp.ReadOnly = true;
            this.col_dgvQueues_Timestamp.Width = 72;
            // 
            // col_dgvQueues_CounterAddresses_Name
            // 
            this.col_dgvQueues_CounterAddresses_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_dgvQueues_CounterAddresses_Name.HeaderText = "Counter";
            this.col_dgvQueues_CounterAddresses_Name.Name = "col_dgvQueues_CounterAddresses_Name";
            this.col_dgvQueues_CounterAddresses_Name.ReadOnly = true;
            this.col_dgvQueues_CounterAddresses_Name.Width = 69;
            // 
            // col_dgvQueues_CallTimestamp
            // 
            this.col_dgvQueues_CallTimestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "dd/MM/yy HH:mm";
            this.col_dgvQueues_CallTimestamp.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_dgvQueues_CallTimestamp.HeaderText = "Called";
            this.col_dgvQueues_CallTimestamp.Name = "col_dgvQueues_CallTimestamp";
            this.col_dgvQueues_CallTimestamp.ReadOnly = true;
            this.col_dgvQueues_CallTimestamp.Width = 61;
            // 
            // col_dgvQueues_WaitTime
            // 
            this.col_dgvQueues_WaitTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.col_dgvQueues_WaitTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_dgvQueues_WaitTime.HeaderText = "Wait";
            this.col_dgvQueues_WaitTime.Name = "col_dgvQueues_WaitTime";
            this.col_dgvQueues_WaitTime.ReadOnly = true;
            this.col_dgvQueues_WaitTime.Width = 54;
            // 
            // col_dgv_VoidTimestamp
            // 
            this.col_dgv_VoidTimestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "dd/MM/yy HH:mm";
            this.col_dgv_VoidTimestamp.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_dgv_VoidTimestamp.HeaderText = "Void";
            this.col_dgv_VoidTimestamp.MinimumWidth = 30;
            this.col_dgv_VoidTimestamp.Name = "col_dgv_VoidTimestamp";
            this.col_dgv_VoidTimestamp.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.idtp_EndDate);
            this.panel1.Controls.Add(this.idtp_StartDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 66);
            this.panel1.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(282, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 41);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // idtp_EndDate
            // 
            this.idtp_EndDate.Checked = false;
            this.idtp_EndDate.CustomFormat = "ddd, dd/MM/yyyy";
            this.idtp_EndDate.DefaultCheckedValue = false;
            this.idtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_EndDate.LabelText = "End";
            this.idtp_EndDate.Location = new System.Drawing.Point(134, 3);
            this.idtp_EndDate.Name = "idtp_EndDate";
            this.idtp_EndDate.ShowCheckBox = true;
            this.idtp_EndDate.ShowDateTimePickerOnly = false;
            this.idtp_EndDate.ShowUpAndDown = false;
            this.idtp_EndDate.Size = new System.Drawing.Size(148, 41);
            this.idtp_EndDate.TabIndex = 1;
            this.idtp_EndDate.Value = null;
            this.idtp_EndDate.ValueTimeSpan = null;
            // 
            // idtp_StartDate
            // 
            this.idtp_StartDate.Checked = true;
            this.idtp_StartDate.CustomFormat = "ddd, dd/MM/yyyy";
            this.idtp_StartDate.DefaultCheckedValue = false;
            this.idtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_StartDate.LabelText = "Start";
            this.idtp_StartDate.Location = new System.Drawing.Point(3, 3);
            this.idtp_StartDate.Name = "idtp_StartDate";
            this.idtp_StartDate.ShowCheckBox = false;
            this.idtp_StartDate.ShowDateTimePickerOnly = false;
            this.idtp_StartDate.ShowUpAndDown = false;
            this.idtp_StartDate.Size = new System.Drawing.Size(130, 41);
            this.idtp_StartDate.TabIndex = 0;
            this.idtp_StartDate.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.idtp_StartDate.ValueTimeSpan = System.TimeSpan.Parse("00:00:00");
            // 
            // History_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.panel1);
            this.Name = "History_Form";
            this.Text = "History";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_EndDate;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvQueues_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvQueues_CallNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvQueues_Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvQueues_CounterAddresses_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvQueues_CallTimestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvQueues_WaitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_VoidTimestamp;
    }
}