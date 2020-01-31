using System;
using System.Windows.Forms;

using LIBUtil;
using LIBUtil.Desktop.Classes;

namespace Queue
{
    public partial class Settings_Form : Form
    {
        /*******************************************************************************************************/
        #region SETTINGS
            
        private const string FORMTITLE = "SETTINGS";
        private const int MAXROLLINGTEXTSPEED = 9;
        private const int MINROLLINGTEXTSPEED = 1;
        
        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES
            
        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private ToolTip _rollingTextTooltip = new ToolTip();

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Settings_Form()
        {
            InitializeComponent();

            //setupControls();
        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.Text = FORMTITLE;
            Util.disableFormResize(this);
            
            gridPrintLayout.AutoGenerateColumns = false;
            //Util.clearWhenSelected(gridPrintLayout);
            col_gridPrintLayout_Id.DataPropertyName = PrintLayout.COL_DB_Id;
            col_gridPrintLayout_LineNumber.DataPropertyName = PrintLayout.COL_DB_LineNumber;
            col_gridPrintLayout_Hide.DataPropertyName = PrintLayout.COL_DB_Hide;
            col_gridPrintLayout_Text.DataPropertyName = PrintLayout.COL_DB_Text;
            col_gridPrintLayout_FontSize.DataPropertyName = PrintLayout.COL_DB_FontSize;
            col_gridPrintLayout_TextAlign_enumid.DataPropertyName = PrintLayout.COL_DB_TextAlign_enumid;
            col_gridPrintLayout_TextAlign_description.DataPropertyName = PrintLayout.COL_TextAlign_description;
            addContextMenu();

            if (!DBConnection.hasDBConnection)
            {
                //Util.displayMessageBoxError("Koneksi ke database tidak berhasil. Silahkan coba lagi atau perbaiki informasi koneksi.");

                Util.enableControls(false, tpSounds, tpGeneral, tpMasterData, tpPrinter);
                tcSettings.SelectedTab = tpDatabase;
            }
            else
            {
                Util.enableControls(true, tpSounds, tpGeneral, tpMasterData, tpPrinter);
            }
        }

        private void populateData()
        {
            itxt_ServerName.ValueText = DBConnection.ServerName;
            itxt_DatabaseName.ValueText = DBConnection.DatabaseName;

            if(DBConnection.hasDBConnection)
            {
                txtHeaderText.Text = Settings.HeaderText;
                txtRollingText.Text = Settings.RollingText;
                lblRollingTextSpeed.Text = Settings.RollingTextSpeed.ToString();
                lblRefreshInterval.Text = (Settings.RefreshInterval / 1000).ToString();
                lblAdInterval.Text = Settings.AdInterval.ToString();
                txtAdsFolder.Text = Settings.AdFolder;

                gridPrintLayout.DataSource = PrintLayout.get(null);
                in_PrintAreaWidth.Value = Settings.PrintAreaWidth;
                in_PrintQty.Value = Settings.PrintQty;

                txtSoundFolder.Text = Settings.SoundFolder;
                txtTransitionSoundFilepath.Text = Settings.TransitionSoundFile;
                chkCounter.Checked = Settings.PlayCounter;
                chkNotificationSound.Checked = Settings.PlayNotificationSound;
            }
        }

        private void resetData()
        {

        }

        public void addContextMenu()
        {
            gridPrintLayout.ContextMenuStrip = new ContextMenuStrip();
            foreach (PrintLayoutTextAlign item in Util.GetEnumItems<PrintLayoutTextAlign>())
                gridPrintLayout.ContextMenuStrip.Items.Add(new ToolStripMenuItem(Util.GetEnumDescription(item), null, gridPrintLayout_contextMenu_Click));
        }

        public void gridPrintLayout_contextMenu_Click(object sender, EventArgs args)
        {
            if (gridPrintLayout.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gridPrintLayout.SelectedRows[0];
                row.Cells[col_gridPrintLayout_TextAlign_enumid.Name].Value = (int)Util.parseEnum<PrintLayoutTextAlign>(sender.ToString());
                row.Cells[col_gridPrintLayout_TextAlign_description.Name].Value = sender.ToString();
            }
        }

        private void updateRollingTextSpeed(int value)
        {
            int newValue = Settings.RollingTextSpeed + value;
            if (newValue >= MINROLLINGTEXTSPEED && newValue <= MAXROLLINGTEXTSPEED)
            {
                Settings.RollingTextSpeed = newValue;
                lblRollingTextSpeed.Text = newValue.ToString();
            }
        }

        private void updateRefreshInterval(int value)
        {
            int newValue = Settings.RefreshInterval/1000 + value;
            if (newValue > 0)
            {
                Settings.RefreshInterval = newValue * 1000;
                lblRefreshInterval.Text = newValue.ToString();
            }
        }

        private void updateAdInterval(int value)
        {
            int newValue = Settings.AdInterval/1000 + value;
            if (newValue > 0)
            {                
                Settings.AdInterval = newValue * 1000;
                lblAdInterval.Text = newValue.ToString();
            }
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            setupControls();
            populateData();
        }

