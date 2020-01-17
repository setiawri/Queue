namespace Queue
{
    partial class MasterData_v1_QueueCategories_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterData_v1_QueueCategories_Form));
            this.itxt_Code = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Description = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.panel1.SuspendLayout();
            this.pnlActionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scInputLeft)).BeginInit();
            this.scInputLeft.Panel1.SuspendLayout();
            this.scInputLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scInputRight)).BeginInit();
            this.scInputRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scInputContainer)).BeginInit();
            this.scInputContainer.Panel1.SuspendLayout();
            this.scInputContainer.Panel2.SuspendLayout();
            this.scInputContainer.SuspendLayout();
            this.pnlQuickSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(436, 28);
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 157);
            this.pnlActionButtons.Size = new System.Drawing.Size(436, 23);
            // 
            // scInputLeft
            // 
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Description);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Code);
            this.scInputLeft.Size = new System.Drawing.Size(500, 131);
            // 
            // scInputRight
            // 
            this.scInputRight.Size = new System.Drawing.Size(25, 131);
            // 
            // scMain
            // 
            this.scMain.Size = new System.Drawing.Size(436, 411);
            this.scMain.SplitterDistance = 180;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Size = new System.Drawing.Size(436, 26);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Size = new System.Drawing.Size(436, 131);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(358, 3);
            this.btnLog.Visible = false;
            // 
            // pnlQuickSearch
            // 
            this.pnlQuickSearch.Size = new System.Drawing.Size(406, 28);
            // 
            // itxt_Code
            // 
            this.itxt_Code.IsBrowseMode = false;
            this.itxt_Code.LabelText = "Code";
            this.itxt_Code.Location = new System.Drawing.Point(12, 6);
            this.itxt_Code.MaxLength = 5;
            this.itxt_Code.MultiLine = false;
            this.itxt_Code.Name = "itxt_Code";
            this.itxt_Code.PasswordChar = '\0';
            this.itxt_Code.RowCount = 1;
            this.itxt_Code.ShowDeleteButton = false;
            this.itxt_Code.ShowFilter = false;
            this.itxt_Code.ShowTextboxOnly = false;
            this.itxt_Code.Size = new System.Drawing.Size(66, 41);
            this.itxt_Code.TabIndex = 0;
            this.itxt_Code.ValueText = "";
            // 
            // itxt_Description
            // 
            this.itxt_Description.IsBrowseMode = false;
            this.itxt_Description.LabelText = "Description";
            this.itxt_Description.Location = new System.Drawing.Point(12, 47);
            this.itxt_Description.MaxLength = 100;
            this.itxt_Description.MultiLine = false;
            this.itxt_Description.Name = "itxt_Description";
            this.itxt_Description.PasswordChar = '\0';
            this.itxt_Description.RowCount = 1;
            this.itxt_Description.ShowDeleteButton = false;
            this.itxt_Description.ShowFilter = false;
            this.itxt_Description.ShowTextboxOnly = false;
            this.itxt_Description.Size = new System.Drawing.Size(234, 41);
            this.itxt_Description.TabIndex = 1;
            this.itxt_Description.ValueText = "";
            // 
            // MasterData_v1_QueueCategories_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 411);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasterData_v1_QueueCategories_Form";
            this.Text = "CATEGORIES";
            this.panel1.ResumeLayout(false);
            this.pnlActionButtons.ResumeLayout(false);
            this.scInputLeft.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scInputLeft)).EndInit();
            this.scInputLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scInputRight)).EndInit();
            this.scInputRight.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.scInputContainer.Panel1.ResumeLayout(false);
            this.scInputContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scInputContainer)).EndInit();
            this.scInputContainer.ResumeLayout(false);
            this.pnlQuickSearch.ResumeLayout(false);
            this.pnlQuickSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Code;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Description;
    }
}