namespace Mindbox
{
    public class ShapeCalculator
    {
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CalculateTriangleArea(double side1, double side2, double side3)
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        public static bool IsTriangleRight(double side1, double side2, double side3)
        {
            double a = side1;
            double b = side2;
            double c = side3;
            return (a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b);
        }
    }
}