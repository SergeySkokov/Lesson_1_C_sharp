int max, min;

Console.WriteLine("Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

Console.WriteLine(" ");

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
