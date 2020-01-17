namespace Queue
{
    partial class Queue_Display_v2_Form
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
            this.scContent = new System.Windows.Forms.SplitContainer();
            this.tlpCounters = new System.Windows.Forms.TableLayoutPanel();
            this.scFooter = new System.Windows.Forms.SplitContainer();
            this.rollingText1 = new Queue.UserControls.RollingText();
            this.clock1 = new Queue.UserControls.Clock();
            this.timerRefreshInterval = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.scFooter)).BeginInit();
            this.scFooter.Panel1.SuspendLayout();
            this.scFooter.Panel2.SuspendLayout();
            this.scFooter.SuspendLayout();
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
            this.scContent.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scContent.IsSplitterFixed = true;
            this.scContent.Location = new System.Drawing.Point(0, 0);
            this.scContent.Name = "scContent";
            this.scContent.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scContent.Panel1
            // 
            this.scContent.Panel1.Controls.Add(this.tlpCounters);
            // 
            // scContent.Panel2
            // 
            this.scContent.Panel2.Controls.Add(this.scFooter);
            this.scContent.Panel2MinSize = 50;
            this.scContent.Size = new System.Drawing.Size(850, 369);
            this.scContent.SplitterDistance = 318;
            this.scContent.SplitterWidth = 1;
            this.scContent.TabIndex = 0;
            // 
            // tlpCounters
            // 
            this.tlpCounters.AutoSize = true;
            this.tlpCounters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCounters.ColumnCount = 2;
            this.tlpCounters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCounters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCounters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCounters.Location = new System.Drawing.Point(0, 0);
            this.tlpCounters.Name = "tlpCounters";
            this.tlpCounters.RowCount = 2;
            this.tlpCounters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCounters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCounters.Size = new System.Drawing.Size(850, 318);
            this.tlpCounters.TabIndex = 0;
            // 
            // scFooter
            // 
            this.scFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scFooter.Location = new System.Drawing.Point(0, 0);
            this.scFooter.Name = "scFooter";
            // 
            // scFooter.Panel1
            // 
            this.scFooter.Panel1.Controls.Add(this.rollingText1);
            // 
            // scFooter.Panel2
            // 
            this.scFooter.Panel2.Controls.Add(this.clock1);
            this.scFooter.Size = new System.Drawing.Size(850, 50);
            this.scFooter.SplitterDistance = 503;
            this.scFooter.SplitterWidth = 1;
            this.scFooter.TabIndex = 0;
            // 
            // rollingText1
            // 
            this.rollingText1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rollingText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollingText1.Location = new System.Drawing.Point(0, 0);
            this.rollingText1.Name = "rollingText1";
            this.rollingText1.Size = new System.Drawing.Size(503, 50);
            this.rollingText1.TabIndex = 2;
            // 
            // clock1
            // 
            this.clock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clock1.Location = new System.Drawing.Point(0, 0);
            this.clock1.Name = "clock1";
            this.clock1.Size = new System.Drawing.Size(346, 50);
            this.clock1.TabIndex = 1;
            // 
            // timerRefreshInterval
            // 
            this.timerRefreshInterval.Tick += new System.EventHandler(this.timerRefreshInterval_Tick);
            // 
            // Queue_Display_v2_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Name = "Queue_Display_v2_Form";
            this.Text = "Queue_Display_v2_Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Queue_Display_v2_Form_Shown);
            this.scContainer.Panel1.ResumeLayout(false);
            this.scContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).EndInit();
            this.scContainer.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.scContent.Panel1.ResumeLayout(false);
            this.scContent.Panel1.PerformLayout();
            this.scContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).EndInit();
            this.scContent.ResumeLayout(false);
            this.scFooter.Panel1.ResumeLayout(false);
            this.scFooter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scFooter)).EndInit();
            this.scFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scContent;
        private System.Windows.Forms.SplitContainer scFooter;
        private UserControls.RollingText rollingText1;
        private UserControls.Clock clock1;
        private System.Windows.Forms.TableLayoutPanel tlpCounters;
        private System.Windows.Forms.Timer timerRefreshInterval;
    }
}