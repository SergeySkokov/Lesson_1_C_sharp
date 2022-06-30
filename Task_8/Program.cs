Console.WriteLine("Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

    Console.WriteLine(" ");

    Console.WriteLine("Введите число: ");

    int value = int.Parse(Console.ReadLine());

    for (int i = 1; i <= value; i++) if (i % 2 == 0) Console.WriteLine(i);