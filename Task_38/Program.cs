//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] array = new double[10];
array = Completion(array);
double[] resMinMax = GetMinMaxNumbers(array);
double resPrint = DifferenceMaxMin(resMinMax);
PrintArray(array, resPrint);

static double[] Completion(double[] arr)
{
    Random number = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(number.Next(1, 10) + number.NextDouble(), 2);
    }
    return arr;
}

static double[] GetMinMaxNumbers(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        min = Math.Round(Math.Min(min, arr[i]), 2);
        max = Math.Round(Math.Max(max, arr[i]), 2);
    }
    return new[] { min, max };
}

static double DifferenceMaxMin(double[] maxMin)
{
    double min = maxMin[0];
    double max = maxMin[0];
    for (int i = 0; i < maxMin.Length; i++)
    {
        min = Math.Min(maxMin[0], maxMin[1]);
        max = Math.Max(maxMin[0], maxMin[1]);
    }
    double result = max - min;
    return result;
}

static void PrintArray(double[] print, double diff)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write($"{print[i]}, ");
    }
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {diff}");
}
