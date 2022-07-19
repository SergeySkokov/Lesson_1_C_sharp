//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
GetMatrixs();

static void GetMatrixs()
{
    Console.WriteLine("Задайте размер матриц:");
    Console.Write("Выберите количество строк для первой матрицы: ");
    int rowFirstMatrix = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Выберите количество столбцов для первой матрицы: ");
    int colFirstMatrix = int.Parse(Console.ReadLine());
    Console.WriteLine();
    int[,] firstMatrix = new int[rowFirstMatrix, colFirstMatrix];
    Random rnd = new Random();

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            firstMatrix[i, j] = rnd.Next(1, 10);
        }
    }

    Console.WriteLine();
    Console.Write("Выберите количество строк для второй матрицы: ");
    int rowSecondMatrix = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Выберите количество столбцов для второй матрицы: ");
    int colSecondMatrix = int.Parse(Console.ReadLine());
    Console.WriteLine();
    int[,] secondMatrix = new int[rowSecondMatrix, colSecondMatrix];

    for (int i = 0; i < secondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            secondMatrix[i, j] = rnd.Next(1, 10);
        }
    }
    PrintArray(firstMatrix);
    PrintArray(secondMatrix);
    Console.WriteLine();
    if (colFirstMatrix == rowSecondMatrix)
    {
        int[,] resultMultMatrix = GetMultiplicationMatrix(firstMatrix, secondMatrix);
        PrintArray(resultMultMatrix);
    }
    else Console.WriteLine("Умножение двух матриц невозможно! Количество столбцов первой матрицы" +
                           " не равно количеству строк второй матрицы." +
                           "\nМатрицы, для которых данное условие не выполняется, умножать нельзя.");
    Console.WriteLine();
}
static int[,] GetMultiplicationMatrix(int[,] firstMatr, int[,] secondMatr)
{
    int[,] result = new int[firstMatr.GetLength(0), secondMatr.GetLength(1)];
    for (int i = 0; i < firstMatr.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatr.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatr.GetLength(0); k++)
            {
                result[i, j] += firstMatr[i, k] * secondMatr[k, j];
            }
        }
    }
    return result;
}
static void PrintArray(int[,] arrPrint)
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
}