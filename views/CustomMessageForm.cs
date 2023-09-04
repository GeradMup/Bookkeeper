using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoices.src.views
{
    public enum MessageType
    {
        Success,
        MildWarning,
        SevereWarning
    };

    public enum Results 
    {
        YES,
        NO,
        NOTHING
    };

    public partial class CustomMessageForm : Form
    {
        Form parent;
        Action<DialogResult> callbackFunction;
        public CustomMessageForm(Form parentForm, MessageType type, string message, Action<DialogResult> callback)
        {
            InitializeComponent();
            
            parent = parentForm;
            callbackFunction = callback;

            switch (type) 
            {
                case MessageType.MildWarning:
                    this.Text = "Warning";
                    Message.ForeColor = Color.Red;
                    confirmationRequired(false);
                    break;
                case MessageType.Success:
                    this.Text = "Success";
                    Message.ForeColor = Color.Green;
                    confirmationRequired(false);
                    break;
                case MessageType.SevereWarning:
                    this.Text = "Severe Warning";
                    Message.ForeColor = Color.Red;
                    confirmationRequired(true);
                    break;
                default:
                    break;
            }
            Message.Text = message;
        }

        private void confirmationRequired(bool required) 
        {
            if (required == true)
            {
                YesButton.Visible = true;
                NoButton.Visible = true;
                OkButton.Visible = false;
            }
            else 
            {
                YesButton.Visible = false;
                NoButton.Visible = false;
                OkButton.Visible = true;
            }
        }

        public void showBox() 
        {
            parent.Enabled = false;
            this.Show();
        }

        public void closeBox() 
        {
            parent.Enabled = true;
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            closeBox();
            callbackFunction(DialogResult.OK);
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            closeBox();
            callbackFunction(DialogResult.Yes);
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            closeBox();
            callbackFunction(DialogResult.No);
        }
    }
}
