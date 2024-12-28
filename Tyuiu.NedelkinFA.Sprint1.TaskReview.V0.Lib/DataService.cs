namespace Tyuiu.NedelkinFA.Sprint1.TaskReview.V16.Lib
{
    public class DataService
    {
        public double Calculate(double x)
        {
            double z = Math.Sin(Math.Sqrt(x * x)) + (Math.Cos(x * x) / (3 * x * x * x)) - Math.Sin(Math.Sqrt(x * x - 1));

            return z;
        }
    }
}
