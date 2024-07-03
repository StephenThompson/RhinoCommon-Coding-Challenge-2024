using MyRhinoPlugin.Forms;
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
            blockSettingsBindingSource.DataSource = _formPresenter.BoxSetting;
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

        private void buttonSetBlockName_Click(object sender, EventArgs e)
        {
            var dialog = new SetStringDialog()
            {
                Message = "Please type in the Block Name.",
                InputText = _formPresenter.BlockName
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _formPresenter.BlockName = dialog.InputText;
            }
        }
    }
}
