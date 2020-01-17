namespace Queue
{
    partial class Queue_Request_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.col_dgv_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_QueueCategories_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_RequestText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgv_RequestButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_dgv_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIncreaseFontStep = new System.Windows.Forms.Button();
            this.btnDecreaseFontStep = new System.Windows.Forms.Button();
            this.btnIncreaseFont = new System.Windows.Forms.Button();
            this.btnDecreaseFont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.btnIncreaseWidthStep = new System.Windows.Forms.Button();
            this.btnDecreaseWidthStep = new System.Windows.Forms.Button();
            this.btnIncreaseWidth = new System.Windows.Forms.Button();
            this.btnDecreaseWidth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgv_Id,
            this.col_dgv_QueueCategories_Id,
            this.col_dgv_RequestText,
            this.col_dgv_RequestButton,
            this.col_dgv_Description});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(30, 35);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(420, 351);
            this.dgv.TabIndex = 27;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Queue_Request_Form_MouseClick);
            // 
            // col_dgv_Id
            // 
            this.col_dgv_Id.HeaderText = "Id";
            this.col_dgv_Id.Name = "col_dgv_Id";
            this.col_dgv_Id.Visible = false;
            // 
            // col_dgv_QueueCategories_Id
            // 
            this.col_dgv_QueueCategories_Id.HeaderText = "Category ID";
            this.col_dgv_QueueCategories_Id.Name = "col_dgv_QueueCategories_Id";
            this.col_dgv_QueueCategories_Id.Visible = false;
            // 
            // col_dgv_RequestText
            // 
            this.col_dgv_RequestText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dgv_RequestText.HeaderText = "Request Text";
            this.col_dgv_RequestText.Name = "col_dgv_RequestText";
            this.col_dgv_RequestText.Visible = false;
            // 
            // col_dgv_RequestButton
            // 
            this.col_dgv_RequestButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_dgv_RequestButton.HeaderText = "";
            this.col_dgv_RequestButton.Name = "col_dgv_RequestButton";
            this.col_dgv_RequestButton.Text = "PANGGIL";
            this.col_dgv_RequestButton.Width = 5;
            // 
            // col_dgv_Description
            // 
            this.col_dgv_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dgv_Description.HeaderText = "Description";
            this.col_dgv_Description.Name = "col_dgv_Description";
            this.col_dgv_Description.ReadOnly = true;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSettings.Controls.Add(this.btnIncreaseWidthStep);
            this.pnlSettings.Controls.Add(this.btnDecreaseWidthStep);
            this.pnlSettings.Controls.Add(this.btnIncreaseWidth);
            this.pnlSettings.Controls.Add(this.btnDecreaseWidth);
            this.pnlSettings.Controls.Add(this.btnQuit);
            this.pnlSettings.Controls.Add(this.label2);
            this.pnlSettings.Controls.Add(this.btnIncreaseFontStep);
            this.pnlSettings.Controls.Add(this.btnDecreaseFontStep);
            this.pnlSettings.Controls.Add(this.btnIncreaseFont);
            this.pnlSettings.Controls.Add(this.btnDecreaseFont);
            this.pnlSettings.Controls.Add(this.label1);
            this.pnlSettings.Location = new System.Drawing.Point(361, 73);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(150, 86);
            this.pnlSettings.TabIndex = 29;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Location = new System.Drawing.Point(53, 58);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(43, 23);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lebar";
            // 
            // btnIncreaseFontStep
            // 
            this.btnIncreaseFontStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncreaseFontStep.Location = new System.Drawing.Point(121, 6);
            this.btnIncreaseFontStep.Name = "btnIncreaseFontStep";
            this.btnIncreaseFontStep.Size = new System.Drawing.Size(22, 23);
            this.btnIncreaseFontStep.TabIndex = 6;
            this.btnIncreaseFontStep.Text = ">";
            this.btnIncreaseFontStep.UseVisualStyleBackColor = true;
            this.btnIncreaseFontStep.Click += new System.EventHandler(this.btnIncreaseStep_Click);
            // 
            // btnDecreaseFontStep
            // 
            this.btnDecreaseFontStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecreaseFontStep.Location = new System.Drawing.Point(6, 6);
            this.btnDecreaseFontStep.Name = "btnDecreaseFontStep";
            this.btnDecreaseFontStep.Size = new System.Drawing.Size(22, 23);
            this.btnDecreaseFontStep.TabIndex = 5;
            this.btnDecreaseFontStep.Text = "<";
            this.btnDecreaseFontStep.UseVisualStyleBackColor = true;
            this.btnDecreaseFontStep.Click += new System.EventHandler(this.btnDecreaseStep_Click);
            // 
            // btnIncreaseFont
            // 
            this.btnIncreaseFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncreaseFont.Location = new System.Drawing.Point(98, 6);
            this.btnIncreaseFont.Name = "btnIncreaseFont";
            this.btnIncreaseFont.Size = new System.Drawing.Size(22, 23);
            this.btnIncreaseFont.TabIndex = 4;
            this.btnIncreaseFont.Text = "+";
            this.btnIncreaseFont.UseVisualStyleBackColor = true;
            this.btnIncreaseFont.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnDecreaseFont
            // 
            this.btnDecreaseFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecreaseFont.Location = new System.Drawing.Point(29, 6);
            this.btnDecreaseFont.Name = "btnDecreaseFont";
            this.btnDecreaseFont.Size = new System.Drawing.Size(22, 23);
            this.btnDecreaseFont.TabIndex = 3;
            this.btnDecreaseFont.Text = "-";
            this.btnDecreaseFont.UseVisualStyleBackColor = true;
            this.btnDecreaseFont.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font Size";
            // 
            // pbSettings
            // 
            this.pbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSettings.BackColor = System.Drawing.Color.Transparent;
            this.pbSettings.BackgroundImage = global::Queue.Properties.Resources.Q_48;
            this.pbSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSettings.Location = new System.Drawing.Point(439, 1);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(72, 72);
            this.pbSettings.TabIndex = 30;
            this.pbSettings.TabStop = false;
            this.pbSettings.Click += new System.EventHandler(this.pbUpdate_Click);
            // 
            // btnIncreaseWidthStep
            // 
            this.btnIncreaseWidthStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncreaseWidthStep.Location = new System.Drawing.Point(121, 31);
            this.btnIncreaseWidthStep.Name = "btnIncreaseWidthStep";
            this.btnIncreaseWidthStep.Size = new System.Drawing.Size(22, 23);
            this.btnIncreaseWidthStep.TabIndex = 14;
            this.btnIncreaseWidthStep.Text = ">";
            this.btnIncreaseWidthStep.UseVisualStyleBackColor = true;
            this.btnIncreaseWidthStep.Click += new System.EventHandler(this.btnIncreaseWidthStep_Click);
            // 
            // btnDecreaseWidthStep
            // 
            this.btnDecreaseWidthStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecreaseWidthStep.Location = new System.Drawing.Point(6, 31);
            this.btnDecreaseWidthStep.Name = "btnDecreaseWidthStep";
            this.btnDecreaseWidthStep.Size = new System.Drawing.Size(22, 23);
            this.btnDecreaseWidthStep.TabIndex = 13;
            this.btnDecreaseWidthStep.Text = "<";
            this.btnDecreaseWidthStep.UseVisualStyleBackColor = true;
            this.btnDecreaseWidthStep.Click += new System.EventHandler(this.btnDecreaseWidthStep_Click);
            // 
            // btnIncreaseWidth
            // 
            this.btnIncreaseWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncreaseWidth.Location = new System.Drawing.Point(98, 31);
            this.btnIncreaseWidth.Name = "btnIncreaseWidth";
            this.btnIncreaseWidth.Size = new System.Drawing.Size(22, 23);
            this.btnIncreaseWidth.TabIndex = 12;
            this.btnIncreaseWidth.Text = "+";
            this.btnIncreaseWidth.UseVisualStyleBackColor = true;
            this.btnIncreaseWidth.Click += new System.EventHandler(this.btnIncreaseWidth_Click);
            // 
            // btnDecreaseWidth
            // 
            this.btnDecreaseWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecreaseWidth.Location = new System.Drawing.Point(29, 31);
            this.btnDecreaseWidth.Name = "btnDecreaseWidth";
            this.btnDecreaseWidth.Size = new System.Drawing.Size(22, 23);
            this.btnDecreaseWidth.TabIndex = 11;
            this.btnDecreaseWidth.Text = "-";
            this.btnDecreaseWidth.UseVisualStyleBackColor = true;
            this.btnDecreaseWidth.Click += new System.EventHandler(this.btnDecreaseWidth_Click);
            // 
            // Queue_Request_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 434);
            this.Controls.Add(this.pbSettings);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Queue_Request_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Queue_Request_Form_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Queue_Request_Form_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Queue_Request_Form_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIncreaseFont;
        private System.Windows.Forms.Button btnDecreaseFont;
        private System.Windows.Forms.Button btnIncreaseFontStep;
        private System.Windows.Forms.Button btnDecreaseFontStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_QueueCategories_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_RequestText;
        private System.Windows.Forms.DataGridViewButtonColumn col_dgv_RequestButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgv_Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnIncreaseWidthStep;
        private System.Windows.Forms.Button btnDecreaseWidthStep;
        private System.Windows.Forms.Button btnIncreaseWidth;
        private System.Windows.Forms.Button btnDecreaseWidth;
    }
}