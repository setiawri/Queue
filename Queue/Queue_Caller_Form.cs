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
    public partial class Queue_Caller_Form : Form
    {
        /*******************************************************************************************************/
        #region SETTINGS
		
        private const string FORMTITLE = "QUEUE APP";
        private const int LASTQUEUECOUNT = 10;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private int _lastCategoryCount = 0;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Queue_Caller_Form()
        {
            InitializeComponent();

			setupControls();
        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.Text = FORMTITLE;
            Util.disableFormResize(this);

            timer1.Interval = Settings.RefreshInterval;

            Util.clearWhenSelected(dgv);
            dgv.AutoGenerateColumns = false;
            col_dgv_CalledCount.DataPropertyName = QueueCategory.COL_CalledCount;
            col_dgv_LastCalledNo.DataPropertyName = QueueCategory.COL_LastCalledNo;
            col_dgv_Count.DataPropertyName = QueueCategory.COL_QueueCount;
            col_dgv_WaitTime.DataPropertyName = QueueCategory.COL_WaitTime;
            col_dgv_CallerText.DataPropertyName = QueueCategory.COL_CallerText; //Code - description
            col_dgv_Categories_Description.DataPropertyName = QueueCategory.COL_DB_Description;
            col_dgv_QueueCategories_Id.DataPropertyName = QueueCategory.COL_DB_Id;
            col_dgv_PendingCount.DataPropertyName = QueueCategory.COL_PendingCount;
            col_dgv_CallerButton.DataPropertyName = QueueCategory.COL_DB_Code;
            Util.setGridviewColumnWordwrap(col_dgv_Categories_Description, null);
        }

        private void populateData()
        {
            Util.populateDataGridView(dgv, QueueCategory.get(false, null, null, null));

            //set button text as combination of code and description
            //DataGridViewButtonCell button;
            //foreach (DataGridViewRow row in dgv.Rows)
            //{
            //    button = ((DataGridViewButtonCell)row.Cells[col_dgv_CallerButton.Name]);
            //    button.Value = row.Cells[col_dgv_CallerText.Name].Value.ToString(); //set button text

            //    if (Convert.ToInt32(row.Cells[col_dgv_PendingCount.Name].Value) <= 0)
            //    {
            //        button.FlatStyle = FlatStyle.Popup;
            //        button.Style.ForeColor = Color.Gray;
            //    }
            //    else
            //    {
            //        button.FlatStyle = FlatStyle.Standard;
            //        button.Style.ForeColor = Color.Black;
            //    }
            //}
            
            if(_lastCategoryCount != dgv.Rows.Count)
            {
                _lastCategoryCount = dgv.Rows.Count;
                fitContent();
                setAndStartTimer();
            }
        }

		private void resetData()
		{
		
		}

        private void clearData()
        {
            dgv.DataSource = null;
            _lastCategoryCount = 0;
            fitContent();
        }

        private void fitContent()
        {
            //fit data in datagridview to form
            dgv.ScrollBars = ScrollBars.None;
            this.ClientSize = new Size(this.ClientSize.Width, 0);
            int height = 0;
            foreach (DataGridViewRow row in dgv.Rows)
                height += row.Height;

            //create space so options can always be displayed
            if (height == 0 || height < pnlOptions.Height)
                height = pnlOptions.Height - dgv.ColumnHeadersHeight;

            this.ClientSize = new Size(this.ClientSize.Width, height + pnlInput.Height + dgv.ColumnHeadersHeight);

            Util.setPosition(this, Position.Bottom, Position.Right);
        }

        private void showLastCalled(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                lblLastCalled.Visible = false;
            else
            {
                lblLastCalled.Visible = true;
                lblLastCalled.Text = string.Format("Memanggil: {0}", value);
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Helper.processCmdKey(this, keyData);

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Queue_Caller_Form_Shown(object sender, EventArgs e)
        {
            fitContent();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Util.isColumnMatch(sender, e, col_dgv_CallerButton))
            {
                pnlOptions.Visible = false;
                
                showLastCalled(Queues.callNext(Util.wrapClickedCellValueNullable<Guid>(col_dgv_QueueCategories_Id, e), Helper.counter.Id));
                populateData();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Settings.CallerDisplay_Locked)
                populateData();
            else if (DateTime.Now > Helper.TEMP_Caller_Stop_Time)
            {
                timer1.Stop();
                clearData();
            }
        }

        private void btnCallPrevious_Click(object sender, EventArgs e)
        {
            if (!ddlCalled.isValidSelectedValue())
                Util.inputError<LIBUtil.Desktop.UserControls.Dropdownlist>(ddlCalled, "Pilih nomor antrian");
            else
                Queues.call((Guid)ddlCalled.SelectedValue, Helper.counter.Id);

            showLastCalled(((DataRowView)ddlCalled.SelectedItem)[Queues.COL_CallNo].ToString());
        }

        private void txtFilterCalled_TextChanged(object sender, EventArgs e)
        {
            ddlCalled.Filter = string.Format("{0} LIKE '%{1}%'", Queues.COL_CallNo, txtFilterCalled.Text);
        }

        private void lnkOptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void btnShowQueue_Click(object sender, EventArgs e)
        {
            pnlOptions.Visible = false;
            populateData();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setAndStartTimer()
        {
            Helper.TEMP_Caller_Stop_Time = DateTime.Now.AddMilliseconds(Settings.RefreshInterval);
            timer1.Start();
        }

        private void pbUpdate_Click(object sender, EventArgs e)
        {
            pnlOptions.Visible = !pnlOptions.Visible;
            
            if (pnlOptions.Visible)
                Queues.populateDropDownList(ddlCalled, true, LASTQUEUECOUNT);
        }

        private void pbLock_Click(object sender, EventArgs e)
        {
            pnlOptions.Visible = false;
            pbLock.Visible = false;
            pbUnlock.Visible = true;
            populateData();
            Settings.CallerDisplay_Locked = true;
            timer1.Start();
        }

        private void pbUnlock_Click(object sender, EventArgs e)
        {
            pnlOptions.Visible = false;
            pbLock.Visible = true;
            pbUnlock.Visible = false;
            Settings.CallerDisplay_Locked = false;
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
