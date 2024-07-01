namespace MyRhinoPlugin
{
    public class BlockSettings
    {
        public double Width { get; set; } = 1200;
        public double Length { get; set; } = 92;
        public double Height { get; set; } = 2400;
        public double Spacing { get; set; } = 2000;

        public double HalfWidth { get => Width / 2f; }
        public double HalfLength { get => Length / 2f; }
        public double HalfHeight { get => Height / 2f; }
    }
}
