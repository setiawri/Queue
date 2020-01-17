using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LIBUtil;

namespace Queue
{
    public partial class Queue_Display_v1_Form : Queue_Display_Master_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const int MAXDISPLAYEDQUEUE = 20;
        private Color _HeaderColor_DEFAULT;
        private Color _HeaderColor_ERROR = Color.Red;

        //ADS
        private string[] _adsFolder = null;
        private int currentAdIndex = -1;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private Guid _lastCalledId;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Queue_Display_v1_Form() { InitializeComponent(); }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            setupControlsBasedOnRoles();

            dgv.ScrollBars = ScrollBars.None;
            Util.clearWhenSelected(dgv);
            dgv.AutoGenerateColumns = false;
            col_dgv_NoAntrian.DataPropertyName = Queues.COL_CallNo;
            col_dgv_CounterAddresses_Name.DataPropertyName = Queues.COL_CounterAddresses_Name;

            timerRefreshInterval.Interval = Settings.RefreshInterval;

            timerAds.Interval = Settings.AdInterval;
            if (!isAdFolderExists())
                chkShowAds.Enabled = false;
            else
            {
                chkShowAds.Checked = Settings.ShowAdAsDefault;
                _adsFolder = System.IO.Directory.GetFiles(Settings.AdFolder);
                if (chkShowAds.Checked)
                    showAd();
            }

            lblCallingNo.Height = lblCallingCounter.Height = (pnlDisplay.Height - 100) / 2; //set height to show nicely
            //Util.fitTextToLabelHeight(lblCallingNo);
            //Util.fitTextToLabelHeight(lblCallingCounter);

            lblCallingNo.Visible = false;
            lblCallingCounter.Visible = false;
            lblSilahkanKeCounter.Visible = false;

            AddEventHandlerToChildControls(this);
        }

        private void setupControlsBasedOnRoles()
        {

        }

        private void populateData()
        {
            populateDgvQueue();

        }

        private void resetData()
        {

        }
        private void populateDgvQueue()
        {
            //            Util.displayMessageBox("", Util.isDBConnectionAvailable(Properties.Resources.Q, false, false).ToString());
            
            DataTable datatable;
            try
            {
                datatable = Queues.get(true, null, null, MAXDISPLAYEDQUEUE);
                if (pnlHeader.BackColor == _HeaderColor_ERROR)
                    pnlHeader.BackColor = _HeaderColor_DEFAULT;
            }
            catch {
                //save default header color
                if(pnlHeader.BackColor != _HeaderColor_ERROR)
                    _HeaderColor_DEFAULT = pnlHeader.BackColor;

                //set header color to error
                pnlHeader.BackColor = _HeaderColor_ERROR;

                return;
            }

            Util.populateDataGridView(dgv, datatable);

            Guid newCalledId;
            if (datatable.Rows.Count > 0)
            {
                //highlight first row only
                //dgv.Rows[0].DefaultCellStyle.ForeColor = LASTCALLEDHIGHLIGHTCOLOR;
                //if (dgv.Rows.Count > 1)
                //    dgv.Rows[1].DefaultCellStyle.ForeColor = dgv.DefaultCellStyle.ForeColor;

                newCalledId = (Guid)datatable.Rows[0][Queues.COL_DB_Id];
                if (_lastCalledId != newCalledId)
                {
                    _lastCalledId = newCalledId;
                    Settings.notificationSound.Play();

                    showLargeCallDisplay(datatable.Rows[0]);
                }
            }
        }

        private bool isAdFolderExists()
        {
            return !string.IsNullOrWhiteSpace(Settings.AdFolder) && System.IO.Directory.Exists(Settings.AdFolder);
        }

        private void showAd()
        {
            if (_adsFolder != null && _adsFolder.Length > 0)
            {
                if (currentAdIndex == -1 || currentAdIndex == _adsFolder.Length - 1)
                {
                    currentAdIndex = 0;
                }
                else
                {
                    currentAdIndex++;
                }
                pnlDisplay.BackgroundImage = Image.FromFile(_adsFolder[currentAdIndex]);
            }
        }

        protected override void chkShowAds_CheckedChanged()
        {
            bool showAds = chkShowAds.Checked;
            if (showAds && _adsFolder != null && _adsFolder.Length == 0)
            {
                Util.displayMessageBoxError("Tidak ada file untuk ditampilkan");
                chkShowAds.Checked = false;
                timerAds.Stop();
            }
            else
            {
                Settings.ShowAdAsDefault = showAds;

                bool showLargeCallDisplay = !showAds && dgv.Rows.Count > 0;

                lblCallingCounter.Visible = showLargeCallDisplay;
                lblSilahkanKeCounter.Visible = showLargeCallDisplay;
                lblCallingNo.Visible = showLargeCallDisplay;
                if (showLargeCallDisplay)
                    lblSilahkanKeCounter.BringToFront(); //needs to do this so this label doesn't get hidden behind the other labels

                if (showAds)
                {
                    showAd();
                    timerAds.Start();
                }
                else
                {
                    pnlDisplay.BackgroundImage = null;
                    timerAds.Stop();

                    if (showLargeCallDisplay)
                    {
                        DataTable datatable = (DataTable)dgv.DataSource;
                        this.showLargeCallDisplay(datatable.Rows[0]);
                    }
                }
            }
        }

        private void showLargeCallDisplay(DataRow row)
        {
            if (!chkShowAds.Checked)
            {
                lblCallingNo.Visible = true;
                lblCallingCounter.Visible = true;
                lblSilahkanKeCounter.Visible = true;
                lblCallingNo.Text = row[Queues.COL_CallNo].ToString();
                lblCallingCounter.Text = row[Queues.COL_CounterAddresses_Name].ToString();
                Util.fitTextToLabel(lblCallingNo);
                Util.fitTextToLabel(lblCallingCounter);
            }
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            setupControls();
            populateData();
            timerRefreshInterval.Start();
            rollingText1.Start(Settings.RollingText, Settings.RollingTextSpeed, Settings.ROLLINGTEXTTIMERINTERVAL);
            clock1.Start(30000, ContentAlignment.MiddleRight, "{0:dddd, dd/MM/yy HH:mm}");
        }

        private void timerAds_Tick(object sender, EventArgs e)
        {
            showAd();
        }

        private void timerRefreshInterval_Tick(object sender, EventArgs e)
        {
            populateDgvQueue();
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
