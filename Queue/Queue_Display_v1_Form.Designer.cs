namespace Queue
{
    partial class Queue_Display_v1_Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.scContent = new System.Windows.Forms.SplitContainer();
            this.scContentLeft = new System.Windows.Forms.SplitContainer();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.lblCallingNo = new System.Windows.Forms.Label();
            this.lblCallingCounter = new System.Windows.Forms.Label();
            this.lblSilahkanKeCounter = new System.Windows.Forms.Label();
            this.rollingText1 = new Queue.UserControls.RollingText();
            this.scContentRight = new System.Windows.Forms.SplitContainer();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.col_dgv_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_NoAntrian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_CounterAddresses_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clock1 = new Queue.UserControls.Clock();
            this.timerAds = new System.Windows.Forms.Timer(this.components);
            this.timerRefreshInterval = new System.Windows.Forms.Timer(this.components);
            this.bgwCaller = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).BeginInit();
            this.scContainer.Panel1.SuspendLayout();
            this.scContainer.Panel2.SuspendLayout();
            this.scContainer.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).BeginInit();
            this.scContent.Panel1.SuspendLayout();
            this.scContent.Panel2.SuspendLayout();
            this.scContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContentLeft)).BeginInit();
            this.scContentLeft.Panel1.SuspendLayout();
            this.scContentLeft.Panel2.SuspendLayout();
            this.scContentLeft.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContentRight)).BeginInit();
            this.scContentRight.Panel1.SuspendLayout();
            this.scContentRight.Panel2.SuspendLayout();
            this.scContentRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // scContainer
            // 
            // 
            // scContainer.Panel2
            // 
            this.scContainer.Panel2.Controls.Add(this.scContent);
            // 
            // scContent
            // 
            this.scContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContent.Location = new System.Drawing.Point(0, 0);
            this.scContent.Name = "scContent";
            // 
            // scContent.Panel1
            // 
            this.scContent.Panel1.Controls.Add(this.scContentLeft);
            // 
            // scContent.Panel2
            // 
            this.scContent.Panel2.Controls.Add(this.scContentRight);
            this.scContent.Size = new System.Drawing.Size(850, 369);
            this.scContent.SplitterDistance = 503;
            this.scContent.SplitterWidth = 1;
            this.scContent.TabIndex = 0;
            // 
            // scContentLeft
            // 
            this.scContentLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContentLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scContentLeft.IsSplitterFixed = true;
            this.scContentLeft.Location = new System.Drawing.Point(0, 0);
            this.scContentLeft.Name = "scContentLeft";
            this.scContentLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scContentLeft.Panel1
            // 
            this.scContentLeft.Panel1.Controls.Add(this.pnlDisplay);
            // 
            // scContentLeft.Panel2
            // 
            this.scContentLeft.Panel2.Controls.Add(this.rollingText1);
            this.scContentLeft.Size = new System.Drawing.Size(503, 369);
            this.scContentLeft.SplitterDistance = 333;
            this.scContentLeft.SplitterWidth = 1;
            this.scContentLeft.TabIndex = 0;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDisplay.Controls.Add(this.lblCallingNo);
            this.pnlDisplay.Controls.Add(this.lblCallingCounter);
            this.pnlDisplay.Controls.Add(this.lblSilahkanKeCounter);
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 0);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(503, 333);
            this.pnlDisplay.TabIndex = 4;
            // 
            // lblCallingNo
            // 
            this.lblCallingNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCallingNo.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallingNo.ForeColor = System.Drawing.Color.Crimson;
            this.lblCallingNo.Location = new System.Drawing.Point(0, 0);
            this.lblCallingNo.Name = "lblCallingNo";
            this.lblCallingNo.Size = new System.Drawing.Size(503, 138);
            this.lblCallingNo.TabIndex = 4;
            this.lblCallingNo.Text = "lblCallingNo";
            this.lblCallingNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCallingCounter
            // 
            this.lblCallingCounter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCallingCounter.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallingCounter.ForeColor = System.Drawing.Color.Crimson;
            this.lblCallingCounter.Location = new System.Drawing.Point(0, 193);
            this.lblCallingCounter.Name = "lblCallingCounter";
            this.lblCallingCounter.Size = new System.Drawing.Size(503, 140);
            this.lblCallingCounter.TabIndex = 6;
            this.lblCallingCounter.Text = "lblCallingCounter";
            this.lblCallingCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSilahkanKeCounter
            // 
            this.lblSilahkanKeCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSilahkanKeCounter.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSilahkanKeCounter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSilahkanKeCounter.Location = new System.Drawing.Point(0, 0);
            this.lblSilahkanKeCounter.Name = "lblSilahkanKeCounter";
            this.lblSilahkanKeCounter.Size = new System.Drawing.Size(503, 333);
            this.lblSilahkanKeCounter.TabIndex = 5;
            this.lblSilahkanKeCounter.Text = "SILAHKAN KE";
            this.lblSilahkanKeCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rollingText1
            // 
            this.rollingText1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rollingText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollingText1.Location = new System.Drawing.Point(0, 0);
            this.rollingText1.Name = "rollingText1";
            this.rollingText1.Size = new System.Drawing.Size(503, 35);
            this.rollingText1.TabIndex = 0;
            // 
            // scContentRight
            // 
            this.scContentRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContentRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scContentRight.IsSplitterFixed = true;
            this.scContentRight.Location = new System.Drawing.Point(0, 0);
            this.scContentRight.Name = "scContentRight";
            this.scContentRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scContentRight.Panel1
            // 
            this.scContentRight.Panel1.Controls.Add(this.dgv);
            // 
            // scContentRight.Panel2
            // 
            this.scContentRight.Panel2.Controls.Add(this.clock1);
            this.scContentRight.Size = new System.Drawing.Size(346, 369);
            this.scContentRight.SplitterDistance = 333;
            this.scContentRight.SplitterWidth = 1;
            this.scContentRight.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgv_Id,
            this.col_dgv_NoAntrian,
            this.col_dgv_CounterAddresses_Name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 30, 0, 30);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(346, 333);
            this.dgv.TabIndex = 2;
            // 
            // col_dgv_Id
            // 
            this.col_dgv_Id.HeaderText = "Id";
            this.col_dgv_Id.Name = "col_dgv_Id";
            this.col_dgv_Id.Visible = false;
            // 
            // col_dgv_NoAntrian
            // 
            this.col_dgv_NoAntrian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_dgv_NoAntrian.HeaderText = "ANTRIAN";
            this.col_dgv_NoAntrian.MinimumWidth = 50;
            this.col_dgv_NoAntrian.Name = "col_dgv_NoAntrian";
            this.col_dgv_NoAntrian.ReadOnly = true;
            this.col_dgv_NoAntrian.Width = 133;
            // 
            // col_dgv_CounterAddresses_Name
            // 
            this.col_dgv_CounterAddresses_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dgv_CounterAddresses_Name.HeaderText = "COUNTER";
            this.col_dgv_CounterAddresses_Name.MinimumWidth = 100;
            this.col_dgv_CounterAddresses_Name.Name = "col_dgv_CounterAddresses_Name";
            this.col_dgv_CounterAddresses_Name.ReadOnly = true;
            // 
            // clock1
            // 
            this.clock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clock1.Location = new System.Drawing.Point(0, 0);
            this.clock1.Name = "clock1";
            this.clock1.Size = new System.Drawing.Size(346, 35);
            this.clock1.TabIndex = 0;
            // 
            // timerAds
            // 
            this.timerAds.Tick += new System.EventHandler(this.timerAds_Tick);
            // 
            // timerRefreshInterval
            // 
            this.timerRefreshInterval.Tick += new System.EventHandler(this.timerRefreshInterval_Tick);
            // 
            // bgwCaller
            // 
            this.bgwCaller.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwCaller_DoWork);
            // 
            // Queue_Display_v1_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Name = "Queue_Display_v1_Form";
            this.Text = "Queue_Display_v1_Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.scContainer.Panel1.ResumeLayout(false);
            this.scContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).EndInit();
            this.scContainer.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.scContent.Panel1.ResumeLayout(false);
            this.scContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).EndInit();
            this.scContent.ResumeLayout(false);
            this.scContentLeft.Panel1.ResumeLayout(false);
            this.scContentLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContentLeft)).EndInit();
            this.scContentLeft.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
            this.scContentRight.Panel1.ResumeLayout(false);
            this.scContentRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContentRight)).EndInit();
            this.scContentRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scContent;
        private System.Windows.Forms.SplitContainer scContentLeft;
        private System.Windows.Forms.SplitContainer scContentRight;
        private UserControls.RollingText rollingText1;
        private UserControls.Clock clock1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Label lblCallingNo;
        private System.Windows.Forms.Label lblCallingCounter;
        private System.Windows.Forms.Label lblSilahkanKeCounter;
        private System.Windows.Forms.Timer timerAds;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_NoAntrian;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_CounterAddresses_Name;
        private System.Windows.Forms.Timer timerRefreshInterval;
        private System.ComponentModel.BackgroundWorker bgwCaller;
    }
}