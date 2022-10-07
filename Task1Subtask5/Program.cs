using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int a, b;
        double x, y;

        // Если не задавать значения, то программа компилируется, но так неинтересно.

        Console.WriteLine("Введите целое число а");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите целое число b");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Введите дробное число x");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите дробное число y");
        y = double.Parse(Console.ReadLine());

        bool c = (a < b) | (x > y);

        Console.WriteLine($"Логическое выражение (a < b) | (x > y) = {c}");
        Console.ReadKey();
    }
}