using Tyuiu.NedelkinFA.Sprint2.Review.Lib;

namespace Tyuiu.NedelkinFA.Sprint2.Review.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.7;
            double y = Math.Abs(x);
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void InvalidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = -0.5;
            double y = Math.Abs(x);
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
