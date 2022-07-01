//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число: ");
int firstValue = int.Parse(Console.ReadLine());

if (firstValue > 99 && firstValue < 1000)
{
    firstValue = (firstValue / 10) % 10;
    Console.WriteLine("Вторая цифра данного числа: " + firstValue);
} 
else Console.WriteLine("Число " + firstValue + " не трёхзначное");