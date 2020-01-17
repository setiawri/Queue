using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            LIBUtil.DBConnection.initialize(Settings.CONNECTIONSTRING_DEFAULTPARAMS, Settings.SQL_USERNAME, Settings.SQL_PASSWORD);
            //runApplication();
            LIBUtil.Util.ensureSingleInstance(runApplication);
        }
        
        static void runApplication()
        {
            if (!LIBUtil.Util.isDBConnectionAvailable(Properties.Resources.Q, true, true))
                Helper.formToOpen = new Settings_Form();
            else
            {
                if (!Helper.counter.isValidCounter())
                    Helper.formToOpen = new MasterData_v1_CounterAddresses_Form();
                else
                {
                    switch (Helper.counter.DefaultForms_enum)
                    {
                        case DefaultForms.PRINTER:
                            Helper.formToOpen = new Queue_Request_Form();
                            break;
                        case DefaultForms.TVMonitor:
                            Helper.formToOpen = Helper.selectedDisplayForm();
                            break;
                        default:
                            Helper.formToOpen = new Queue_Caller_Form();
                            break;
                    }
                }
            }

            Application.Run(new Main_Form());
        }
    }
}
