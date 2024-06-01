using ShapeCalculatorLibrary;

namespace ShapeCalculatorTests
{
    public class Test
    {
        [Fact]
        public void TestCircleArea()
        {
            var circle = new Circle(6);
            double area = circle.CalculateArea();
            Assert.Equal(Math.PI * 36, area, 10);
        }

        [Fact]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(3, 4, 5);
            double area = triangle.CalculateArea();
            Assert.Equal(6, area, 10);
        }

        [Fact]
        public void TestRightTriangleCheck()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void TestNonRightTriangleCheck()
        {
            var triangle = new Triangle(6, 4, 6);
            Assert.False(triangle.IsRightTriangle());
        }

        [Fact]
        public void TestCalculateArea()
        {
            IShape circle = new Circle(7);
            IShape triangle = new Triangle(3, 4, 5);

            double circleArea = AreaCalculator.CalculateArea(circle);
            double triangleArea = AreaCalculator.CalculateArea(triangle);

            Assert.Equal(Math.PI * 49, circleArea, 10);
            Assert.Equal(6, triangleArea, 10);
        }
    }
}