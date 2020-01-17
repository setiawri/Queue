namespace Queue
{
    partial class Queue_Caller_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Queue_Caller_Form));
            this.pnlInput = new System.Windows.Forms.Panel();
            this.pbUnlock = new System.Windows.Forms.PictureBox();
            this.pbLock = new System.Windows.Forms.PictureBox();
            this.lblLastCalled = new System.Windows.Forms.Label();
            this.pbUpdate = new System.Windows.Forms.PictureBox();
            this.btnShowQueue = new System.Windows.Forms.Button();
            this.txtFilterCalled = new System.Windows.Forms.TextBox();
            this.ddlCalled = new LIBUtil.Desktop.UserControls.Dropdownlist();
            this.btnCallPrevious = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.col_dgv_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_CalledCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_CallerButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_dgv_PendingCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_WaitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_QueueCategories_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_CallerText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_Categories_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.pbUnlock);
            this.pnlInput.Controls.Add(this.pbLock);
            this.pnlInput.Controls.Add(this.lblLastCalled);
            this.pnlInput.Controls.Add(this.pbUpdate);
            this.pnlInput.Controls.Add(this.btnShowQueue);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(421, 32);
            this.pnlInput.TabIndex = 25;
            // 
            // pbUnlock
            // 
            this.pbUnlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUnlock.BackColor = System.Drawing.Color.Transparent;
            this.pbUnlock.BackgroundImage = global::Queue.Properties.Resources.unlock;
            this.pbUnlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUnlock.Location = new System.Drawing.Point(3, 6);
            this.pbUnlock.Name = "pbUnlock";
            this.pbUnlock.Size = new System.Drawing.Size(20, 20);
            this.pbUnlock.TabIndex = 36;
            this.pbUnlock.TabStop = false;
            this.pbUnlock.Visible = false;
            this.pbUnlock.Click += new System.EventHandler(this.pbUnlock_Click);
            // 
            // pbLock
            // 
            this.pbLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLock.BackColor = System.Drawing.Color.Transparent;
            this.pbLock.BackgroundImage = global::Queue.Properties.Resources._lock;
            this.pbLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLock.Location = new System.Drawing.Point(3, 6);
            this.pbLock.Name = "pbLock";
            this.pbLock.Size = new System.Drawing.Size(20, 20);
            this.pbLock.TabIndex = 35;
            this.pbLock.TabStop = false;
            this.pbLock.Click += new System.EventHandler(this.pbLock_Click);
            // 
            // lblLastCalled
            // 
            this.lblLastCalled.AutoSize = true;
            this.lblLastCalled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastCalled.Location = new System.Drawing.Point(127, 6);
            this.lblLastCalled.Name = "lblLastCalled";
            this.lblLastCalled.Size = new System.Drawing.Size(99, 20);
            this.lblLastCalled.TabIndex = 34;
            this.lblLastCalled.Text = "lblLastCalled";
            this.lblLastCalled.Visible = false;
            // 
            // pbUpdate
            // 
            this.pbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUpdate.BackColor = System.Drawing.Color.Transparent;
            this.pbUpdate.BackgroundImage = global::Queue.Properties.Resources.gear_black;
            this.pbUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUpdate.Location = new System.Drawing.Point(392, 5);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(23, 23);
            this.pbUpdate.TabIndex = 33;
            this.pbUpdate.TabStop = false;
            this.pbUpdate.Click += new System.EventHandler(this.pbUpdate_Click);
            // 
            // btnShowQueue
            // 
            this.btnShowQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowQueue.Location = new System.Drawing.Point(26, 5);
            this.btnShowQueue.Name = "btnShowQueue";
            this.btnShowQueue.Size = new System.Drawing.Size(97, 23);
            this.btnShowQueue.TabIndex = 32;
            this.btnShowQueue.Text = "SHOW QUEUE";
            this.btnShowQueue.UseVisualStyleBackColor = true;
            this.btnShowQueue.Click += new System.EventHandler(this.btnShowQueue_Click);
            // 
            // txtFilterCalled
            // 
            this.txtFilterCalled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterCalled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterCalled.Location = new System.Drawing.Point(6, 6);
            this.txtFilterCalled.MaxLength = 5;
            this.txtFilterCalled.Name = "txtFilterCalled";
            this.txtFilterCalled.Size = new System.Drawing.Size(35, 21);
            this.txtFilterCalled.TabIndex = 29;
            this.txtFilterCalled.TextChanged += new System.EventHandler(this.txtFilterCalled_TextChanged);
            // 
            // ddlCalled
            // 
            this.ddlCalled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlCalled.DisplayMember = "";
            this.ddlCalled.Filter = "";
            this.ddlCalled.Location = new System.Drawing.Point(43, 6);
            this.ddlCalled.Name = "ddlCalled";
            this.ddlCalled.SelectedItem = null;
            this.ddlCalled.SelectedValue = null;
            this.ddlCalled.Size = new System.Drawing.Size(63, 21);
            this.ddlCalled.TabIndex = 28;
            this.ddlCalled.ValueMember = "";
            // 
            // btnCallPrevious
            // 
            this.btnCallPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCallPrevious.Location = new System.Drawing.Point(112, 5);
            this.btnCallPrevious.Name = "btnCallPrevious";
            this.btnCallPrevious.Size = new System.Drawing.Size(66, 23);
            this.btnCallPrevious.TabIndex = 26;
            this.btnCallPrevious.Text = "RECALL";
            this.btnCallPrevious.UseVisualStyleBackColor = true;
            this.btnCallPrevious.Click += new System.EventHandler(this.btnCallPrevious_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgv_Id,
            this.col_dgv_CalledCount,
            this.col_dgv_CallerButton,
            this.col_dgv_PendingCount,
            this.col_dgv_WaitTime,
            this.col_dgv_QueueCategories_Id,
            this.col_dgv_CallerText,
            this.col_dgv_Count,
            this.col_dgv_Categories_Description});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 32);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(421, 172);
            this.dgv.TabIndex = 26;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // col_dgv_Id
            // 
            this.col_dgv_Id.HeaderText = "Id";
            this.col_dgv_Id.Name = "col_dgv_Id";
            this.col_dgv_Id.Visible = false;
            // 
            // col_dgv_CalledCount
            // 
            this.col_dgv_CalledCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_dgv_CalledCount.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_dgv_CalledCount.HeaderText = "Last";
            this.col_dgv_CalledCount.MinimumWidth = 30;
            this.col_dgv_CalledCount.Name = "col_dgv_CalledCount";
            this.col_dgv_CalledCount.ReadOnly = true;
            this.col_dgv_CalledCount.Width = 30;
            // 
            // col_dgv_CallerButton
            // 
            this.col_dgv_CallerButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_dgv_CallerButton.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_dgv_CallerButton.HeaderText = "";
            this.col_dgv_CallerButton.MinimumWidth = 50;
            this.col_dgv_CallerButton.Name = "col_dgv_CallerButton";
            this.col_dgv_CallerButton.Text = "";
            this.col_dgv_CallerButton.Width = 50;
            // 
            // col_dgv_PendingCount
            // 
            this.col_dgv_PendingCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.col_dgv_PendingCount.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_dgv_PendingCount.HeaderText = "Wait";
            this.col_dgv_PendingCount.MinimumWidth = 30;
            this.col_dgv_PendingCount.Name = "col_dgv_PendingCount";
            this.col_dgv_PendingCount.Width = 30;
            // 
            // col_dgv_WaitTime
            // 
            this.col_dgv_WaitTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.col_dgv_WaitTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_dgv_WaitTime.HeaderText = "menit";
            this.col_dgv_WaitTime.MinimumWidth = 40;
            this.col_dgv_WaitTime.Name = "col_dgv_WaitTime";
            this.col_dgv_WaitTime.ReadOnly = true;
            this.col_dgv_WaitTime.Width = 40;
            // 
            // col_dgv_QueueCategories_Id
            // 
            this.col_dgv_QueueCategories_Id.HeaderText = "Category Id";
            this.col_dgv_QueueCategories_Id.Name = "col_dgv_QueueCategories_Id";
            this.col_dgv_QueueCategories_Id.Visible = false;
            // 
            // col_dgv_CallerText
            // 
            this.col_dgv_CallerText.HeaderText = "Caller Text";
            this.col_dgv_CallerText.Name = "col_dgv_CallerText";
            this.col_dgv_CallerText.Visible = false;
            // 
            // col_dgv_Count
            // 
            this.col_dgv_Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_dgv_Count.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_dgv_Count.HeaderText = "ANTRIAN";
            this.col_dgv_Count.MinimumWidth = 30;
            this.col_dgv_Count.Name = "col_dgv_Count";
            this.col_dgv_Count.ReadOnly = true;
            this.col_dgv_Count.Visible = false;
            // 
            // col_dgv_Categories_Description
            // 
            this.col_dgv_Categories_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.col_dgv_Categories_Description.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_dgv_Categories_Description.HeaderText = "";
            this.col_dgv_Categories_Description.MinimumWidth = 50;
            this.col_dgv_Categories_Description.Name = "col_dgv_Categories_Description";
            this.col_dgv_Categories_Description.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlOptions
            // 
            this.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptions.Controls.Add(this.txtFilterCalled);
            this.pnlOptions.Controls.Add(this.ddlCalled);
            this.pnlOptions.Controls.Add(this.btnCallPrevious);
            this.pnlOptions.Location = new System.Drawing.Point(236, 32);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(185, 35);
            this.pnlOptions.TabIndex = 27;
            this.pnlOptions.Visible = false;
            // 
            // Queue_Caller_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 204);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Queue_Caller_Form";
            this.Text = "Queue App";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Queue_Caller_Form_Shown);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCallPrevious;
        private LIBUtil.Desktop.UserControls.Dropdownlist ddlCalled;
        private System.Windows.Forms.TextBox txtFilterCalled;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnShowQueue;
        private System.Windows.Forms.PictureBox pbUpdate;
        private System.Windows.Forms.Label lblLastCalled;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_CalledCount;
        private System.Windows.Forms.DataGridViewButtonColumn col_dgv_CallerButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_PendingCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_WaitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_QueueCategories_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_CallerText;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_Categories_Description;
        private System.Windows.Forms.PictureBox pbLock;
        private System.Windows.Forms.PictureBox pbUnlock;
    }
}