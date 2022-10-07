using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string a, b;
        // Если не задавать значения, то программа не компилируется. 
        Console.WriteLine("Если не задавать значения, то программа не компилируется.");
        Console.WriteLine();
        Console.WriteLine("Введите строку №1");
        a = Console.ReadLine();
        
        Console.WriteLine("Введите строку №2");
        b = Console.ReadLine();

        bool c = a != b;

        Console.WriteLine(c);
        Console.ReadKey();
    }
}