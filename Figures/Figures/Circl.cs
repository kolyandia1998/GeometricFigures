namespace GeometricFigures.Figures
{
    public class Circl : BaseFigure
    {
        public Circl(double radius)
        {
            Radius = radius;
        }
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { if (value < 0) throw new ArgumentException("The value cannot be less than 0"); _radius = value; }
        }
        public override double Square => Math.PI * Radius * Radius;
        public override double Perimeter => Math.PI * Radius;
    }
}
