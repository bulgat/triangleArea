using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using LibraryTriangleArea;

namespace UnitTestTriangleArea
{
    [TestClass]
    public class UnitTest1
    {
        // Test Проверка корректности площади прямоугольного треугольника.
        [TestMethod]
        public void TestTriangleAreaSpace()
        {
            var triangle = TriangleAreaSpace.TrianglrAreaS(3,3,0);
            Assert.AreEqual("Площадь треугольника: 4,5", triangle);

        }
       
    }
}
