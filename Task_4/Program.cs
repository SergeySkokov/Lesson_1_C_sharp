int max;

    Console.WriteLine("Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

    Console.WriteLine(" ");

    Console.WriteLine("Введите первое число: ");

    int firstValue = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите второе число: ");

    int secondValue = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите третье число: ");

    int thirdValue = int.Parse(Console.ReadLine());

    if (firstValue < secondValue)
    {
        if (secondValue < thirdValue) max = thirdValue;

        else max = secondValue;
    }
    else max = firstValue;

    Console.WriteLine("Максимальное число: " + max);