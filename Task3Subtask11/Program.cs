using System;


class MainClass
{
    public static void Main(string[] args)
    {
        int[,] array = { 
            { 1, 2, 3 }, 
            { 5, 6, 7 }, 
            { 8, 9, 10 }, 
            { 11, 12, 13 } };
        for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
        {
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
                Console.Write(array[i, j] + " ");

            Console.WriteLine();
        }
        Console.ReadKey();
    }
}            