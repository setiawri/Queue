using System;
using System.Data;
using System.Windows.Forms;
using LIBUtil;

namespace Queue.Reports
{
    public partial class History_Form : Form
    {
        /*******************************************************************************************************/
        #region SETTINGS
		
        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PROPERTIES

        #endregion PROPERTIES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public History_Form(): this(null) { }
        public History_Form(Guid? id) { InitializeComponent(); }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.ShowIcon = false;
			setupControlsBasedOnRoles();

            idtp_StartDate.Value = DateTime.Now.AddMonths(-1);
            idtp_EndDate.Value = DateTime.Now;

            dgvHistory.AutoGenerateColumns = false;
            col_dgvQueues_Id.DataPropertyName = Queues.COL_DB_Id;
            col_dgvQueues_CallNo.DataPropertyName = Queues.COL_CallNo;
            col_dgvQueues_CallTimestamp.DataPropertyName = Queues.COL_DB_CallTimestamp;
            col_dgvQueues_CounterAddresses_Name.DataPropertyName = Queues.COL_DB_CounterAddresses_Name;
            col_dgvQueues_Timestamp.DataPropertyName = Queues.COL_DB_Timestamp;
            col_dgvQueues_WaitTime.DataPropertyName = Queues.COL_WaitTime;
            col_dgv_VoidTimestamp.DataPropertyName = Queues.COL_DB_VoidTimestamp;

        }

		private void setupControlsBasedOnRoles() 
		{

		}
		
        private void populateData()
        {
            if(isValidToPopulateData())
            {
                DataTable data = Queues.get(false, null, null, null, idtp_StartDate.ValueAsStartDateFilter, idtp_EndDate.ValueAsEndDateFilter, null);
                data = Util.sortData(data, Queues.COL_DB_Timestamp, SortOrder.Descending, null, null);
                Util.setGridviewDataSource(dgvHistory, true, true, data);
			}
        }
		
        private bool isValidToPopulateData()
        {
			return true;
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
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            populateData();
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
