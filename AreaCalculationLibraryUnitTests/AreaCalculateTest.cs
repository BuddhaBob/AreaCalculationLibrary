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
    public class AreaCalculateTest
    {
        [TestMethod]
        public void Init_SingleDerivedShape_ReturnsShape()
        {
            //Arrange
            Shape circle = new Circle(20);

            //Act
            var circleInit = AreaCalculationLibrary.AreaCalculate.ShapeCharacteristic(circle);

            //Assert
            Assert.AreEqual(circle, circleInit);
        }
    }
}
