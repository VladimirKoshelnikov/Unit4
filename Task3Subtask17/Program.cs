using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
        int countPositive = 0;
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            int temp = 0;
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                temp = arr[i, j];
                for (int k = 0; k <= arr.GetUpperBound(1); k++)
                {
                    if (arr[i, k] >= arr[i, j])
                    {
                        temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
            }
        }
        Console.WriteLine();
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
         
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();

        }
        Console.ReadKey();
    }
}