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
    int[,] array = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    GetAvgColMatrix(array, row, col);
}

static void GetAvgColMatrix(int[,] avgArr, int quantityRow, int quantityCol)
{
    double[] sumCol = new double[quantityCol];
    double[] avgCol = new double[quantityCol];
    for (int i = 0; i < avgArr.GetLength(1); i++)
    {
        for (int j = 0; j < avgArr.GetLength(0); j++)
        {
            sumCol[i] += avgArr[j, i];
        }
        avgCol[i] = Math.Round((sumCol[i] / quantityRow), 2);

    }
    PrintArray(avgArr, avgCol);

}

static void PrintArray(int[,] arrPrint, double[] avgPrint)
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
                string separator = ",";
                string space = " ";
                if (j + 1 != arrPrint.Length) Console.Write(separator + space);
            }
            else Console.Write("]");
        }
        Console.WriteLine();
    }

    Console.Write("Среднее арифметическое каждого столбца: [");
    for (int i = 0; i < avgPrint.Length; i++)
    {
        Console.Write(avgPrint[i]);
        if (i + 1 != avgPrint.Length)
        {
            string separator = ",";
            string space = " ";
            if (i + 1 != arrPrint.Length) Console.Write(separator + space);
        }
        else Console.Write("]");

    }
    Console.WriteLine();
}