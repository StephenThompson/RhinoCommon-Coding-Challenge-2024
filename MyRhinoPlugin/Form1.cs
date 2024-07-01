using System;
using System.Windows.Forms;

namespace MyRhinoPlugin
{
    public partial class Form1 : Form
    {
        private FormPresenter _formPresenter { get; set; }

        public Form1(FormPresenter formPresenter)
        {
            InitializeComponent();
            _formPresenter = formPresenter;
            blockSettingsBindingSource.DataSource = _formPresenter.Block;
            bindingPresenterSource.DataSource = _formPresenter;
        }

        private void ButtonAddBlock_Click(object sender, EventArgs e)
        {
            _formPresenter.AddBlock();
        }

        private void buttonDeleteLast_Click(object sender, EventArgs e)
        {
            _formPresenter.DeleteLastBlock();
        }

        private void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            _formPresenter.DeleteAllBlocks();
        }

        private void buttonRecenterCamera_Click(object sender, EventArgs e)
        {
            _formPresenter.RecenterCamera();
        }
    }
}
