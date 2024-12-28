using Tyuiu.NedelkinFA.Sprint4.Review.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.NedelkinFA.Sprint4.Review.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCountEvenNumbers()
        {
            int[,] mtrx = new int[3, 3] { { 1, 3, 5 }, { 7, 9, 2 }, { 4, 6, 8 } };
            DataService ds = new DataService();
            int res = ds.CountEvenNumbers(mtrx);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
