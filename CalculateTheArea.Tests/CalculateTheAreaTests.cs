using Xunit;

namespace CalculateTheArea.Tests
{
    public class CalculateTheAreaTests
    {
        [Fact]
        public void CircleRadiusTestNegative()
        {
            // Arrange
            Circle circle = new Circle(-5);

            // Act
            bool result = circle.CheckRadius(-5);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void CircleRadiusTest()
        {
            // Arrange
            Circle circle = new Circle(10);

            // Act
            bool result = circle.CheckRadius(10);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TriangleTest()
        {
            // Arrange
            Triangle triangle = new Triangle(3,5,4);

            // Act
            double result = triangle.Area;

            // Assert
            Assert.Equal(6, result);
        }
        [Fact]
        public void TriangleRightAngleTest()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 5, 4);

            // Act
            string result = triangle.TypeTriangle(3,5,4);

            // Assert
            Assert.Equal("прямоугольного", result);
        }

    }
}
