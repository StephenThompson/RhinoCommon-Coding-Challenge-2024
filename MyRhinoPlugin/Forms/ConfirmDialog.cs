using System;
using System.Windows.Forms;

namespace MyRhinoPlugin.Forms
{
    partial class ConfirmDialog : Form
    {
        public string Message { get => labelMessage.Text; set => labelMessage.Text = value; }

        public ConfirmDialog()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
