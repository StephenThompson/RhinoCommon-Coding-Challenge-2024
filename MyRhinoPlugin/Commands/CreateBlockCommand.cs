using Rhino.Commands;
using Rhino.DocObjects;
using Rhino.Geometry;
using Rhino.Input;
using Rhino;
using System.Collections.Generic;

namespace MyRhinoPlugin.Commands
{
    public class CreateBlockCommand : Command
    {
        public CreateBlockCommand()
        {
            Instance = this;
        }

        ///<summary>The only instance of the MyCommand command.</summary>
        public static CreateBlockCommand Instance { get; private set; }

        public override string EnglishName => "CreateBlockCommand";

        public string ActiveInstanceName { get; set; }

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            // Block base point
            Point3d base_point;
            var rc = RhinoGet.GetPoint("Block base point", false, out base_point);
            if (rc != Result.Success)
                return rc;

            // Block definition name
            string idef_name = "";
            rc = RhinoGet.GetString("Block definition name", false, ref idef_name);
            if (rc != Result.Success)
                return rc;

            // Validate block name
            idef_name = idef_name.Trim();
            if (string.IsNullOrEmpty(idef_name))
                return Result.Nothing;

            // See if block name already exists
            InstanceDefinition existing_idef = doc.InstanceDefinitions.Find(idef_name);
            if (existing_idef != null)
            {
                RhinoApp.WriteLine("Block definition {0} already exists", idef_name);
                return Result.Nothing;
            }

            // Gather all of the selected objects
            var geometry = new List<GeometryBase>();
            var attributes = new List<ObjectAttributes>();

            // Gather all of the selected objects
            var idef_index = doc.InstanceDefinitions.Add(idef_name, string.Empty, new Point3d(0,0,0), geometry, attributes);
            if (idef_index < 0)
            {
                RhinoApp.WriteLine("Unable to create block definition", idef_name);
                return Result.Failure;
            }

            ActiveInstanceName = idef_name;
            return Result.Success;
        }
    }
}
