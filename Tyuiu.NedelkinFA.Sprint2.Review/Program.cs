using Tyuiu.NedelkinFA.Sprint2.Review.Lib;

Console.WriteLine("x");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y");
double y = Convert.ToDouble(Console.ReadLine());
DataService ds = new DataService();
bool res = ds.CheckDotInShadedArea(x, y);
if (res)
{
    Console.WriteLine("в обл");
}
else
{
    Console.WriteLine("не в обл");
}
Console.ReadKey();