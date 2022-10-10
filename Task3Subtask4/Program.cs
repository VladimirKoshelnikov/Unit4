using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string name;
        Console.WriteLine("Введите ваше имя");
        name = Console.ReadLine();
        Console.WriteLine("Ваше имя по буквам:");
        for (int i = 0; i < name.Length; i++)
        {
            Console.Write($"{name[i]} "); 
        }
        Console.WriteLine();

        Console.WriteLine($"Первая буква вашего имени {name[0]}");
        Console.WriteLine($"Последняя буква вашего имени {name[name.Length - 1]}");
        Console.ReadKey();
    }
}