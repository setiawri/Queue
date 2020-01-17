using System;
using System.Drawing;
using System.Windows.Forms;

namespace Queue
{
    public partial class CounterCallStatus : UserControl
    {
        /*******************************************************************************************************/
        #region SETTINGS

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public string QueueNo { get { return label.Text; } set { label.Text = value; } }
        public Guid CounterAddressId;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private int _originalWidth;
        private float _originalCounterFontSize;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public CounterCallStatus(): this(null, null) { }
        public CounterCallStatus(string counterName, Guid? CounterAddresses_Id)
        {
            InitializeComponent();

            _originalWidth = this.Width;
            _originalCounterFontSize = gb.Font.Size;

            gb.Text = counterName;
            CounterAddressId = (Guid)CounterAddresses_Id;
        }

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

        public void resizeComponents()
        {
            this.Padding = new Padding((int)Math.Round(this.Width * (float)0.05));
            gb.Font = new Font(gb.Font.FontFamily, _originalCounterFontSize * (this.Width - this.Padding.All) / _originalWidth); //multiply by ratio of current width / original width
            label.Text = "A";
            LIBUtil.Util.fitTextToLabelHeight(label);
            label.Text = "";
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            setupControls();
            populateData();
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
