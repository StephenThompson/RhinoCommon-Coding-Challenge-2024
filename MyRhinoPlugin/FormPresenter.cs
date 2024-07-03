using MyRhinoPlugin.Data;
using Rhino;
using Rhino.DocObjects;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyRhinoPlugin
{
    /// <summary>
    /// Represents the presenter class for the form in the Rhino plugin.
    /// </summary>
    public class FormPresenter : ObservableObject
    {
        /// <summary>
        /// Gets or sets the block settings.
        /// </summary>
        public BoxSettings BoxSetting { get; set; } = new BoxSettings();

        /// <summary>
        /// Gets or sets the name of the block.
        /// </summary>
        public string BlockName 
        { 
            get => _blockName;
            set 
            {
                SetProperty(ref _blockName, value);
                UpdateInstanceVisualizer();
                _doc.Views.Redraw();
            }
        }
        private string _blockName = "MyRhinoPlugin Example";

        /// <summary>
        /// Gets the statistics string.
        /// </summary>
        public string Stats { get => _stats; private set => SetProperty(ref _stats, value); }
        private string _stats = string.Empty;

        /* The active rhino doc object */
        private RhinoDoc _doc;

        /* The Guid of the rhino doc object used to visualize the instance/block */
        private Guid visualizeInstGuid;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormPresenter"/> class.
        /// </summary>
        /// <param name="doc">The Rhino document.</param>
        public FormPresenter(RhinoDoc doc)
        {
            _doc = doc;
            UpdateStats();
        }

        /// <summary>
        /// Adds a new box to the block.
        /// </summary>
        /// <returns><c>true</c> if the box was successfully created, <c>false</c> otherwise.</returns>
        public bool CreateBox()
        {
            if (!CreateOrGetInstanceDefinition(out var blockDefinition))
                return false;

            // Create Box
            double halfWidth = BoxSetting.HalfWidth;
            double halfLength = BoxSetting.HalfLength;
            double halfHeight = BoxSetting.HalfHeight;

            double X = CalculateNextXAxisOffset(halfWidth, blockDefinition);
            double Y = 0;
            double Z = 0;

            var position = new Point3d(X, Y, Z);
            var plane = Plane.CreateFromNormal(position, Vector3d.ZAxis);
            var box = new Box(plane,
                new Interval(-halfWidth, halfWidth),
                new Interval(-halfLength, halfLength),
                new Interval(-halfHeight, halfHeight));

            // Update Block
            var geometry = new List<GeometryBase>();
            var attributes = new List<ObjectAttributes>();
            CopyArraysFromInstance(blockDefinition, geometry, attributes);

            GeometryBase boxGeo = box.ToExtrusion();
            geometry.Add(boxGeo);
            attributes.Add(new ObjectAttributes());

            _doc.InstanceDefinitions.ModifyGeometry(blockDefinition.Index, geometry, attributes);
            _doc.Views.Redraw();
            UpdateStats();
            return true;
        }

        private void CopyArraysFromInstance(
            InstanceDefinition blockDefinition, 
            List<GeometryBase> geometry, List<ObjectAttributes> attributes,
            int i_start = 0, int i_end = -1)
        {
            var existingObjects = blockDefinition.GetObjects();
            if (i_end < 0) i_end = existingObjects.Length;

            for (int i = i_start; i < i_end && i < existingObjects.Length; ++i)
            {
                var i_object = existingObjects[i];
                geometry.Add(i_object.Geometry);
                attributes.Add(i_object.Attributes);
            }
        }

        private bool CreateOrGetInstanceDefinition(out InstanceDefinition blockDefinition)
        {
            blockDefinition = _doc.InstanceDefinitions.Find(_blockName);
            if (blockDefinition == null)
            {
                // Gather all of the selected objects
                var geometry = new List<GeometryBase>();
                var attributes = new List<ObjectAttributes>();

                // Gather all of the selected objects
                var idef_index = _doc.InstanceDefinitions.Add(_blockName, string.Empty, new Point3d(0, 0, 0), geometry, attributes);
                if (idef_index < 0)
                {
                    RhinoApp.WriteLine("Unable to create block definition", _blockName);
                    return false;
                }
                blockDefinition = _doc.InstanceDefinitions.Find(_blockName);
                UpdateInstanceVisualizer();
            }
            return true;
        }

        private void UpdateInstanceVisualizer()
        {
            var docInstObject = _doc.Objects.Find(visualizeInstGuid);
            if (docInstObject != null)
            {
                _doc.Objects.Delete(docInstObject);
            }

            var blockDefinition = _doc.InstanceDefinitions.Find(_blockName);
            if (blockDefinition != null)
            {
                visualizeInstGuid = _doc.Objects.AddInstanceObject(blockDefinition.Index, Transform.Identity);
            }
            else
            {
                RhinoApp.WriteLine("Failed to update doc instance.");
            }
        }

        private double CalculateNextXAxisOffset(double halfWidth, InstanceDefinition blockDefinition)
        {
            var lastObj = blockDefinition.GetObjects().LastOrDefault();
            return lastObj == null ? 0 :
                 lastObj.Geometry.GetBoundingBox(false).Max.X + BoxSetting.Spacing + halfWidth;
        }

        /// <summary>
        /// Deletes the last added box from the block.
        /// </summary>
        public void DeleteLastBox()
        {
            var blockDefinition = _doc.InstanceDefinitions.Find(_blockName);
            if (blockDefinition == null)
            {
                RhinoApp.WriteLine("Failed to delete last box, instance does not exist.");
                return;
            }

            var geometry = new List<GeometryBase>();
            var attributes = new List<ObjectAttributes>();            
            CopyArraysFromInstance(blockDefinition, geometry, attributes, 0, blockDefinition.ObjectCount-1);
            _doc.InstanceDefinitions.ModifyGeometry(blockDefinition.Index, geometry, attributes);
            _doc.Views.Redraw();
            UpdateStats();
        }

        /// <summary>
        /// Deletes all boxes from the block.
        /// </summary>
        public void DeleteAllBoxes()
        {
            var blockDefinition = _doc.InstanceDefinitions.Find(_blockName);
            if (blockDefinition == null)
            {
                RhinoApp.WriteLine("Failed to delete last box, instance does not exist.");
                return;
            }

            var geometry = new List<GeometryBase>();
            var attributes = new List<ObjectAttributes>();
            _doc.InstanceDefinitions.ModifyGeometry(blockDefinition.Index, geometry, attributes);
            _doc.Views.Redraw();
            UpdateStats();
        }

        /// <summary>
        /// Updates the statistics string.
        /// </summary>
        public void UpdateStats()
        {
            double totalArea = 0d;
            double totalVolume = 0d;
            int totalBlockCount = 0;

            var blockDefinition = _doc.InstanceDefinitions.Find(_blockName);
            if (blockDefinition != null)
            {
                var blockObjects = blockDefinition.GetObjects();
                totalBlockCount = blockObjects.Length;
                foreach (var block in blockObjects)
                {
                    // GetBoundingBox is a bit of a quick hack.
                    // Assumes The objects in the block will always be a box.
                    var boundingBox = block.Geometry.GetBoundingBox(false);
                    totalArea += boundingBox.Area;
                    totalVolume += boundingBox.Volume;
                }
            }

            Stats =
                $"Block Count: {totalBlockCount}\n" +
                $"Total Area (mm): {totalArea}\n" +
                $"Total Volume (mm): {totalVolume}\n" +
                $"Total Area (m): {totalArea * 0.001:0.00}\n" +
                $"Total Volume (m): {totalVolume * 0.001:0.00}\n";
        }
    }
}
