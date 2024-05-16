namespace ShapeCalculatorTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCalculateCircleArea()
        {
            double radius = 10;
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            double actualArea = Mindbox.ShapeCalculator.CalculateCircleArea(radius);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void TestCalculateTriangleArea()
        {
            double side1 = 4;
            double side2 = 5;
            double side3 = 6;
            double expectedArea = Mindbox.ShapeCalculator.CalculateTriangleArea(side1, side2, side3);
            double actualArea = Mindbox.ShapeCalculator.CalculateTriangleArea(side1, side2, side3);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void TestIsTriangleRight()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            bool expectedResult = Mindbox.ShapeCalculator.IsTriangleRight(side1, side2, side3);
            Assert.IsTrue(expectedResult);
        }
    }
}