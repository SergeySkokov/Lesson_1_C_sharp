// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int count = 1;
int temp = number;
if (number > 99)
{
    while (temp / 10 != 0)
    {
        temp = temp / 10;
        count *= 10;
    }
    count = count / 100;
    int result = (number / count) % 10;

    Console.WriteLine("Третьей цифрой числа " + number + " является " + result);
} else Console.WriteLine("Третьего числа нет.");
