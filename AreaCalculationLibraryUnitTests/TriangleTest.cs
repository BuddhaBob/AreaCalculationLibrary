using AreaCalculationLibrary.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLibraryUnitTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Init_3_4_5_ReturnsPerimeter12()
        {
            //Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedPerimeter = 12;

            //Act
            var triangle = AreaCalculationLibrary.AreaCalculate.ShapeCharacteristic(new Triangle(sideA, sideB, sideC));
            double perimeter = triangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedPerimeter, perimeter);
        }

        [TestMethod]
        public void Init_3_4_5_ReturnsArea6()
        {
            //Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;

            //Act
            var triangle = AreaCalculationLibrary.AreaCalculate.ShapeCharacteristic(new Triangle(sideA, sideB, sideC));
            double area = triangle.GetArea();

            //Assert
            Assert.AreEqual(expectedArea, area);
        }

        [TestMethod]
        public void Init_3_4_5_IsRightTriangle()
        {
            //Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            bool expectedRightTriangleValue = true;

            //Act
            var triangle = AreaCalculationLibrary.AreaCalculate.ShapeCharacteristic(new Triangle(sideA, sideB, sideC));
            bool IsRightTriangle = (triangle as Triangle).IsRightTriangle();

            //Assert
            Assert.AreEqual(expectedRightTriangleValue, IsRightTriangle);
        }

        [TestMethod]
        public void Init_3_6_5_IsNotRightTriangle()
        {
            //Arrange
            double sideA = 3;
            double sideB = 6;
            double sideC = 5;
            bool expectedRightTriangleValue = false;

            //Act
            var triangle = AreaCalculationLibrary.AreaCalculate.ShapeCharacteristic(new Triangle(sideA, sideB, sideC));
            bool IsRightTriangle = (triangle as Triangle).IsRightTriangle();

            //Assert
            Assert.AreEqual(expectedRightTriangleValue, IsRightTriangle);
        }
    }
}
