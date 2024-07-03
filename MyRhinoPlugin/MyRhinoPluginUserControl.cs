using System;
using System.Windows.Forms;

namespace MyRhinoPlugin
{
    public partial class MyRhinoPluginUserControl : UserControl
    {
        private FormPresenter _formPresenter { get; set; }

        public MyRhinoPluginUserControl()
        {
            InitializeComponent();

            _formPresenter = MyRhinoPlugin.Instance.CreateFormPresenter();
            blockSettingsBindingSource.DataSource = _formPresenter.Block;
            bindingPresenterSource.DataSource = _formPresenter;
        }

        private void buttonAddBlock_Click(object sender, EventArgs e)
        {
            _formPresenter.CreateBox();
        }

        private void buttonDeleteLast_Click(object sender, EventArgs e)
        {
            _formPresenter.DeleteLastBox();
        }

        private void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            _formPresenter.DeleteAllBoxes();
        }
    }
}
