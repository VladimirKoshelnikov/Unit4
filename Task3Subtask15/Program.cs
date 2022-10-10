using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int[] array = { 1, -2, 3, 4, -8, 6, 4, 23, -4, 5, 8, -3, 7, 1, -5, -5, -3, -9, 6 };
        int countPositive = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                countPositive++;
            }
            
        }
        Console.WriteLine(countPositive);
        Console.ReadKey();
    }
}