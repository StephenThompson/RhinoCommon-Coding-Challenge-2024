using Rhino.Geometry;
using System;

namespace MyRhinoPlugin.Data
{
    /// <summary>
    /// Represents a block in the Rhino document.
    /// </summary>
    public class RhinoDocBox
    {
        /// <summary>
        /// Gets or sets the unique identifier of the block.
        /// </summary>
        public Guid DocGuid { get; set; }

        /// <summary>
        /// Gets or sets the defined block.
        /// </summary>
        public Box Box { get; set; }
    }
}
