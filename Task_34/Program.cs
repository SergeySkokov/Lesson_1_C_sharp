// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[899];
array = Completion(array);
int evenNum = GetQuantityEvenNum(array);
PrintArray(array, evenNum);

static int[] Completion(int[] arr)
{
    Random number = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = number.Next(100, 1000);
    }
    return arr;
}

static int GetQuantityEvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

static void PrintArray(int[] print, int even)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write($"{print[i]}, ");
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел в массиве = {even}");
}