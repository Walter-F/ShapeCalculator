namespace Mindbox
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 5;
            double area = ShapeCalculator.CalculateCircleArea(radius);
            Console.WriteLine($"Площадь круга с радиусом {radius}: {area}");

            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            area = ShapeCalculator.CalculateTriangleArea(side1, side2, side3);
            Console.WriteLine($"Площадь треугольника со сторонами {side1}, {side2}, {side3}: {area}");

            bool isRight = ShapeCalculator.IsTriangleRight(side1, side2, side3);
            Console.WriteLine($"Треугольник со сторонами {side1}, {side2}, {side3} прямоугольный: {isRight}");
        }
    }
}
