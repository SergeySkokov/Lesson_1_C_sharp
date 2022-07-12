
EnterData();

static void EnterData()
{
    Console.Write("Введите количество чисел: ");
    int number = int.Parse(Console.ReadLine());
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    int result = NegPosit(array);
    PrintResAndArray(array, result);
}

static int NegPosit(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;   
}

static void PrintResAndArray(int[] arrPrint, int resPrint)
{
    Console.WriteLine();
    Console.Write($"Количество положительных чисел из [");

    for (int i = 0; i < arrPrint.Length; i++)
    {
        Console.Write(arrPrint[i]);
        if (i + 1 != arrPrint.Length) Console.Write(", ");
        else Console.Write("]"); ;
    }
    Console.WriteLine($" => '{resPrint}'");
    Console.WriteLine();
}