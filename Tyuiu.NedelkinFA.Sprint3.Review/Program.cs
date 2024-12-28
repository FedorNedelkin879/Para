using Tyuiu.NedelkinFA.Sprint3.Review.Lib;

DataService ds = new DataService();
int startValue = -5;
int stopValue = 5;
Console.WriteLine("start = " + startValue);
Console.WriteLine("stop = " + stopValue);
int len = ds.GetMassFunction(startValue, stopValue).Length;
double[] valueArray;
valueArray = new double[len];
valueArray = ds.GetMassFunction(startValue, stopValue);
Console.WriteLine("x     |    f(x)");
for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine("{0,5:d}   |    {1,5:f2} ", startValue, valueArray[i]);
    startValue++;
}
Console.ReadKey();
