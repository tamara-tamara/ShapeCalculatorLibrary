namespace ShapeCalculatorLibrary
{
    public class Circle : IShape
    {
        public double _radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be positive");
            }

            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
