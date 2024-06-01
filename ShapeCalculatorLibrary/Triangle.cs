namespace ShapeCalculatorLibrary
{
    public class Triangle : IShape
    {
        public double _a { get; }
        public double _b { get; }
        public double _c { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("All sides must be positive");
            
            if (!(a + b > c && a + c > b && b + c > a))
                throw new ArgumentException("Sides do not form a triangle");

            _a = a;
            _b = b;
            _c = c;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (_a + _b + _c) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _a) * (semiPerimeter - _b) * (semiPerimeter - _c));
        }

        public bool IsRightTriangle()
        {
            double aSquared = _a * _a;
            double bSquared = _b * _b;
            double cSquared = _c * _c;
            if (aSquared + bSquared == cSquared || aSquared + cSquared == bSquared || bSquared + cSquared == aSquared)
                return true;

            return false;
        }

    }
}
