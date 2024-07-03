using MyRhinoPlugin.Commands;
using MyRhinoPlugin.Data;
using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input.Custom;
using Rhino.UI;
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

        /// <summary>
        /// Gets the statistics string.
        /// </summary>
        public string Stats { get => _stats; private set => SetProperty(ref _stats, value); }
        private string _stats = string.Empty;

        private List<RhinoDocBox> _blocks = new List<RhinoDocBox>();
        private RhinoDoc _doc;

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
        /// Adds a new block to the scene.
        /// </summary>
        public bool CreateBlock(string inputText)
        {
            double halfWidth = Block.HalfWidth;
            double halfLength = Block.HalfLength;
            double halfHeight = Block.HalfHeight;

            double X = CalculateNextXAxisOffset(halfWidth, _blocks.LastOrDefault());
            double Y = 0;
            double Z = 0;

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
            UpdateStats();
            return true;
        }
       
        /// <summary>
        /// Deletes the last added block from the scene.
        /// </summary>
        public void DeleteLastBox()
        {
            if (TryDeleteLastBlock())
            {
                _doc.Views.Redraw();
                UpdateStats();
            }
        }

        /// <summary>
        /// Deletes all blocks from the scene.
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

        /// <summary>
        /// Recenters the camera in all views.
        /// </summary>
        public void RecenterCamera()
        {
            foreach (var view in _doc.Views)
            {
                view.ActiveViewport.ZoomExtents();
            }
        }

        internal void DeleteSelectedBlock()
        {
            throw new NotImplementedException();
        }

        internal void RenameSelectedBlock()
        {
            throw new NotImplementedException();
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

        internal void CreateBox()
        {
            throw new NotImplementedException();
        }
    }
}
