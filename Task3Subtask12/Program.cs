using System;
class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int temp = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();

        for (int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr.Length ; j++)
            {
                if (arr[i] <= arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }

        Console.WriteLine();
        Console.ReadKey();
    }
}