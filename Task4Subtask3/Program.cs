using System;
class MainClass
{
    public static void Main(string[] args)
    {
        var (name, age) = ("Владимир", 27);
        Console.WriteLine("Исходное имя: {0}", name);
        Console.WriteLine("Исходный возраст: {0}", age);

        Console.WriteLine("Введите ваше имя");
        name = Console.ReadLine();
        Console.WriteLine("Введите ваш возраст");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);
        Console.ReadKey();
    }
}
