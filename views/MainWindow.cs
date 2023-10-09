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
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// Calling the constructor of a forms class should instantiate them and run the main app.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tabs_TabIndexChanged(object sender, EventArgs e)
        {
            disableEditingOurCompany();
            resetHistoryTab();
        }

        private void Tabs_Deselected(object sender, TabControlEventArgs e)
        {
            disableEditingOurCompany();
            resetHistoryTab();
        }

        private bool warningConfirmation(string warningMessage) 
        {
            DialogResult dialogResult = CustomMessageBox.Show(this, warningMessage, MessageType.SevereWarning);

            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void showSuccessMessage(string message) 
        {
            CustomMessageBox.Show(this, message, MessageType.Success);
        }

        private void showErrorMessage(string message) 
        {
            CustomMessageBox.Show(this, message, MessageType.MildWarning);
        }

        private bool validGridViewSelection(DataGridView gridView) 
        {
            if (gridView.Rows.Count < 1) return false;
            if (gridView.CurrentRow.Index == -1) return false;
            return true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Scale our form to look like it did when we designed it.
            // This adjusts between the screen resolution of the design computer and the workstation.
            int ourScreenWidth = Screen.FromControl(this).WorkingArea.Width;
            int ourScreenHeight = Screen.FromControl(this).WorkingArea.Height;
            float scaleFactorWidth = (float)ourScreenWidth / 1920f;
            float scaleFactorHeigth = (float)ourScreenHeight / 1032f;
            SizeF scaleFactor = new SizeF(scaleFactorWidth, scaleFactorHeigth);
            Scale(scaleFactor);

            // If you want to center the resized screen.
            CenterToScreen();
        }
    }
}
