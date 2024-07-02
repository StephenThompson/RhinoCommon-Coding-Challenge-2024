using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRhinoPlugin
{
    public partial class MyRhinoPluginUserControl : UserControl
    {
        private FormPresenter _formPresenter { get; set; }

        public MyRhinoPluginUserControl()
        {
            InitializeComponent();


            //var DI = MyRhinoPlugin.Instance.ServiceProvider;
            _formPresenter = MyRhinoPlugin.Instance.CreateFormPresenter();// DI.GetRequiredService<FormPresenter>();
            blockSettingsBindingSource.DataSource = _formPresenter.Block;
            bindingPresenterSource.DataSource = _formPresenter;
        }

        private void buttonAddBlock_Click(object sender, EventArgs e)
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
