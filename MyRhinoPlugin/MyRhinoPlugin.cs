using Rhino.PlugIns;
using Rhino.UI;
using Rhino;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace MyRhinoPlugin
{
    ///<summary>
    /// <para>Every RhinoCommon .rhp assembly must have one and only one PlugIn-derived
    /// class. DO NOT create instances of this class yourself. It is the
    /// responsibility of Rhino to create an instance of this class.</para>
    /// <para>To complete plug-in information, please also see all PlugInDescription
    /// attributes in AssemblyInfo.cs (you might need to click "Project" ->
    /// "Show All Files" to see it in the "Solution Explorer" window).</para>
    ///</summary>
    public class MyRhinoPlugin : Rhino.PlugIns.PlugIn
    {
        //public IServiceProvider ServiceProvider { get; private set; }

        public MyRhinoPlugin()
        {
            Instance = this;
            ActiveDoc = RhinoDoc.ActiveDoc;
        }

        //private ServiceProvider CreateDependencyInjectionServices()
        //{
        //    var collection = new ServiceCollection();
        //    var activeDoc = RhinoDoc.ActiveDoc;

        //    //collection.AddSingleton(r => activeDoc);
        //    //collection.AddSingleton<FormPresenter>();
        //    return collection.BuildServiceProvider();
        //}

        ///<summary>Gets the only instance of the MyRhinoPlugin plug-in.</summary>
        public static MyRhinoPlugin Instance { get; private set; }

        // You can override methods here to change the plug-in behavior on
        // loading and shut down, add options pages to the Rhino _Option command
        // and maintain plug-in wide options in a document.

        public RhinoDoc ActiveDoc { get; private set; }


        //public FormPresenter FormPresenter { get; private set; }

        /// <summary>
        /// Called when the plug-in is being loaded.
        /// </summary>
        protected override LoadReturnCode OnLoad(ref string errorMessage)
        {
            var type = typeof(MyRhinoPluginUserControl);
            Panels.RegisterPanel(this, type, "MyRhinoPlugin", MyRhinoPluginNS.Properties.Resources.Panel, PanelType.System);
            return LoadReturnCode.Success;
        }

        public FormPresenter CreateFormPresenter()
        {
            return new FormPresenter(ActiveDoc);
        }
    }
}