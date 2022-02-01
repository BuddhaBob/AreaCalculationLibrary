using AreaCalculationLibrary.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaCalculationLibraryUnitTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Init_12_ReturnsPerimeter75()
        {
            //Arrange
            double initRadius = 12;
            double expectedPerimeter = 2*Math.PI*initRadius;

            //Act
            var circle = AreaCalculationLibrary.AreaCalculate.ShapeCharacteristic(new Circle(initRadius));
            double perimeter = circle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedPerimeter, perimeter);
        }

        [TestMethod]
        public void Init_12_ReturnsArea452()
        {
            //Arrange
            double initRadius = 12;
            double expectedArea = Math.PI*Math.Pow(initRadius, 2);

            //Act
            var circle = AreaCalculationLibrary.AreaCalculate.ShapeCharacteristic(new Circle(initRadius));
            double area = circle.GetArea();

            //Assert
            Assert.AreEqual(expectedArea, area);
        }
    }
}
