using Tyuiu.NedelkinFA.Sprint3.Review.Lib;

namespace Tyuiu.NedelkinFA.Sprint3.Review.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 18.14;
            valueWaitArray[1] = 10.62;
            valueWaitArray[2] = 5.39;
            valueWaitArray[3] = 0.0;
            valueWaitArray[4] = -4.88;
            valueWaitArray[5] = -10.0;
            valueWaitArray[6] = -16.16;
            valueWaitArray[7] = -23.44;
            valueWaitArray[8] = -31.95;
            valueWaitArray[9] = -41.8;
            valueWaitArray[10] = -53.16;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}