        private void btnResetQueues_Click(object sender, EventArgs e)
        {
            Queues.deleteAll();
        }

        private void btnUpdateCategories_Click(object sender, EventArgs e)
        {
            Util.displayForm(this, new MasterData_v1_QueueCategories_Form());
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(DBConnection.hasDBConnection)
                Helper.processCmdKey(this, keyData);

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnCounterAddresses_Click(object sender, EventArgs e)
        {
            Util.displayForm(this, new MasterData_v1_CounterAddresses_Form());
        }

        private void btnSaveDatabaseInfo_Click(object sender, EventArgs e)
        {            
            DBConnection.update(itxt_ServerName, itxt_DatabaseName);
            if (Helper.isDBConnectionAvailable())
                Util.displayMessageBoxSuccess("Connection test successful");
            setupControls();
            populateData();
        }

        private void btnTestPrinter_Click(object sender, EventArgs e)
        {
            Helper.printReceipt("XXX");
        }

        private void btnSavePrinterSettings_Click(object sender, EventArgs e)
        {
            if(isInputValid())
            {
                Settings.PrintAreaWidth = in_PrintAreaWidth.ValueInt;
                Settings.PrintQty = in_PrintQty.ValueInt;

                using (System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(DBConnection.ConnectionString))
                {
                    foreach (DataGridViewRow row in gridPrintLayout.Rows)
                    {
                        PrintLayout.update(sqlConnection,
                            Util.wrapNullable<Guid>(row, col_gridPrintLayout_Id.Name),
                            Util.wrapNullable<bool>(row, col_gridPrintLayout_Hide.Name),
                            Util.wrapNullable<string>(row, col_gridPrintLayout_Text.Name),
                            Util.wrapNullable<int>(row, col_gridPrintLayout_FontSize.Name),
                            Util.wrapNullable<int>(row, col_gridPrintLayout_TextAlign_enumid.Name));
                    }
                }
                
                populateData();
                Util.displayMessageBoxSuccess("Saved");
            }
        }

        private bool isInputValid()
        {
            return true;
        }

        private void btnAddPrintLine_Click(object sender, EventArgs e)
        {
            PrintLayout.add();
            populateData();
        }

        private void gridPrintLayout_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if(Util.isColumnMatch(sender, e, col_gridPrintLayout_FontSize))
                Util.displayMessageBoxError("Invalid Font Size");
        }
        
        private void gridPrintLayout_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            Util.displayContextMenu(sender, e);
        }

        private void gridPrintLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Util.isColumnMatch(sender, e, col_gridPrintLayout_delete))
            {
                PrintLayout.delete((Guid)Util.getClickedRowValue(sender, e, col_gridPrintLayout_Id.Index));
                populateData();
            }
        }

        private void btnSaveRollingText_Click(object sender, EventArgs e)
        {
            Settings.RollingText = txtRollingText.Text;
            Util.displayMessageBoxSuccess("Saved");
        }

        private void btnRollingTextSpeedUp_Click(object sender, EventArgs e)
        {
            updateRollingTextSpeed(1);
        }

        private void btnRollingTextSpeedDown_Click(object sender, EventArgs e)
        {
            updateRollingTextSpeed(-1);
        }

        private void txtRollingText_MouseLeave(object sender, EventArgs e)
        {
            _rollingTextTooltip.RemoveAll();
        }

        private void txtRollingText_MouseHover(object sender, EventArgs e)
        {
            _rollingTextTooltip.Show(txtRollingText.Text, txtRollingText);
        }

        private void btnDecreaseRefreshInterval_Click(object sender, EventArgs e)
        {
            updateRefreshInterval(-1);
        }

        private void btnIncreaseRefreshInterval_Click(object sender, EventArgs e)
        {
            updateRefreshInterval(1);
        }
        
        private void txtAdsFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    txtAdsFolder.Text = Settings.AdFolder = fbd.SelectedPath;
            }
        }

        private void btnAdIntervalSpeedDown_Click(object sender, EventArgs e)
        {
            updateAdInterval(-1);
        }

        private void btnAdIntervalSpeedUp_Click(object sender, EventArgs e)
        {
            updateAdInterval(1);
        }

        private void btnSaveHeaderText_Click(object sender, EventArgs e)
        {
            Settings.HeaderText = txtHeaderText.Text;
            Util.displayMessageBoxSuccess("Saved");
        }

        private void Settings_Form_Shown(object sender, EventArgs e)
        {

        }

        private void txtSoundFolder_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                    txtSoundFolder.Text = Settings.SoundFolder = dialog.SelectedPath;
            }
        }

        private void txtFilepathForTransitionSound_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                    txtTransitionSoundFilepath.Text = Settings.TransitionSoundFile = dialog.FileName;
            }
        }

        private void ChkNotificationSound_CheckedChanged(object sender, EventArgs e)
        {
            Settings.PlayNotificationSound = chkNotificationSound.Checked;
        }

        private void ChkCounter_CheckedChanged(object sender, EventArgs e)
        {
            Settings.PlayCounter = chkCounter.Checked;
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
