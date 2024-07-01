using MyRhinoPlugin.Data;
using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace MyRhinoPlugin
{
    public class FormPresenter : ObservableObject
    {
        public BlockSettings Block { get; set; } = new BlockSettings();

        private string _stats = string.Empty;
        public string Stats { get => _stats; private set => SetProperty(ref _stats, value); }

        private List<SceneBlock> _blocks = new List<SceneBlock>();
        private int _blockIterator = 0;
        private RhinoDoc _doc;
        private RunMode _mode;

        public FormPresenter(RhinoDoc doc, RunMode mode)
        {
            _doc = doc;
            _mode = mode;
        }

        public void AddBlock()
        {
            double halfWidth = Block.HalfWidth;
            double halfLength = Block.HalfLength;
            double halfHeight = Block.HalfHeight;

            double X = CalculateNextXAxisOffset(halfWidth, _blocks.Last());
            double Y = 0;
            double Z = 0;

            var box = new Box(
                new Plane(new Point3d(X, Y, Z), Vector3d.ZAxis),
                new Interval(-halfWidth, halfWidth),
                new Interval(-halfLength, halfLength),
                new Interval(-halfHeight, halfHeight)
            );

            var newBox = new SceneBlock()
            {
                Box = box,
                Guid = _doc.Objects.AddBox(box)
            };
            _blocks.Add(newBox);

            _doc.Views.Redraw();
        }

        private double CalculateNextXAxisOffset(double halfWidth, SceneBlock previousBlock)
        {
           return previousBlock == null? 0 :
                previousBlock.Box.BoundingBox.Max.X + Block.Spacing + halfWidth;
        }

        public void DeleteLastBlock()
        {
            if (_blocks.Count == 0) return;

            var lastAddedObject = _blocks.Last();
            if (TryDeleteRhinoObject(lastAddedObject))
            {
                _doc.Views.Redraw();
            }
        }

        public void DeleteAllBlocks()
        {
            while (_blocks.Count > 0)
            {
                var lastAddedObject = _blocks.Last();
                _blocks.RemoveAt(_blocks.Count - 1);
                TryDeleteRhinoObject(lastAddedObject);
            }
            _doc.Views.Redraw();
        }

        private bool TryDeleteRhinoObject(SceneBlock lastAddedObject)
        {
            var rhinoObj = _doc.Objects.Find(lastAddedObject.Guid);
            if (rhinoObj != null)
            {
                _doc.Objects.Delete(rhinoObj);
                return true;
            }
            return false;
        }
    }
}
