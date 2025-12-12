using System;

class Program
{
    static void Main(string[] args)
    {
        var user = EnterUserData();
        PrintUser(user);
    }

    static (string Name, string LastName, int Age, string[] Pets, string[] Colors) EnterUserData()
    {
        (string Name, string LastName, int Age, string[] Pets, string[] Colors) User;

        Console.WriteLine("Введите имя:");
        User.Name = Console.ReadLine();

        Console.WriteLine("Введите фамилию:");
        User.LastName = Console.ReadLine();

        int tempAge;
        do
        {
            Console.WriteLine("Введите возраст (число > 0):");
        } while (CheckNum(Console.ReadLine(), out tempAge));
        User.Age = tempAge;

        Console.WriteLine("Есть ли у вас питомцы? (Да/Нет):");
        var answer = Console.ReadLine().Trim().ToLower();

        if (answer == "Да")
        {
            int petCount;
            do
            {
                Console.WriteLine("Введите количество питомцев:");
            } while (CheckNum(Console.ReadLine(), out petCount));

            User.Pets = CreateArrayPets(petCount);

            for (int i = 0; i < User.Pets.Length; i++)
            {
                Console.WriteLine($"Введите кличку питомца #{i + 1}:");
                User.Pets[i] = Console.ReadLine();
            }
        }
        else
        {
            User.Pets = null;
        }

        int colorCount;
        do
        {
            Console.WriteLine("Введите количество любимых цветов:");
        } while (CheckNum(Console.ReadLine(), out colorCount));

        User.Colors = CreateArrayColors(colorCount);

        for (int i = 0; i < User.Colors.Length; i++)
        {
            Console.WriteLine($"Введите любимый цвет #{i + 1}:");
            User.Colors[i] = Console.ReadLine();
        }

        return User;
    }

    static bool CheckNum(string number, out int corrnumber)
    {
        if (int.TryParse(number, out int intnum))
        {
            if (intnum > 0)
            {
                corrnumber = intnum;
                return false;
            }
        }

        corrnumber = 0;
        Console.WriteLine("Некорректный ввод! Повторите попытку.");
        return true;
    }

    static string[] CreateArrayPets(int num)
    {
        return new string[num];
    }

    static string[] CreateArrayColors(int num)
    {
        return new string[num];
    }

    static void PrintUser((string Name, string LastName, int Age, string[] Pets, string[] Colors) user)
    {
        Console.WriteLine("ДАННЫЕ ПОЛЬЗОВАТЕЛЯ");
        Console.WriteLine($"Имя: {user.Name}");
        Console.WriteLine($"Фамилия: {user.LastName}");
        Console.WriteLine($"Возраст: {user.Age}");

        if (user.Pets != null)
        {
            Console.WriteLine("Питомцы:");
            foreach (var pet in user.Pets)
                Console.WriteLine(" - " + pet);
        }
        else
        {
            Console.WriteLine("Питомцы: нет");
        }

        Console.WriteLine("Любимые цвета:");
        foreach (var c in user.Colors)
            Console.WriteLine(" - " + c);
    }
}
