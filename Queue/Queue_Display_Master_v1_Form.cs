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
    public partial class Queue_Display_Master_v1_Form : Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const string FORMTITLE = "";

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES        

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES
            
        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Queue_Display_Master_v1_Form()
        {
            InitializeComponent();            
        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.Text = FORMTITLE;
            lblAppVersion.Text = Settings.APPVERSION;
            this.WindowState = FormWindowState.Maximized;

            lblHeaderText.Text = Settings.HeaderText;
            Util.relocateToCenter(lblHeaderText);

            if (Settings.DisplayFormMode == 1)
                rbDisplayMode1.Checked = true;
            else
                rbDisplayMode2.Checked = true;

            rbDisplayMode2.Visible = false;
        }

        public void AddEventHandlerToChildControls(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                child.MouseClick += new MouseEventHandler(MouseRightClick);
                if (child.HasChildren)
                    AddEventHandlerToChildControls(child);
            }
        }
        
        //in order for the cursor to properly hide/show, the settings panel is visible when form is shown
        //and this method is run once to hide the settings panel and the cursor
        //on form closed event, the cursor is shown again so cursor works properly on the next form
        private void clickSettings()
        {
            pnlSettings.Visible = !pnlSettings.Visible;

            /* **************************************************************************************************************
             * 
             * MUST COMMENT WHILE EDITING CODE. OTHERWISE, CURSOR DISAPPEARS IN VISUAL STUDIO BECAUSE OF THESE LINE OF CODES*
             * 
             ****************************************************************************************************************/
            //if (!pnlSettings.Visible)
            //    Cursor.Hide();
            //else
            //    Cursor.Show();
        }

        private bool isAdFolderExists()
        {
            return !string.IsNullOrWhiteSpace(Settings.AdFolder) && System.IO.Directory.Exists(Settings.AdFolder);
        }

        private void updateDisplayMode(int mode)
        {
            Settings.DisplayFormMode = mode;
            Helper.setNewForm(this, Helper.selectedDisplayForm());
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            setupControls();
            pnlHeader.Focus();
            clickSettings();
            //Queues.clearQueueIfStartOfDay();

            //rollingText1.Start(Settings.RollingText, Settings.RollingTextSpeed, Settings.ROLLINGTEXTTIMERINTERVAL);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Helper.processCmdKey(this, keyData);

            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbUpdate_Click(object sender, EventArgs e)
        {
            pnlSettings.Visible = !pnlSettings.Visible;
        }

        private void Queues_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pnlSettings.Visible)
                clickSettings();
        }

        private void chkShowAds_CheckedChanged(object sender, EventArgs e)
        {
            chkShowAds_CheckedChanged();
        }        
        protected virtual void chkShowAds_CheckedChanged() { }

        private void rbDisplayMode1_CheckedChanged(object sender, EventArgs e)
        {
            updateDisplayMode(1);
        }

        private void rbDisplayMode2_CheckedChanged(object sender, EventArgs e)
        {
            updateDisplayMode(2);
        }

        private void MouseRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                clickSettings();
        }

        private void Queue_Display_Master_Form_Shown(object sender, EventArgs e)
        {
            this.rbDisplayMode1.CheckedChanged += new System.EventHandler(this.rbDisplayMode1_CheckedChanged);
            this.rbDisplayMode2.CheckedChanged += new System.EventHandler(this.rbDisplayMode2_CheckedChanged);
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
