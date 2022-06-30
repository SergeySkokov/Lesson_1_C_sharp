Console.WriteLine("Программа, которая на вход принимает число и выдаёт, является ли число чётным.");

    Console.WriteLine(" ");

    Console.WriteLine("Введите число: ");

    int value = int.Parse(Console.ReadLine());

    if (value % 2 == 0) Console.WriteLine("Число " + value + " чётное");

    else Console.WriteLine("Число " + value + " нечётное");
