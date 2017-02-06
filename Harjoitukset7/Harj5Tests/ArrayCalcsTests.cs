using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Harj5.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        /// <summary>
        /// Vain average ja sumtest menee läpi tyhjällä taululla. Vika voi olla LINQ:n käytössä,
        /// koska averagetest ei mene läpi sitä käytettäessä expected:in saamiseksi
        /// </summary>
        double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 }; 
        double expected, actual;
        [TestMethod()]
        public void SumTest()
        {
            expected = array.Sum();
            actual = ArrayCalcs.Sum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AverageTest()
        {
            double sum = 0;
            foreach (double d in array)
            {
                sum = sum + d;
            }
            expected = sum / array.Length;
            // expected = array.Average ei toimi tyhjällä taulukolla
            actual = ArrayCalcs.Average(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            expected = array.Min();
            actual = ArrayCalcs.Min(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            expected = array.Max();
            actual = ArrayCalcs.Max(array);
            Assert.AreEqual(expected, actual);
        }
    }
}