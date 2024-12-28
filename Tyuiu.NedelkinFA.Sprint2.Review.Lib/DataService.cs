namespace Tyuiu.NedelkinFA.Sprint2.Review.Lib
{
    public class DataService
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (y >= x);
        }
    }
}