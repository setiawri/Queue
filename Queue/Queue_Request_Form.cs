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
    public partial class Queue_Request_Form : Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const string FORMTITLE = "";
        private const int WIDTHINCREMENT = 15;
        private const int SMALLSTEP = 3;
        private const int LARGESTEP = 7;
        private string _printString;
        private const double DESCRIPTIONFONTSIZEFACTOR = 0.5;
        private const int MINIMUMFONTSIZE = 20;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Queue_Request_Form()
        {
            InitializeComponent();

            setupControls();
        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.Cursor = null;
            this.Text = FORMTITLE;
            
            this.WindowState = FormWindowState.Maximized;
            Util.clearWhenSelected(dgv);
            dgv.AutoGenerateColumns = false;
            dgv.ScrollBars = ScrollBars.None;
            col_dgv_Id.DataPropertyName = QueueCategory.COL_DB_Id;
            col_dgv_QueueCategories_Id.DataPropertyName = QueueCategory.COL_DB_Id;
            col_dgv_RequestButton.DataPropertyName = QueueCategory.COL_DB_Code;
            col_dgv_Description.DataPropertyName = QueueCategory.COL_DB_Description;
            Util.setGridviewColumnWordwrap(col_dgv_Description, DataGridViewAutoSizeColumnMode.Fill);

            //show button with formatted text
            //col_dgv_RequestText.DataPropertyName = QueueCategory.COL_RequestText;

            //initialize font so when later changed, calculation is not screwed up
            dgv.DefaultCellStyle.Font = new Font(dgv.DefaultCellStyle.Font.FontFamily, Settings.DisplayFontSize);
        }

        private void populateData()
        {
            Util.populateDataGridView(dgv, QueueCategory.get(false, null, null, null));

            //update button text
            //foreach (DataGridViewRow row in dgv.Rows)
            //    ((DataGridViewButtonCell)row.Cells[col_dgv_RequestButton.Name]).Value = row.Cells[col_dgv_RequestText.Name].Value.ToString();
        }

        private void resetData()
        {

        }

        private void fitContent()
        {
            //this.ClientSize = new Size(this.ClientSize.Width, 0); //uncomment if form is not maximized
            int height = 0;
            foreach (DataGridViewRow row in dgv.Rows)
                height += row.Height;

            dgv.Height = height; //resize gridview size

            //this.ClientSize = new Size(this.ClientSize.Width, height); //uncomment if form is not maximized
        }

        private void clearQueueIfStartOfDay()
        {
            DataTable datatable = Queues.get_withtrycatch(true, null, null, 1);
            if (datatable.Rows.Count > 0)
            {
                DateTime lastdate = Util.wrapNullable<DateTime>(datatable.Rows[0], Queues.COL_DB_Timestamp);
                if(lastdate.Date < DateTime.Now.Date)
                    Queues.deleteAll();
            }
        }

        //in order for the cursor to properly hide/show, the settings panel is visible when form is shown
        //and this method is run once to hide the settings panel and the cursor
        //on form closed event, the cursor is shown again so cursor works properly on the next form
        private void clickSettings()
        {
            pnlSettings.Visible = !pnlSettings.Visible;

            if (!pnlSettings.Visible)
                Cursor.Hide();
            else
                Cursor.Show();
        }

        private void updateWidth(int stepSize)
        {
            if (dgv.Width + stepSize < this.Width)
                Settings.RequestGridWidth = dgv.Width + stepSize;

            updateSize(0);
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            clearQueueIfStartOfDay();

            setupControls();
            populateData();

            clickSettings();
        }

        private void Queue_Request_Form_Shown(object sender, EventArgs e)
        {
            updateSize(0);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Helper.processCmdKey(this, keyData);

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Util.isColumnMatch(sender, e, col_dgv_RequestButton))
            {
                _printString = Queues.add(Util.wrapClickedCellValueNullable<Guid>(col_dgv_QueueCategories_Id, e));
                
                if (_printString != null)
                    Util.displayForm(null, new LIBUtil.Desktop.Forms.MessageBox_Form(
                        () => Helper.printReceipt(_printString), 
                        "Printing..", 
                        (int)dgv.DefaultCellStyle.Font.Size,
                        3, 
                        false, 
                        false, 
                        false, 
                        Properties.Resources.Q));
            }
        }

        private void btnDecreaseStep_Click(object sender, EventArgs e)
        {
            updateSize(-1 * LARGESTEP);
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            updateSize(-1 * SMALLSTEP);
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            updateSize(SMALLSTEP);
        }

        private void btnIncreaseStep_Click(object sender, EventArgs e)
        {
            updateSize(LARGESTEP);
        }

        private void updateSize(int stepSize)
        {
            int newFontSize = Settings.DisplayFontSize + stepSize;
            if (newFontSize > MINIMUMFONTSIZE)
            {
                Settings.DisplayFontSize = newFontSize;
                dgv.DefaultCellStyle.Font = new Font(dgv.DefaultCellStyle.Font.FontFamily, newFontSize);
                //dgv.Width = WIDTHINCREMENT * newFontSize;
                dgv.Width = Settings.RequestGridWidth;

                //set description font smaller than button
                col_dgv_Description.DefaultCellStyle.Font = new Font(dgv.DefaultCellStyle.Font.FontFamily, (int)Math.Ceiling(newFontSize * DESCRIPTIONFONTSIZEFACTOR));

                fitContent();
                Util.relocateToCenter(dgv);

                //revert changes if list is bigger than form
                if (dgv.Width > this.Width || dgv.Height > this.Height)
                {
                    if(stepSize == 0)
                        updateSize(-1 * Math.Abs(SMALLSTEP));
                    else
                        updateSize(-1 * Math.Abs(stepSize));
                }
            }
        }

        private void pbUpdate_Click(object sender, EventArgs e)
        {
            clickSettings();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Queue_Request_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!pnlSettings.Visible)
                clickSettings();
        }

        private void Queue_Request_Form_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                clickSettings();
            }
        }

        private void btnDecreaseWidthStep_Click(object sender, EventArgs e)
        {

            updateWidth(-1 * LARGESTEP * 5);
        }

        private void btnDecreaseWidth_Click(object sender, EventArgs e)
        {

            updateWidth(-1 * SMALLSTEP * 5);
        }

        private void btnIncreaseWidth_Click(object sender, EventArgs e)
        {

            updateWidth(SMALLSTEP * 5);
        }

        private void btnIncreaseWidthStep_Click(object sender, EventArgs e)
        {

            updateWidth(LARGESTEP * 5);
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
