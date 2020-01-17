namespace Queue
{
    partial class MasterData_v1_CounterAddresses_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterData_v1_CounterAddresses_Form));
            this.itxt_Name = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_IPAddress = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.iddl_DefaultForms = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(307, 28);
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 177);
            this.pnlActionButtons.Size = new System.Drawing.Size(307, 23);
            // 
            // scInputLeft
            // 
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.iddl_DefaultForms);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_IPAddress);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Name);
            this.scInputLeft.Size = new System.Drawing.Size(500, 151);
            // 
            // scInputRight
            // 
            this.scInputRight.Size = new System.Drawing.Size(25, 151);
            // 
            // scMain
            // 
            this.scMain.Size = new System.Drawing.Size(307, 404);
            this.scMain.SplitterDistance = 200;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Size = new System.Drawing.Size(307, 26);
            this.pnlButtons.Controls.SetChildIndex(this.btnSearch, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnUpdate, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnAdd, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnLog, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnDelete, 0);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Size = new System.Drawing.Size(307, 151);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(311, 2);
            this.btnLog.Visible = false;
            // 
            // itxt_Name
            // 
            this.itxt_Name.IsBrowseMode = false;
            this.itxt_Name.LabelText = "Counter";
            this.itxt_Name.Location = new System.Drawing.Point(9, 53);
            this.itxt_Name.MaxLength = 20;
            this.itxt_Name.MultiLine = false;
            this.itxt_Name.Name = "itxt_Name";
            this.itxt_Name.RowCount = 1;
            this.itxt_Name.ShowTextboxOnly = false;
            this.itxt_Name.Size = new System.Drawing.Size(180, 41);
            this.itxt_Name.TabIndex = 1;
            this.itxt_Name.ValueText = "";
            // 
            // itxt_IPAddress
            // 
            this.itxt_IPAddress.IsBrowseMode = false;
            this.itxt_IPAddress.LabelText = "IP Address";
            this.itxt_IPAddress.Location = new System.Drawing.Point(9, 6);
            this.itxt_IPAddress.MaxLength = 15;
            this.itxt_IPAddress.MultiLine = false;
            this.itxt_IPAddress.Name = "itxt_IPAddress";
            this.itxt_IPAddress.RowCount = 1;
            this.itxt_IPAddress.ShowTextboxOnly = false;
            this.itxt_IPAddress.Size = new System.Drawing.Size(180, 41);
            this.itxt_IPAddress.TabIndex = 0;
            this.itxt_IPAddress.ValueText = "";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(230, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // iddl_DefaultForms
            // 
            this.iddl_DefaultForms.DisableTextInput = false;
            this.iddl_DefaultForms.HideFilter = true;
            this.iddl_DefaultForms.HideUpdateLink = true;
            this.iddl_DefaultForms.LabelText = "Default Form";
            this.iddl_DefaultForms.Location = new System.Drawing.Point(9, 100);
            this.iddl_DefaultForms.Name = "iddl_DefaultForms";
            this.iddl_DefaultForms.SelectedItem = null;
            this.iddl_DefaultForms.SelectedValue = null;
            this.iddl_DefaultForms.ShowDropdownlistOnly = false;
            this.iddl_DefaultForms.Size = new System.Drawing.Size(180, 41);
            this.iddl_DefaultForms.TabIndex = 2;
            // 
            // MasterData_v1_CounterAddresses_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 404);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasterData_v1_CounterAddresses_Form";
            this.Text = "COUNTERS";
            this.Shown += new System.EventHandler(this.MasterData_v1_CounterAddresses_Form_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Name;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_IPAddress;
        private System.Windows.Forms.Button btnDelete;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_DefaultForms;
    }
}