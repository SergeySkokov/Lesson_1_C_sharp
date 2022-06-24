string work_programm = "старт";
while (work_programm.ToLower() != "q")
{
    Console.WriteLine(" ");
    Console.WriteLine("Введите номер задачи ('2', '4', '6', '7', 8'): ");
    Console.WriteLine(" ");
    Console.WriteLine("или наберите 'q' для завершения");

    work_programm = Console.ReadLine();

    if (work_programm.ToLower() == "q") return;

    int task_number = int.Parse(work_programm);

    switch (task_number)
    {
        case 2:
            Task_2();
            break;
        case 4:
            Task_4();
            break;
        case 6:
            Task_6();
            break;
        case 7:
            Task_7();
            break;
        case 8:
            Task_8();
            break;

        default:
            Console.WriteLine("Вы ввели неверное значение");
            break;
    }

}


static void Task_2()//Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
{
    int max, min;

    Console.WriteLine("Введите первое число: ");

    int firstValue = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите второе число: ");

    int secondValue = int.Parse(Console.ReadLine());

    if (firstValue < secondValue)
    {
        max = secondValue;
        min = firstValue;
    }
    else
    {
        max = firstValue;
        min = secondValue;
    }
    Console.WriteLine("Максимальное число: " + max + " Минимальное число: " + min);
}

static void Task_4()//Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
{
    int max;

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
}

static void Task_6()//Программа, которая на вход принимает число и выдаёт, является ли число чётным.
{
    Console.WriteLine("Введите число: ");

    int value = int.Parse(Console.ReadLine());

    if (value % 2 == 0) Console.WriteLine("Число " + value + " чётное");

    else Console.WriteLine("Число " + value + " нечётное");
}

static void Task_7(//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
        {
            Console.WriteLine("Введите трехзначное число: ");

int value = int.Parse(Console.ReadLine());

int result = value / 100;

Console.WriteLine("Последнее цифра данного числа: " + result);
        }

        static void Task_8()//Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
{
    Console.WriteLine("Введите число: ");

    int value = int.Parse(Console.ReadLine());

    for (int i = 1; i <= value; i++) if (i % 2 == 0) Console.WriteLine(i);
}
