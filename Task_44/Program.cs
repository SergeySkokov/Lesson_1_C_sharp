Console.Write("Введите число: ");
int numberN = int.Parse(Console.ReadLine());
int firstFib = 0;
int secondFib = 1;
int valueForSequence;
Console.WriteLine($"Последовательность чисел Фибоначчи для числа {numberN} ");
Console.Write($"{firstFib}, {secondFib}, ");
for (int i = 1; i < numberN; i++)
{
    valueForSequence = secondFib + firstFib;
    firstFib = secondFib; ;
    secondFib = valueForSequence;
    Console.Write(valueForSequence);
    if (i + 1 != numberN) Console.Write(", ");
    else break;
}
Console.WriteLine();
