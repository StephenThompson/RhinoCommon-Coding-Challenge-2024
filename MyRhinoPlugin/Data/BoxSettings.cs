namespace MyRhinoPlugin.Data
{
    /// <summary>
    /// Represents the settings for a block.
    /// </summary>
    public class BoxSettings : ObservableObject
    {
        private double _width = 1200;
        private double _length = 92;
        private double _height = 2400;
        private double _spacing = 2000;

        /// <summary>
        /// Gets or sets the width of the block.
        /// </summary>
        public double Width { get => _width; set => SetProperty(ref _width, value); }

        /// <summary>
        /// Gets or sets the length of the block.
        /// </summary>
        public double Length { get => _length; set => SetProperty(ref _length, value); }

        /// <summary>
        /// Gets or sets the height of the block.
        /// </summary>
        public double Height { get => _height; set => SetProperty(ref _height, value); }

        /// <summary>
        /// Gets or sets the spacing between blocks.
        /// </summary>
        public double Spacing { get => _spacing; set => SetProperty(ref _spacing, value); }

        /// <summary>
        /// Gets the half width of the block.
        /// </summary>
        public double HalfWidth { get => Width / 2f; }

        /// <summary>
        /// Gets the half length of the block.
        /// </summary>
        public double HalfLength { get => Length / 2f; }

        /// <summary>
        /// Gets the half height of the block.
        /// </summary>
        public double HalfHeight { get => Height / 2f; }
    }
}
