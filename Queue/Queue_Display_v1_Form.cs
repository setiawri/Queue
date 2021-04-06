using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

using LIBUtil;
using System.Threading;

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

        //Call Queue
        private static List<string> _CALL_QueueNumber = new List<string>();
        private static List<string> _CALL_CounterName = new List<string>();
        private static bool _isSoundPlaying = false;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private Guid _lastCalledId;
        private bool _isShown = false;

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
            col_dgv_CounterAddresses_Name.DataPropertyName = Queues.COL_DB_CounterAddresses_Name;

            timerRefreshInterval.Interval = Settings.RefreshInterval;

            timerAds.Interval = Settings.AdInterval;
            if (isAdFolderExists())
            {
                chkShowAds.Checked = Settings.ShowAdAsDefault;
                _adsFolder = Directory.GetFiles(Settings.AdFolder);
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

            //cosmetics
            col_dgv_CounterAddresses_Name.DefaultCellStyle.BackColor = Color.DarkOrange;
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
            DataTable datatable;
            try
            {
                datatable = Queues.get(true, null, null, MAXDISPLAYEDQUEUE, null, null, Settings.QueueNoCutoffTimestamp);
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

                DataRow row = datatable.Rows[0];
                newCalledId = (Guid)row[Queues.COL_DB_Id];
                if (_lastCalledId != newCalledId)
                {
                    showLargeCallDisplay(datatable.Rows[0]);

                    _lastCalledId = newCalledId;
                    _CALL_QueueNumber.Add(row[Queues.COL_CallNo].ToString());
                    _CALL_CounterName.Add(row[Queues.COL_DB_CounterAddresses_Name].ToString());

                    if (!_isSoundPlaying)
                        bgwCaller.RunWorkerAsync();
                }
            }
        }
        
        private void playCallSound(string queueNumber, string counterName)
        {
            if (queueNumber == "")
                return;

            //generate sound list
            List<SoundPlayer> soundList = new List<SoundPlayer>();
            bool cancelPlaySound = false;
            string filepath = "";

            if (Settings.PlayNotificationSound)
                soundList.Add(Settings.notificationSound);

            foreach (char letter in queueNumber.ToCharArray())
            {
                filepath = string.Format(@"{0}\{1}.wav", Settings.SoundFolder, letter);
                if (!cancelPlaySound && File.Exists(filepath))
                    soundList.Add(new SoundPlayer(filepath));
                else
                    cancelPlaySound = true;
            }

            if (Settings.PlayCounter && !cancelPlaySound && File.Exists(Settings.TransitionSoundFile))
            {
                if (!File.Exists(Settings.TransitionSoundFile))
                    cancelPlaySound = true;
                else
                {
                    soundList.Add(new SoundPlayer(Settings.TransitionSoundFile));

                    //add counter sound
                    filepath = string.Format(@"{0}\{1}.wav", Settings.SoundFolder, counterName);
                    if (!File.Exists(filepath))
                        cancelPlaySound = true;
                    else
                        soundList.Add(new SoundPlayer(string.Format(@"{0}\{1}.wav", Settings.SoundFolder, counterName)));
                }
            }

            //Play sound
            if (cancelPlaySound)
                Settings.notificationSound.PlaySync();
            else
                foreach (SoundPlayer sound in soundList)
                    sound.PlaySync();
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
            if (!isAdFolderExists())
            {
                Util.displayMessageBoxError("Folder ads yang di set di Settings tidak valid.");
                setChkShowAds(false);
                timerAds.Stop();
            }
            else if (showAds && _adsFolder != null && _adsFolder.Length == 0)
            {
                Util.displayMessageBoxError("Tidak ada file untuk ditampilkan");
                setChkShowAds(false);
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
                lblCallingCounter.Text = row[Queues.COL_DB_CounterAddresses_Name].ToString();
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
        }

        private void timerAds_Tick(object sender, EventArgs e)
        {
            showAd();
        }

        private void timerRefreshInterval_Tick(object sender, EventArgs e)
        {
            populateDgvQueue();
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            _isShown = true;
            rollingText1.Start(Settings.RollingText, Settings.RollingTextSpeed, Settings.ROLLINGTEXTTIMERINTERVAL);
            clock1.Start(30000, ContentAlignment.MiddleRight, "{0:dddd, dd/MM/yy HH:mm}");
            timerRefreshInterval.Start();
        }

        private void BgwCaller_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _isSoundPlaying = true;
            while (_CALL_CounterName.Count > 0)
            {
                try
                {
                    playCallSound(_CALL_QueueNumber[0], _CALL_CounterName[0]);
                    _CALL_CounterName.RemoveAt(0);
                    _CALL_QueueNumber.RemoveAt(0);
                }
                catch { }
            }
            _isSoundPlaying = false;
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
