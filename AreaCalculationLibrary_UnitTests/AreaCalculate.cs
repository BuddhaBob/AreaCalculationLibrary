using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaCalculationLibrary_UnitTests
{
    [TestClass]
    public class AreaCalculate
    {
        [TestMethod]
        public void CircleArea_radius12_returned452()
        {
            //Arrange
            double radius = 12;
            AreaCalculationLibrary.Interfaces.IArea circleArea = new AreaCalculationLibrary.Classes.Circle(radius);
            string expectedValue = "Area of circle: 452,3893421169302";

            //Act
            AreaCalculationLibrary.AreaCalculate result = new AreaCalculationLibrary.AreaCalculate(circleArea);


            //Assert
            Assert.AreEqual(expectedValue.Trim(), result.ToString().Trim());
        }
    }
}
