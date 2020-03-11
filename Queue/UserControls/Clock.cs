using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue.UserControls
{
    public partial class Clock : UserControl
    {
        /*******************************************************************************************************/
        #region SETTINGS

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private string _format = "{0:dddd, dd/MM/yy HH:mm}";

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Clock() { InitializeComponent(); }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            setupControlsBasedOnRoles();
        }

        private void setupControlsBasedOnRoles()
        {

        }

        private void populateData()
        {

        }

        private void resetData()
        {

        }

        public void Start(int interval, ContentAlignment textAlignment, string format)
        {
            label.TextAlign = textAlignment;
            _format = format;

            label = LIBUtil.Util.fitLabelFontSizeIntoContainer(label, this);

            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            setupControls();
            populateData();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label.Text = string.Format(_format, DateTime.Now);
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
