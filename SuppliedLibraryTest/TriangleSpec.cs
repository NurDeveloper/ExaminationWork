using System;
using SuppliedLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SuppliedLibraryTest
{
    [TestClass]
    public class TriangleSpec
    {
        [TestMethod]
        public void CalculatePerimeter_returns_true_perimeter_of_triangle()
        {
            Double perimeter = Triangle.CalculatePerimeter(5, 8, 9.43);

            Assert.AreEqual(22.43, perimeter);  
        }

        [TestMethod]
        public void CalculateArea_returns_true_area_of_triangle()
        {
            Double area = Triangle.CalculateArea(5, 8, 9.43);

            Assert.AreEqual(20, area);
        }

        [TestMethod]
        public void CalculateArea_returns_true_area_of_triangle_with_int_edges()
        {
            Double area = Triangle.CalculateArea(6, 8, 10);

            Assert.AreEqual(24, area);
        }

        [TestMethod]
        public void CalculateArea_returns_true_area_of_triangle_with_double_edges()
        {
            Double area = Triangle.CalculateArea(4.87, 6.12, 7.82);

            Assert.AreEqual(14.9, area);
        }
    }
}
