using System;
using System.Windows.Forms;
using LIBUtil;

namespace Queue
{
    public class Helper
    {
        public static DateTime TEMP_Caller_Stop_Time;
        public static Form formToOpen = null;
        public static CounterAddress counter = new CounterAddress();

        public static void processCmdKey(Form form, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.M))
                form.WindowState = FormWindowState.Maximized;
            else if (keyData == Keys.Escape)
                setNewForm(form, null);
            else if (keyData == (Keys.Control | Keys.D1) && form.GetType() != typeof(Queue_Request_Form))
                setNewForm(form, new Queue_Request_Form());
            else if (keyData == (Keys.Control | Keys.D2) && !form.GetType().IsSubclassOf(typeof(Queue_Display_Master_v1_Form)))
            { 
                setNewForm(form, selectedDisplayForm());
            }
            else if (keyData == (Keys.Control | Keys.D3) && form.GetType() != typeof(Queue_Caller_Form))
                setNewForm(form, new Queue_Caller_Form());
            else if (keyData == (Keys.Control | Keys.D0) && form.GetType() != typeof(Settings_Form))
                setNewForm(form, new Settings_Form());
        }

        public static Form selectedDisplayForm()
        {
            if (Settings.DisplayFormMode == 1)
                return new Queue_Display_v1_Form();
            else
                return new Queue_Display_v2_Form();
        }
        
        public static void setNewForm(Form form, Form newForm)
        {
            formToOpen = newForm;
            form.Close();
        }

        public static string printReceipt(string callNo)
        {
            LIBUtil.Desktop.Classes.ReceiptPrinter.print(Settings.PrintAreaWidth, callNo, Settings.PrintQty);
            return callNo;
        }
        
        public static bool isDBConnectionAvailable()
        {
            return DBConnection.isDBConnectionAvailable(Properties.Resources.Q, true, true);
        }
    }
}


