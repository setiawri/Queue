using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Media;

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

        private const string COL_Filename = "Filename";
        private const string COL_Filepath = "Filepath";

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

            dgvSoundFiles.AutoGenerateColumns = false;
            col_dgvSoundFiles_Filename.DataPropertyName = COL_Filename;
            col_dgvSoundFiles_Filepath.DataPropertyName = COL_Filepath;
            Util.clearWhenSelected(dgvSoundFiles);

            //Queue Number Reset Settings
            this.rbManualQueueNoReset.CheckedChanged -= new System.EventHandler(this.QueueNoReset_Changed);
            this.rbAutomaticQueueNoReset.CheckedChanged -= new System.EventHandler(this.QueueNoReset_Changed);
            this.in_AutomaticQueueNoResetHour.ValueChanged -= new System.EventHandler(this.QueueNoReset_Changed);
            rbManualQueueNoReset.Checked = Settings.ManualQueueNoReset;
            rbAutomaticQueueNoReset.Checked = !rbManualQueueNoReset.Checked;
            in_AutomaticQueueNoResetHour.Value = Settings.AutomaticQueueNoResetHour;
            lblQueueNoCutoffTimestamp.Text = string.Format("Current Cut Off Time: {0:dd/MM/yy HH:mm}", Settings.QueueNoCutoffTimestamp);
            this.rbManualQueueNoReset.CheckedChanged += new System.EventHandler(this.QueueNoReset_Changed);
            this.rbAutomaticQueueNoReset.CheckedChanged += new System.EventHandler(this.QueueNoReset_Changed);
            this.in_AutomaticQueueNoResetHour.ValueChanged += new System.EventHandler(this.QueueNoReset_Changed);

            Util.enableControls(true, tpSounds, tpGeneral, tpData, tpPrinter, pnlDatabaseConnection);
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

        private void testConnectionAndValidateLicense()
        {
            if (!DBConnection.hasDBConnection)
            {
                Util.enableControls(false, tpSounds, tpGeneral, tpData, tpPrinter);
                pnlLicense.Visible = false;
                tcSettings.SelectedTab = tpDatabase;
                itxt_ServerName.focus();
            }
            else if(!License.isDeviceRegistered)
            {
                itxt_ServerName.ValueText = DBConnection.ServerName;
                itxt_DatabaseName.ValueText = DBConnection.DatabaseName;
                Util.enableControls(false, tpSounds, tpGeneral, tpData, tpPrinter);
                tcSettings.SelectedTab = tpDatabase;

                pnlLicense.Visible = true;
                btnSubmitLicense.Visible = true;
                itxt_License.focus();
            }
            else
            {
                pnlLicense.Visible = false;
                setupControls();
                populateData();
            }
        }

        private bool testDBConnectionSuccessful()
        {
            if (Helper.isDBConnectionAvailable())
            {
                Util.displayMessageBoxSuccess("Connection test successful");
                return true;
            }
            return false;
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            testConnectionAndValidateLicense();
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            if (pnlLicense.Visible)
                itxt_License.focus();
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
            testDBConnectionSuccessful();
            testConnectionAndValidateLicense();
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

                foreach (DataGridViewRow row in gridPrintLayout.Rows)
                {
                    PrintLayout.update(DBConnection.ActiveSqlConnection,
                        Util.wrapNullable<Guid>(row, col_gridPrintLayout_Id.Name),
                        Util.wrapNullable<bool>(row, col_gridPrintLayout_Hide.Name),
                        Util.wrapNullable<string>(row, col_gridPrintLayout_Text.Name),
                        Util.wrapNullable<int>(row, col_gridPrintLayout_FontSize.Name),
                        Util.wrapNullable<int>(row, col_gridPrintLayout_TextAlign_enumid.Name));
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

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            Util.displayForm(this, new Reports.History_Form());       
        }

        private void BtnSaveLicense_Click(object sender, EventArgs e)
        {
            if (License.validate(itxt_License.ValueText))
                testConnectionAndValidateLicense();
            else
            {
                Util.displayMessageBoxError("Invalid License.");
                itxt_License.focus();
            }
        }

        private void BtnLoadSoundFiles_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtSoundFolder.Text))
            {
                Util.displayMessageBoxError("Folder tidak ditemukan.");
                Util.setGridviewDataSource(dgvSoundFiles, false, false, null);
            }
            else
            {
                DataTable data = new DataTable();
                DataRow row;

                Util.addColumnToTable<string>(data, COL_Filename, "a");
                Util.addColumnToTable<string>(data, COL_Filepath, null);
                foreach (string filepath in Directory.GetFiles(txtSoundFolder.Text))
                {
                    row = data.NewRow();
                    row[COL_Filename] = filepath.Substring(filepath.LastIndexOf('\\') + 1);
                    row[COL_Filepath] = filepath;
                    data.Rows.Add(row);
                }
                Util.setGridviewDataSource(dgvSoundFiles, false, false, data);
            }
        }

        private void DgvSoundFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string filepath = Util.getClickedRowValue(sender, e, col_dgvSoundFiles_Filepath).ToString();
            if (!File.Exists(filepath))
                Util.displayMessageBoxError("File is no longer available");
            else
                new SoundPlayer(filepath).PlaySync();
        }

        private void QueueNoReset_Changed(object sender, EventArgs e)
        {
            Settings.ManualQueueNoReset = rbManualQueueNoReset.Checked;
            Settings.AutomaticQueueNoResetHour = in_AutomaticQueueNoResetHour.ValueInt;
            if (rbAutomaticQueueNoReset.Checked)
            {
                DateTime newCutoffTimestamp = Settings.getAutomaticQueueNoResetTimestamp(DateTime.Now);
                Settings.QueueNoCutoffTimestamp = newCutoffTimestamp;
                Queues.update_VoidTimestamp(newCutoffTimestamp);
                lblQueueNoCutoffTimestamp.Text = string.Format("Current Cut Off Time: {0:dd/MM/yy HH:mm}", newCutoffTimestamp);
            }
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
