using MyRhinoPlugin.Data;
using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
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
        public BlockSettings Block { get; set; } = new BlockSettings();

        /// <summary>
        /// Gets the statistics string.
        /// </summary>
        public string Stats { get => _stats; private set => SetProperty(ref _stats, value); }
        private string _stats = string.Empty;

        private List<RhinoDocBlock> _blocks = new List<RhinoDocBlock>();
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
        public void AddBlock()
        {
            double halfWidth = Block.HalfWidth;
            double halfLength = Block.HalfLength;
            double halfHeight = Block.HalfHeight;

            double X = CalculateNextXAxisOffset(halfWidth, _blocks.LastOrDefault());
            double Y = 0;
            double Z = 0;





            //var box = new Box(
            //    new Plane(new Point3d(X, Y, Z), Vector3d.ZAxis),
            //    new Interval(-halfWidth, halfWidth),
            //    new Interval(-halfLength, halfLength),
            //    new Interval(-halfHeight, halfHeight)
            //);

            //var newBox = new RhinoDocBlock()
            //{
            //    Box = box,
            //    DocGuid = _doc.Objects.AddBox(box)
            //};
            //_blocks.Add(newBox);

            _doc.Views.Redraw();
            UpdateStats();   
        }
       
        /// <summary>
        /// Deletes the last added block from the scene.
        /// </summary>
        public void DeleteLastBlock()
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
        public void DeleteAllBlocks()
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

        /////   Private Helpers 

        private double CalculateNextXAxisOffset(double halfWidth, RhinoDocBlock previousBlock)
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
