using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoices.src.views
{
    public static class CustomMessageBox
    {
        public static DialogResult results;
        public static DialogResult Show(Form parentForm, string message, MessageType messageType)
        {
            //Here we make use of the "Using" clause to ensure that all resources are released when the form closes. 
            using (CustomMessageForm form = new CustomMessageForm(parentForm, messageType, message, setDialogResults))
            {
                form.ShowDialog();
            }
            return results;
        }

        public static void setDialogResults(DialogResult res) 
        {
            results = res;
        }
    }
}
