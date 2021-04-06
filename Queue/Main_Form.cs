using System;
using System.Windows.Forms;

namespace Queue
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Shown(object sender, EventArgs e)
        {
            while (Helper.formToOpen != null)
            {
                Form form = Helper.formToOpen;
                Helper.formToOpen = null;
                LIBUtil.Util.displayForm(this, form, true);
                if(form.GetType() == typeof(MasterData_v1_CounterAddresses_Form))
                {
                    LIBUtil.Util.displayForm(null, new Settings_Form(), true);
                }
            }

            this.Close();
        }
    }
}
