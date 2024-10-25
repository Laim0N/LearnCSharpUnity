using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в генератор персонажа!");

        Console.Write("Введите имя персонажа: ");
        string? name = Console.ReadLine();

        Console.Write("Введите возраст: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите класс персонажа (Воин/Маг/Лучник): ");
        string? classChar = Console.ReadLine();

        Random rnd = new Random();
        int isHealthChar = rnd.Next(80, 100);
        int isStrChar = rnd.Next(10, 20);

        Console.WriteLine("Создан новый персонаж:/n");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Класс: {classChar}");
        Console.WriteLine($"Ваш персонаж имеет {isHealthChar} здоровья и {isStrChar} силы.");

    }
}