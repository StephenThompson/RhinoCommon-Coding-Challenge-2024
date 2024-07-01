using Rhino;
using Rhino.Commands;
using Rhino.DocObjects;
using Rhino.Geometry;
using System;
using System.Collections.Generic;

namespace MyRhinoPlugin
{
    public class FormPresenter
    {
        public BlockSettings Block { get; set; } = new BlockSettings();

        private List<Guid> _blocks = new List<Guid>();
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
            double X = (Block.Width + Block.Spacing) * _blocks.Count;
            double Y = 0;
            double Z = 0;

            double halfWidth = Block.HalfWidth;
            double halfLength = Block.HalfLength;
            double halfHeight = Block.HalfHeight;
            var box = new Box(
                new Plane(new Point3d(X,Y,Z), new Vector3d(0, 0, 1)),
                new Interval(-halfWidth, halfWidth),
                new Interval(-halfLength, halfLength),
                new Interval(-halfHeight, halfHeight)
            );

            var attributes = new ObjectAttributes()
            {
                Name = $"Box_{_blockIterator}",
                LayerIndex = 0,               
            };

            ++_blockIterator;
                        
            var box_guid = _doc.Objects.AddBox(box, attributes);
            _blocks.Add(box_guid);

            _doc.Views.Redraw();
        }
    }
}
