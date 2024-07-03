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

        private void buttonRecenterCamera_Click(object sender, EventArgs e)
        {
            _formPresenter.RecenterCamera();
        }

        private void buttonBlockAdd_Click(object sender, EventArgs e)
        {
            var newNameDialogBox = new SetStringDialog()
            {
                Message = "Please type in the name of new Block."
            };
            var result = newNameDialogBox.ShowDialog();
            if (result == DialogResult.OK && !_formPresenter.CreateBlock(newNameDialogBox.InputText))
            {
                // Todo: show dialog                
            }
        }

        private void buttonBlockRename_Click(object sender, EventArgs e)
        {
            var newNameDialogBox = new SetStringDialog()
            {
                Message = "Please type in the name of Block."
            };
            newNameDialogBox.ShowDialog();
            _formPresenter.RenameSelectedBlock();
        }

        private void buttonBlockDelete_Click(object sender, EventArgs e)
        {
            var newNameDialogBox = new ConfirmDialog()
            {
                Message = "Are you sure you want to delete the Block."
            };
            newNameDialogBox.ShowDialog();
            _formPresenter.DeleteSelectedBlock();
        }
    }
}
