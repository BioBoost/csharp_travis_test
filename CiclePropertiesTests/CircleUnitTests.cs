using System;
using CircleProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CiclePropertiesTests
{
    [TestClass]
    public class CircleUnitTests
    {
        [TestMethod]
        public void testUninitializedRadius()
        {
            Circle circle = new Circle();
            Assert.AreEqual(0, circle.Radius, 0.001, "Radius attribuut is niet geinitializeerd op 0");
        }

        [TestMethod]
        public void testRadiusProperty()
        {
            Circle circle = new Circle();
            circle.Radius = 12.5;
            Assert.AreEqual(12.5, circle.Radius, 0.001);
        }

        [TestMethod]
        public void testNegativeRadiusProperty()
        {
            Circle circle = new Circle();
            circle.Radius = 12.5;
            circle.Radius = -102.32;
            Assert.AreEqual(12.5, circle.Radius, 0.001);
        }

        [TestMethod]
        public void testArea()
        {
            Circle circle = new Circle();
            circle.Radius = 12.5;
            Assert.AreEqual(490.873, circle.area(), 0.001);
        }

        [TestMethod]
        public void testCircumference()
        {
            Circle circle = new Circle();
            circle.Radius = 12.5;
            Assert.AreEqual(78.539, circle.circumference(), 0.001);
        }
    }
}
