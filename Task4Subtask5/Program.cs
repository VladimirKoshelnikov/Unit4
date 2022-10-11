using System;
class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string Type, double Age, int NameCount) Pet;
        
        Console.WriteLine("Введите имя вашего питомца");
        Pet.Name = Console.ReadLine();

        Console.WriteLine("Введите Тип вашего питомца");
        Pet.Type = Console.ReadLine();
        
        Console.WriteLine("Введите возраст питомца ");
        Pet.Age = double.Parse(Console.ReadLine());

        Pet.NameCount = Pet.Name.Length;

        Console.WriteLine("Имя вашего питомца: {0}", Pet.Name);
        Console.WriteLine("Длина имени вашего питомца: {0}", Pet.NameCount);
        Console.WriteLine("Тип вашего питомца: {0}", Pet.Type);
        Console.WriteLine("Возраст вашего питомца {0} года", Pet.Age);
        Console.ReadKey();
    }
}