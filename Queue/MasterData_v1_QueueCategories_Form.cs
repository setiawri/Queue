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
    public partial class MasterData_v1_QueueCategories_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const bool FORM_SHOWDATAONLOAD = true;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_Code;
        private DataGridViewColumn col_dgv_Description;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_QueueCategories_Form() : this(FormModes.Add) { }
        public MasterData_v1_QueueCategories_Form(FormModes startingMode) : base(startingMode, FORM_SHOWDATAONLOAD) { InitializeComponent(); }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        #endregion METHODS
        /*******************************************************************************************************/
        #region OVERRIDE METHODS

        protected override void setupFields()
        {
            setColumnsDataPropertyNames(QueueCategory.COL_DB_Id, QueueCategory.COL_DB_Active, null, null, null, null);

            col_dgv_Code = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Code", itxt_Code.LabelText, QueueCategory.COL_DB_Code, true, true, "", true, false, null, DataGridViewContentAlignment.MiddleLeft);

            col_dgv_Description = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Description", itxt_Code.LabelText, QueueCategory.COL_DB_Description, true, true, "", true, false, null, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //by default set to true and hide it.
            chkIncludeInactive.Checked = true;
            chkIncludeInactive.Visible = false;
        }

        protected override void additionalSettings() { }

        protected override void clearInputFields()
        {
            itxt_Code.reset();
            itxt_Description.reset();
        }

        protected override bool isValidToPopulateGridViewDataSource()
        {
            return true;
        }

        protected override System.Data.DataView loadGridviewDataSource()
        {
            return QueueCategory.get(chkIncludeInactive.Checked, null, itxt_Code.ValueText, itxt_Description.ValueText).DefaultView;
        }

        protected override void populateInputFields()
        {
            QueueCategory obj = new QueueCategory(selectedRowID());
            itxt_Code.ValueText = obj.Code;
            itxt_Description.ValueText = obj.Description;
        }

        protected override void update()
        {
            QueueCategory.update(selectedRowID(), itxt_Code.ValueText, itxt_Description.ValueText);
        }

        protected override void add()
        {
            QueueCategory.add(itxt_Code.ValueText, itxt_Description.ValueText);
        }

        protected override Boolean isInputFieldsValid()
        {
            if (string.IsNullOrEmpty(itxt_Code.ValueText))
                return itxt_Code.isValueError("Please provide Code");

            return true;
        }

        protected override void updateActiveStatus(Guid id, Boolean activeStatus)
        {
            QueueCategory.updateActiveStatus(id, activeStatus);
        }
        
        protected override void updateDefaultRow(Guid id) { }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Helper.processCmdKey(this, keyData);

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
