using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class Queue_Display_v2_Form : Queue_Display_Master_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const string COUNTERLABELFORMAT = "{0}";

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        DataTable _counterAddresses = CounterAddress.get();

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Queue_Display_v2_Form() { InitializeComponent(); }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            if(_counterAddresses.Rows.Count > 0)
            {
                //setup table layout panel 
                tlpCounters.ColumnCount = (int)Math.Ceiling((double)tlpCounters.Width / tlpCounters.Height);
                tlpCounters.RowCount = (int)Math.Ceiling((double)_counterAddresses.Rows.Count / tlpCounters.ColumnCount);

                CounterCallStatus counterCallStatus;
                foreach (DataRow row in _counterAddresses.Rows)
                {
                    counterCallStatus = new CounterCallStatus(string.Format(COUNTERLABELFORMAT, row[CounterAddress.COL_DB_Name].ToString()), LIBUtil.Util.wrapNullable<Guid?>(row, CounterAddress.COL_DB_Id));
                    tlpCounters.Controls.Add(counterCallStatus);
                    counterCallStatus.Dock = DockStyle.Fill;
                }

                for (int i = 0; i < _counterAddresses.Rows.Count; i++)
                {
                    tlpCounters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); //resize cells to be the same size
                    tlpCounters.RowStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); //resize cells to be the same size
                    CounterCallStatus counter = ((CounterCallStatus)tlpCounters.Controls[i]);
                    counter.resizeComponents();
                }
            }

            setupControlsBasedOnRoles();

            AddEventHandlerToChildControls(this);
        }

        private void setupControlsBasedOnRoles()
        {

        }

        private void populateData()
        {
            for (int i = 0; i < _counterAddresses.Rows.Count; i++)
            {
                CounterCallStatus counter = ((CounterCallStatus)tlpCounters.Controls[i]);
                foreach(DataRow row in Queues.getLastCalledForEachCounter().Rows)
                {
                    if(LIBUtil.Util.wrapNullable<Guid>(row, Queues.COL_DB_CounterAddresses_Id) == counter.CounterAddressId)
                    {
                        counter.QueueNo = LIBUtil.Util.wrapNullable<string>(row, Queues.COL_CallNo);
                        break;
                    }
                }
            }
        }

        private void resetData()
        {

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

        private void Queue_Display_v2_Form_Shown(object sender, EventArgs e)
        {
            populateData();
        }

        private void timerRefreshInterval_Tick(object sender, EventArgs e)
        {
            populateData();
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
