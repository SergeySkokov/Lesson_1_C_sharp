// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.Write("Введите число A:");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите число В:");
int secondNumber = int.Parse(Console.ReadLine());
int result = Pow(firstNumber, secondNumber);
PrintPow(firstNumber, secondNumber, result);


static int Pow(int numA, int numB)
{
    int temp = numA;
    for (int i = 1; i < numB; i++)
    {
        numA = numA * temp;
    }
    return numA;
}

static void PrintPow(int firstnum, int secondnum, int res)
{
    Console.Write($"Число {firstnum} в степени {secondnum} равно {res}");
}
