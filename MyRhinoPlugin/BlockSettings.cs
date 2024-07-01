using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyRhinoPlugin
{
    public class BlockSettings : INotifyPropertyChanged
    {
        private double _width = 1200;
        private double _length = 92;
        private double _height= 2400;
        private double _spacing = 2000;

        public double Width {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                NotifyPropertyChanged();
            }
        }
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
                NotifyPropertyChanged();
            }
        }
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                NotifyPropertyChanged();
            }
        }
        public double Spacing
        {
            get
            {
                return _spacing;
            }
            set
            {
                _spacing = value;
                NotifyPropertyChanged();
            }
        }

        public double HalfWidth { get => Width / 2f; }
        public double HalfLength { get => Length / 2f; }
        public double HalfHeight { get => Height / 2f; }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
