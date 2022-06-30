Console.WriteLine("Программа, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.");

    Console.WriteLine(" ");

    Console.WriteLine("Введите трехзначное число: ");

    int value = int.Parse(Console.ReadLine());

    int result = value / 100;

    Console.WriteLine("Последнее цифра данного числа: " + result);