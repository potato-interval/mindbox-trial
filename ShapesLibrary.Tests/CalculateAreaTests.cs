using ShapesLibrary.Models;

namespace ShapesLibrary.Tests
{
    public class CalculateAreaTests
    {
        [Theory]
        [InlineData(6, 113.10)]
        [InlineData(5, 78.54)]
        [InlineData(42, 5_541.77)]
        [InlineData(-5, 0)]
        public void CalculateAreaShoudReturnCorrectValuesForCircle(double r, double expected)
        {
            // Arrange
            Circle circle = new(r);

            //  Act
            double actual = Math.Round(circle.CalculateArea(), 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(6, 8, 10, 24)]
        [InlineData(36, 48, 60, 864)]
        public void CalculateAreaShoudReturnCorrectValuesForTriangle(double a, double b, double c, double expected)
        {
            // Arrange
            Triangle triangle = new(a, b, c);

            //  Act
            double actual = triangle.CalculateArea();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, 4, 5, false)]
        [InlineData(9, 9, 6, true)]
        [InlineData(0, 48, 60, false)]
        public void IsATriangleShoudReturnCorrectValue(double a, double b, double c, bool expected)
        {
            // Arrange
            Triangle triangle = new(a, b, c);

            //  Act
            bool actual = triangle.IsATriangle();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(41, 9, 40, true)]
        [InlineData(3, 4, 5, true)]
        [InlineData(1, 2, 3, false)]
        public void IsARightAngleShoudReturnCorrectValue(double a, double b, double c, bool expected)
        {
            // Arrange
            Triangle triangle = new(a, b, c);

            //  Act
            bool actual = triangle.IsARightAngledTriangle();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}