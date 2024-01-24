using GeometricFigures.Figures;

namespace GeometricFigures.Services
{
    public static class FigureCalculator
    {
        public static double CalculateSquare(BaseFigure figure)
        {
            if ( figure == null )
                throw new ArgumentNullException("figure is null");
            return figure.Square;
        }

        public static double CalculatePerimetr(BaseFigure figure)
        {
            if ( figure == null )
                throw new ArgumentNullException("figure is null");
            return figure.Perimeter;
        }
    }
}
