using GeometricFigures.Figures;
using GeometricFigures.Services;

namespace GeometricFigures.Tests
{
    public class FugureServiceTests
    {
        [Fact]
        public void SquareTriangleTest()
        {
            // Arrange
            BaseFigure figure = InitTriangle(3, 4, 5);
            // Act
            var result = FigureCalculator.CalculateSquare(figure);
            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void SquareCircleTest()
        {
            // Arrange
            BaseFigure figure = InitCircle(10);
            // Act
            var result = FigureCalculator.CalculateSquare(figure);
            // Assert
            Assert.Equal(314.1592653589793, result);
        }

        [Fact]
        public void RectangleTrianglePositiveTest()
        {
            // Arrange
            var triangle = InitTriangle(3, 4, 5);
            // Act
            var result = triangle.IsRectangularTriangle;
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void RectangleTriangleNegativeTest()
        {
            // Arrange
            var triangle = InitTriangle(3, 5, 7);
            // Act
            var result = triangle.IsRectangularTriangle;
            // Assert
            Assert.False(result);
        }

        private Triangle InitTriangle(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }

        private Circl InitCircle(double r)
        {
            return new Circl(r);
        }
    }
}