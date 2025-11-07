
internal partial class Tasks
{
    enum Semaphore : int
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }

    static void Main(string[] args)
    {
        //Task3_3();
        //Task3_4();
        Task4_3();
    }

    static void Task3_3()
    {
        Console.WriteLine("Как вас зовут?");
        string Name = Console.ReadLine();

        Console.WriteLine("Сколько вам лет?");
        string Age = Console.ReadLine();

        Console.WriteLine("Если ли у вас питомец?");
        string Pet = Console.ReadLine();

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
        Console.WriteLine("День недели");

        DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());

        Console.WriteLine("{0}",day);
    }

    static void Task4_3()
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int temp;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        foreach (var item in arr)
        {
            Console.Write(item);
        }
    }
}