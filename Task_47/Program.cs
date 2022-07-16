// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

GetMatrix();

static void GetMatrix()
{
    Console.WriteLine("Задайте размер таблицы:");
    Console.Write("Выберите количество строк: ");
    int row = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Выберите количество столбцов: ");
    int col = int.Parse(Console.ReadLine());
    Console.WriteLine();
    double[,] array = new double[row, col];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble() + rnd.Next(1, 9), 2);
        }
    }
    PrintResAndArray(array);
}
static void PrintResAndArray(double[,] arrPrint)
{
    Console.WriteLine();
    for (int i = 0; i < arrPrint.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arrPrint.GetLength(1); j++)
        {
            Console.Write(arrPrint[i, j]);
            if (j + 1 != arrPrint.GetLength(1))
            {
                double temp = arrPrint[i, j];
                string separator = ",";
                string space = " ";
                if (temp % 1 == 0) Console.Write(separator + space + space + space);
                else if ((temp * 10) % 1 == 0) Console.Write(separator + space + space);
                else Console.Write(separator + space);
            }
            else Console.Write("]");
        }
        Console.WriteLine();
    }
}