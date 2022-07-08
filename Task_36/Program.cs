// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[99];
array = Completion(array);
int resSumOddnum = GetSumOddNumbers(array);
PrintArray(array, resSumOddnum);

static int[] Completion(int[] arr)
{
    Random number = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = number.Next(1, 100);
    }
    return arr;
}

static int GetSumOddNumbers(int[] arr)
{
    int sumOddnum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sumOddnum += arr[i];
    }
    return sumOddnum;
}

static void PrintArray(int[] print, int odd)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write($"{print[i]}, ");
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма нечетных чисел массива = {odd}");
}