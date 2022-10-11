using System;
class MainClass
{
    /*Необходимо разработать методику анкетирования пользователей. 
    Требуется сохранять информацию: 
    имя пользователя, 
    фамилия, 
    логин, 
    длина логина, 
    наличии/отсутствии у пользователя питомца, 
    возрасте пользователя, 
    трех любимых цветах пользователя.*/

    public static void Main(string[] args)
    {


    /*4.5.1 
    Задайте кортеж User, который описывает необходимую информацию.
    */
    (string Name, string Soname, string Login, int LoginCount, bool HasPet, double Age, string[] FavColor)User;

    /*Задание 4.5.6
    Сделайте так, чтобы опрос повторялся для трех пользователей.
    */
    for(int k = 0; k < 3; k++)
        {
        /*4.5.2
        Заполните кортеж User значениями с клавиатуры для полей: 
        имя пользователя, 
        фамилия, 
        логин.
        */

        Console.WriteLine("Введите имя пользователя");
        User.Name = Console.ReadLine();

        Console.WriteLine("Введите фамилию пользователя");
        User.Soname = Console.ReadLine();

        Console.WriteLine("Введите логин пользователя");
        User.Login = Console.ReadLine();
        /*
        Задание 4.5.3
        Вычислите длину логина пользователя.
        */
        User.LoginCount = User.Login.Length;

        /*
        Задание 4.5.4
        Напишите условие, которое устанавливает значение ИСТИНА в поле наличие/отсутствие животных, 
        если пользователь вводит "Да", и ЛОЖЬ при любом другом варианте.*/

        Console.WriteLine("Есть ли у пользователя домашние животные?");
        string result = Console.ReadLine(); 
        if (result=="Да"){
            User.HasPet = true;
            }
        else{
            User.HasPet = false;
            }
        /*
        Задание 4.5.5
        Напишите код для ввода возраста пользователя и трех его любимых цветов.
        */

        Console.WriteLine("Введите возраст пользователя");
        User.Age = double.Parse(Console.ReadLine());

        User.FavColor = new string[3];
        for(int i = 0; i < 3; i++){
            Console.WriteLine("Введите любимый цвет пользователя №{0}", i+1);
            User.FavColor[i] = Console.ReadLine();
            } 
        }
    Console.ReadKey();
    }
}