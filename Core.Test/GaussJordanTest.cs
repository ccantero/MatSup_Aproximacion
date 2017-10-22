using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test
{
    [TestClass]
    public class GaussJordanTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var gaussJordan = new GaussJordan();

            var input = new double[][]
            {
                new double[] {2, 3, 4, 5},
                new double[] {5, 6, 8, 3},
                new double[] {2, 6, 9, 15},
            };

            var result = gaussJordan.Resolve(input);

            Assert.AreEqual(-7, result[0]);
            Assert.AreEqual((double)55/3, result[1]);
            Assert.AreEqual(-9, result[2]);

            foreach (var columna in result)
            {
                Debug.Write($"{columna}, ");
            }
        }
    }
}
