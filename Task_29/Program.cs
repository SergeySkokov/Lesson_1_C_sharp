// Напишите программу, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
int[] array = new int[8];
array = Completion(array);
PrintArray(array);
static int[] Completion(int[] arr)
{
    Random number = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = number.Next(1, 99);
    }
    return arr;
}

static void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write($"{print[i]}, ");
    }
}