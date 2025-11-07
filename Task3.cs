internal class Task3
{
    static void Main(string[] args)
    {
        Task3_3();
    }

    static void Task3_3()
    {
        Console.WriteLine("Как вас зовут?");
        string Name = Console.ReadLine();

        Console.WriteLine("Сколько вам лет?");
        string Age = Console.ReadLine();

        Console.WriteLine("Если ли у вас питомец?");
        bool Pet = Console.ReadLine();

        Console.WriteLine("Какой у вас размер ноги?");
        string FootSize = Console.ReadLine();

        Boolean PetType;
        if (Pet == "Yes" || Pet == "Да")
        {
            PetType = true;
        }
        else
        {
            PetType = false;
        }


        Console.WriteLine("My name is {0}\nMy age is {1}\nDo I have a pet? {2}\nMy shoe size is {3}", Name,Age, PetType, FootSize);

        Console.ReadKey();
    }

    static void Task3_4()
    {
        enum Semaphore : int
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
    }
}