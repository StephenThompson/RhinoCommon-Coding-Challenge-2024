using Rhino;
using Rhino.Commands;
using System;
using System.Windows.Forms;

namespace MyRhinoPlugin
{
    public partial class Form1 : Form
    {
        public FormPresenter FormPresenter;

        public Form1(RhinoDoc doc, RunMode mode)
        {
            InitializeComponent();
            FormPresenter = new FormPresenter(doc, mode);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonAddBlock_Click(object sender, EventArgs e)
        {
            FormPresenter.AddBlock();
        }
    }
}
