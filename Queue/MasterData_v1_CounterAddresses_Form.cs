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
    public partial class MasterData_v1_CounterAddresses_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const bool FORM_SHOWDATAONLOAD = true;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_Name;
        private DataGridViewColumn col_dgv_IPAddress;
        private DataGridViewColumn col_dgv_DefaultForms_description;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_CounterAddresses_Form() : this(FormModes.Add) { }
        public MasterData_v1_CounterAddresses_Form(FormModes startingMode) : base(startingMode, FORM_SHOWDATAONLOAD) { InitializeComponent(); }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        #endregion METHODS
        /*******************************************************************************************************/
        #region OVERRIDE METHODS

        protected override void setupFields()
        {
            iddl_DefaultForms.populate(typeof(DefaultForms));

            setColumnsDataPropertyNames(CounterAddress.COL_DB_Id, null, null, null, null, null);            

            col_dgv_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Name", itxt_Name.LabelText, CounterAddress.COL_DB_Name, true, true, "", true, false, null, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            col_dgv_IPAddress = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_IPAddress", itxt_IPAddress.LabelText, CounterAddress.COL_DB_IPAddress, true, true, "", true, false, null, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_IPAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            col_dgv_DefaultForms_description = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_DefaultForms_description", "Default", CounterAddress.COL_DefaultForms_description, true, true, "", true, false, null, DataGridViewContentAlignment.MiddleCenter);
        }

        protected override void additionalSettings() { }

        protected override void clearInputFields()
        {
            itxt_Name.reset();
            itxt_IPAddress.reset();
        }

        protected override bool isValidToPopulateGridViewDataSource()
        {
            return true;
        }

        protected override System.Data.DataView loadGridviewDataSource()
        {
            return CounterAddress.get(null, itxt_Name.ValueText, itxt_IPAddress.ValueText).DefaultView;
        }

        protected override void populateInputFields()
        {
            CounterAddress obj = new CounterAddress(selectedRowID());
            itxt_Name.ValueText = obj.Name;
            itxt_IPAddress.ValueText = obj.IPAddress;
            iddl_DefaultForms.SelectedItem = obj.DefaultForms_enum;
        }

        protected override void update()
        {
            CounterAddress.update(selectedRowID(), itxt_Name.ValueText, itxt_IPAddress.ValueText, Util.parseEnum<DefaultForms>(iddl_DefaultForms.SelectedValue));
        }

        protected override void add()
        {
            CounterAddress.add(itxt_Name.ValueText, itxt_IPAddress.ValueText, Util.parseEnum<DefaultForms>(iddl_DefaultForms.SelectedValue));
        }

        protected override Boolean isInputFieldsValid()
        {
            Util.sanitize(itxt_Name, itxt_IPAddress);
            
            if (string.IsNullOrEmpty(itxt_IPAddress.ValueText))
                return itxt_Name.isValueError("Please provide IP Address");
            else if (!Util.isValidIPv4(itxt_IPAddress.ValueText))
                return itxt_IPAddress.isValueError("Invalid IP Address");
            else if(string.IsNullOrEmpty(itxt_Name.ValueText))
                return itxt_Name.isValueError("Please provide Name");
            else if (!iddl_DefaultForms.hasSelectedValue())
                return iddl_DefaultForms.SelectedValueError("Select a default form");

            return true;
        }

        protected override void virtual_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Util.isColumnMatch(sender, e, col_dgv_DefaultForms_description))
            {

            }
        }

        protected override void updateDefaultRow(Guid id) { }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CounterAddress.delete(selectedRowID());
            populateGridViewDataSource(true);
        }

        private void MasterData_v1_CounterAddresses_Form_Shown(object sender, EventArgs e)
        {
            if (!Helper.counter.isValidCounter())
            {
                itxt_IPAddress.ValueText = Util.getIPv4();
                itxt_Name.Focus();

                Util.displayMessageBoxError("Silahkan input IP Address komputer ini di daftar counter.");
            }
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
