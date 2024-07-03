using System;
using System.Collections.Generic;
using MyRhinoPlugin.Data;
using Rhino;
using Rhino.Commands;
using Rhino.DocObjects;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;

namespace MyRhinoPlugin.Commands
{
    public class AddBoxCommand : Command
    {
        public AddBoxCommand()
        {
            Instance = this;
        }

        ///<summary>The only instance of the MyCommand command.</summary>
        public static AddBoxCommand Instance { get; private set; }

        public class AddBoxParameters
        {
            public BoxSettings BoxParameters { get; set; } = new BoxSettings();
        }

        public AddBoxParameters CommandParameters { get; set; } = new AddBoxParameters();

        public string ActiveInstanceName { get; set; }

        public override string EnglishName => "AddBoxCommand";

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {


            //double halfWidth = Block.HalfWidth;
            //double halfLength = Block.HalfLength;
            //double halfHeight = Block.HalfHeight;

            //double X = CalculateNextXAxisOffset(halfWidth, _blocks.LastOrDefault());
            //double Y = 0;
            //double Z = 0;



            //AddBoxCommand.Instance.run

            //var box = new Box(
            //    new Plane(new Point3d(X, Y, Z), Vector3d.ZAxis),
            //    new Interval(-halfWidth, halfWidth),
            //    new Interval(-halfLength, halfLength),
            //    new Interval(-halfHeight, halfHeight)
            //);

            //var newBox = new RhinoDocBox()
            //{
            //    Box = box,
            //    DocGuid = _doc.Objects.AddBox(box)
            //};

            //// Gather all of the selected objects
            //var idef_index = doc.InstanceDefinitions.Add(idef_name, string.Empty, base_point, geometry, attributes);
            //if (idef_index < 0)
            //{
            //    RhinoApp.WriteLine("Unable to create block definition", idef_name);
            //    return Result.Failure;
            //}


            //_blocks.Add(newBox);

            //_doc.Views.Redraw();

            var idef = doc.InstanceDefinitions.Find(ActiveInstanceName);
            //idef.
               // doc.InstanceDefinitions.
            //idef.ad


            // Select objects to define block
            var go = new GetObject();
            go.SetCommandPrompt("Select objects to define block");
            go.ReferenceObjectSelect = false;
            go.SubObjectSelect = false;
            go.GroupSelect = true;

            // Phantoms, grips, lights, etc., cannot be in blocks.
            var forbidden_geometry_filter = ObjectType.Light | ObjectType.Grip | ObjectType.Phantom;
            var geometry_filter = forbidden_geometry_filter ^ ObjectType.AnyObject;
            go.GeometryFilter = geometry_filter;
            go.GetMultiple(1, 0);
            if (go.CommandResult() != Result.Success)
                return go.CommandResult();

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
            for (int i = 0; i < go.ObjectCount; i++)
            {
                //var b = new Box();

                //doc.Objects.AddBox(b);

                var rh_object = go.Object(i).Object();
                if (rh_object != null)
                {
                    geometry.Add(rh_object.Geometry);
                    attributes.Add(rh_object.Attributes);
                }
            }

            // Gather all of the selected objects
            var idef_index = doc.InstanceDefinitions.Add(idef_name, string.Empty, base_point, geometry, attributes);
            if (idef_index < 0)
            {
                RhinoApp.WriteLine("Unable to create block definition", idef_name);
                return Result.Failure;
            }


            // TODO: complete command.
            return Result.Success;
        }

        internal void Run(RhinoDoc doc)
        {
            throw new NotImplementedException();
        }
    }
}