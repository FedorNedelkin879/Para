using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NedelkinFA.Sprint4.Review.Lib
{
    public class DataService
    {
        public int Calculate(int[,] mtrx)
        {
            int product = 1;
            bool hasEven = false;

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        product *= mtrx[i, j];
                        hasEven = true;
                    }
                }
            }

            return hasEven ? product : 0;
        }

        public int CountEvenNumbers(int[,] mtrx)
        {
            int count = 0;
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
