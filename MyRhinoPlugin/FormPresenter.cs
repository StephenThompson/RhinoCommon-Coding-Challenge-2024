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
        public BoxSettings Block { get; set; } = new BoxSettings();

        public string BlockName 
        { 
            get => _blockName;
            set 
            {
                SetProperty(ref _blockName, value);
                UpdateDocInstance();
                _doc.Views.Redraw();
            }
        }
        private string _blockName = "MyRhinoPlugin Example";

        /// <summary>
        /// Gets the statistics string.
        /// </summary>
        public string Stats { get => _stats; private set => SetProperty(ref _stats, value); }
        private string _stats = string.Empty;

        private List<RhinoDocBox> _blocks = new List<RhinoDocBox>();
        private RhinoDoc _doc;
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
        public bool CreateBox()
        {
            if (!CreateOrGetInstanceDefinition(out var blockDefinition))
                return false;

            // Create Box
            double halfWidth = Block.HalfWidth;
            double halfLength = Block.HalfLength;
            double halfHeight = Block.HalfHeight;

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
                UpdateDocInstance();
            }
            return true;
        }

        private void UpdateDocInstance()
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
                 lastObj.Geometry.GetBoundingBox(false).Max.X + Block.Spacing + halfWidth;
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
            while (_blocks.Count > 0)
            {
                TryDeleteLastBlock();
            }
            _doc.Views.Redraw();
            UpdateStats();
        }

        /// <summary>
        /// Updates the statistics string.
        /// </summary>
        public void UpdateStats()
        {
            var totalArea = 0d;
            var totalVolume = 0d;

            foreach (var block in _blocks)
            {
                totalArea += block.Box.Area;
                totalVolume += block.Box.Volume;
            }

            Stats =
                $"Block Count: {_blocks.Count}\n" +
                $"Total Area (mm): {totalArea}\n" +
                $"Total Volume (mm): {totalVolume}\n" +
                $"Total Area (m): {totalArea * 0.001:0.00}\n" +
                $"Total Volume (m): {totalVolume * 0.001:0.00}\n";
        }


        /////   Private Helpers 

        private double CalculateNextXAxisOffset(double halfWidth, RhinoDocBox previousBlock)
        {
            return previousBlock == null ? 0 :
                 previousBlock.Box.BoundingBox.Max.X + Block.Spacing + halfWidth;
        }

        private bool TryDeleteLastBlock()
        {
            if (_blocks.Count == 0) 
                return false;

            var lastAddedObject = _blocks.Last();
            _blocks.RemoveAt(_blocks.Count - 1);

            var rhinoObj = _doc.Objects.Find(lastAddedObject.DocGuid);
            if (rhinoObj != null)
            {
                _doc.Objects.Delete(rhinoObj);
                return true;
            }
            return false;
        }
    }
}
