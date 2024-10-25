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
        string weapon;
        if (classChar.ToLower() == "воин")
        {
            weapon = "меч и щит";
            Console.Write($"Твоим оружием будет {weapon}.");

        } else if (classChar.ToLower() == "маг")
        {
            weapon = "посох";
            Console.Write($"Твоим оружием будет {weapon}.");

        } else if (classChar.ToLower() == "лучник")
        {
            weapon = "лук";
            Console.Write($"Твоим оружием будет {weapon}.");
        }
        else
        {
            weapon = "палка";
            Console.Write($"Ты не выбрал класс, теперь у тебя есть {weapon}. Хех, удачи!");

        }

        Random rnd = new Random();
        int isHealthChar = rnd.Next(80, 100);
        int isStrChar = rnd.Next(10, 20);

        Console.WriteLine("Создан новый персонаж:\n");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Класс: {classChar}");
        Console.WriteLine($"Ваш персонаж имеет {isHealthChar} здоровья и {isStrChar} силы.");

        if (isStrChar >= 90)
            Console.WriteLine("ВАУ! Какой ты сильный, ты будешь сметать врагов пачками!!!");
        else
            Console.WriteLine($"Ой... А ты точно сможешь поднять {weapon}");

    }
}