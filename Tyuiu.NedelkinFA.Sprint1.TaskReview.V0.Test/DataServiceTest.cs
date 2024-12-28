using Tyuiu.NedelkinFA.Sprint1.TaskReview.V16.Lib;

namespace Tyuiu.NedelkinFA.Sprint1.TaskReview.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double wait = 0.026;
            var res = ds.Calculate(x);
            res = Math.Round(res, 3);
            Assert.AreEqual(wait, res);
        }
    }
}