using Rhino.Geometry;
using System;

namespace MyRhinoPlugin.Data
{
    public class SceneBlock
    {
        public Guid Guid { get; set; }
        public Box Box { get; set; }
    }
}
