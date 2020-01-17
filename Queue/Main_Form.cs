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
                //LIBUtil.Util.displayForm(this, form);
            }

            this.Close();
        }
    }
}
