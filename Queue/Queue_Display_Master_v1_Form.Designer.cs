﻿namespace Queue
{
    partial class Queue_Display_Master_v1_Form
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
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDisplayMode2 = new System.Windows.Forms.RadioButton();
            this.rbDisplayMode1 = new System.Windows.Forms.RadioButton();
            this.chkShowAds = new System.Windows.Forms.CheckBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.scContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).BeginInit();
            this.scContainer.Panel1.SuspendLayout();
            this.scContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.ForeColor = System.Drawing.Color.White;
            this.lblHeaderText.Location = new System.Drawing.Point(49, 13);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(0, 55);
            this.lblHeaderText.TabIndex = 0;
            // 
            // pbSettings
            // 
            this.pbSettings.BackColor = System.Drawing.Color.Transparent;
            this.pbSettings.BackgroundImage = global::Queue.Properties.Resources.Q_48;
            this.pbSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbSettings.Location = new System.Drawing.Point(770, 0);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(80, 80);
            this.pbSettings.TabIndex = 32;
            this.pbSettings.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SlateGray;
            this.pnlHeader.Controls.Add(this.pnlSettings);
            this.pnlHeader.Controls.Add(this.pbSettings);
            this.pnlHeader.Controls.Add(this.lblHeaderText);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(850, 80);
            this.pnlHeader.TabIndex = 4;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlSettings.Controls.Add(this.groupBox1);
            this.pnlSettings.Controls.Add(this.chkShowAds);
            this.pnlSettings.Controls.Add(this.btnQuit);
            this.pnlSettings.Location = new System.Drawing.Point(618, 3);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(150, 74);
            this.pnlSettings.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbDisplayMode2);
            this.groupBox1.Controls.Add(this.rbDisplayMode1);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(54, 58);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODE";
            // 
            // rbDisplayMode2
            // 
            this.rbDisplayMode2.AutoSize = true;
            this.rbDisplayMode2.Location = new System.Drawing.Point(12, 35);
            this.rbDisplayMode2.Name = "rbDisplayMode2";
            this.rbDisplayMode2.Size = new System.Drawing.Size(31, 17);
            this.rbDisplayMode2.TabIndex = 7;
            this.rbDisplayMode2.TabStop = true;
            this.rbDisplayMode2.Text = "2";
            this.rbDisplayMode2.UseVisualStyleBackColor = true;
            // 
            // rbDisplayMode1
            // 
            this.rbDisplayMode1.AutoSize = true;
            this.rbDisplayMode1.Location = new System.Drawing.Point(12, 17);
            this.rbDisplayMode1.Name = "rbDisplayMode1";
            this.rbDisplayMode1.Size = new System.Drawing.Size(31, 17);
            this.rbDisplayMode1.TabIndex = 6;
            this.rbDisplayMode1.TabStop = true;
            this.rbDisplayMode1.Text = "1";
            this.rbDisplayMode1.UseVisualStyleBackColor = true;
            // 
            // chkShowAds
            // 
            this.chkShowAds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowAds.AutoSize = true;
            this.chkShowAds.Location = new System.Drawing.Point(68, 46);
            this.chkShowAds.Name = "chkShowAds";
            this.chkShowAds.Size = new System.Drawing.Size(71, 17);
            this.chkShowAds.TabIndex = 2;
            this.chkShowAds.Text = "show ads";
            this.chkShowAds.UseVisualStyleBackColor = true;
            this.chkShowAds.CheckedChanged += new System.EventHandler(this.chkShowAds_CheckedChanged);
            this.chkShowAds.Click += new System.EventHandler(this.chkShowAds_CheckedChanged);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Location = new System.Drawing.Point(66, 13);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(67, 25);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // scContainer
            // 
            this.scContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scContainer.IsSplitterFixed = true;
            this.scContainer.Location = new System.Drawing.Point(0, 0);
            this.scContainer.Name = "scContainer";
            this.scContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scContainer.Panel1
            // 
            this.scContainer.Panel1.Controls.Add(this.pnlHeader);
            this.scContainer.Size = new System.Drawing.Size(850, 450);
            this.scContainer.SplitterDistance = 80;
            this.scContainer.SplitterWidth = 1;
            this.scContainer.TabIndex = 5;
            // 
            // Queue_Display_Master_v1_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.scContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Queue_Display_Master_v1_Form";
            this.Text = "QueueDisplay_Master_Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Queue_Display_Master_Form_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.scContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).EndInit();
            this.scContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDisplayMode2;
        private System.Windows.Forms.RadioButton rbDisplayMode1;
        private System.Windows.Forms.Button btnQuit;
        public System.Windows.Forms.SplitContainer scContainer;
        public System.Windows.Forms.CheckBox chkShowAds;
        public System.Windows.Forms.Panel pnlHeader;
        public System.Windows.Forms.Panel pnlSettings;
    }
}