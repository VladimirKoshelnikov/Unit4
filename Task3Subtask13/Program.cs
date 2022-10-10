using System;
class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int result = 0;
        foreach (int num in arr)
        {
            result += num;
        }
        Console.WriteLine(result); 
        Console.ReadKey();
    }
}