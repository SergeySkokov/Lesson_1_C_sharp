// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = SumDigits(number);
PrintSum(number, result);

static int SumDigits(int res)
{
    int resTemp;
    int count = 1;
    int numTemp = res;
    for (int i = 0; numTemp / 10 != 0; i++)
    {
        numTemp /= 10;
        count *= 10;
    }
    int result = res / count;

    for (int i = 0; res / 10 != 0; i++)
    {
        resTemp = res % 10;
        result += resTemp;
        res /= 10;
    }
    return result;
}

static void PrintSum(int num, int print)
{
    Console.WriteLine($"Сумма всех цифр числа {num} равна {print}");
}