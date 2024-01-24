namespace GeometricFigures.Figures
{
    public class Triangle : BaseFigure
    {
        public Triangle(double A, double B, double C)
        {
            SideA = A;
            SideB = B;
            SideC = C;

            if (SideA + SideB > SideC || SideB + SideC > SideA || SideA + SideC > SideB)
                return;
            else
                throw new ArgumentException("Triangles with such sides cannot exist");
        }

        protected double _sideA;
        protected double _sideB;
        protected double _sideC;

        public double SideA
        {
            get { return _sideA; }
            set { if (value < 0) throw new ArgumentException("The value cannot be less than 0"); _sideA = value; }
        }
        public double SideB
        {
            get { return _sideB; }
            set { if (value < 0) throw new ArgumentException("The value cannot be less than 0"); _sideB = value; }
        }
        public double SideC
        {
            get { return _sideC; }
            set { if (value < 0) throw new ArgumentException("The value cannot be less than 0"); _sideC = value; }
        }
        public bool IsRectangularTriangle => SideA * SideA + SideB * SideB == SideC * SideC ||
                     SideA * SideA + SideC * SideC == SideB * SideB ||
                     SideB * SideB + SideC * SideC == SideA * SideA;
        protected double _semiPerimeter => Perimeter / 2;
        public override double Square =>
           Math.Sqrt(_semiPerimeter * (_semiPerimeter - SideA) * (_semiPerimeter - SideB) * (_semiPerimeter - SideC));
        public override double Perimeter => SideA + SideB + SideC;
    }
}
