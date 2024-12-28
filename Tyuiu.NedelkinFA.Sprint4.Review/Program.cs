using Tyuiu.NedelkinFA.Sprint4.Review.Lib;

int rows = 3;
int columns = 3;
int[,] mtrx = new int[rows, columns];
string str = "135792468";
DataService ds = new DataService();
int index = 0;

Console.WriteLine("\nМатрица:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        mtrx[i, j] = int.Parse(str[index].ToString());
        Console.Write($"{mtrx[i, j]}\t");
        index++;
    }
    Console.WriteLine();
}

int evenCount = ds.CountEvenNumbers(mtrx);
Console.WriteLine("\nКоличество четных чисел = " + evenCount);
Console.ReadKey();
