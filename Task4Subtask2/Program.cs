using System;
class MainClass
{
    public static void Main(string[] args)
    {
        (string name, int age) anketa; // Добавляем кортеж anketa с полями для записи name и age
        Console.WriteLine("Введите имя");
        anketa.name = Console.ReadLine();
        Console.WriteLine("Введите ваш возраст");
        anketa.age = int.Parse(Console.ReadLine());
        Console.ReadKey();
    }
}