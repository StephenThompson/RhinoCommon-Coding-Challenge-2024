using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyRhinoPlugin.Data
{
    public class BlockSettings : ObservableObject
    {
        private double _width = 1200;
        private double _length = 92;
        private double _height = 2400;
        private double _spacing = 2000;

        public double Width { get => _width; set => SetProperty(ref _width, value); }
        public double Length { get => _length; set => SetProperty(ref _length, value); }
        public double Height { get => _height; set => SetProperty(ref _height, value); }
        public double Spacing { get => _spacing; set => SetProperty(ref _spacing, value); }

        public double HalfWidth { get => Width / 2f; }
        public double HalfLength { get => Length / 2f; }
        public double HalfHeight { get => Height / 2f; }
    }
}
