using Tyuiu.NedelkinFA.Sprint1.TaskReview.V16.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());
        double z = Math.Sin(Math.Sqrt(x * x)) + (Math.Cos(x * x) / (3 * x * x * x)) - Math.Sin(Math.Sqrt(x * x - 1));
        z = Math.Round(z, 3);
        Console.WriteLine($"Результат: z = {z}");
    }
}