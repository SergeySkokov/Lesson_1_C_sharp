//Задача 54: Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8
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
    PrintArray(array);
    Console.WriteLine();
    GetSortingMatrix(array);
}
static void GetSortingMatrix(int[,] sortingMatrix)
{
    for (int i = 0; i < sortingMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < sortingMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < sortingMatrix.GetLength(1) - 1; k++)
            {
                if (sortingMatrix[i, k] > sortingMatrix[i, k + 1])
                {
                    int sortTemp = sortingMatrix[i, k + 1];
                    sortingMatrix[i, k + 1] = sortingMatrix[i, k];
                    sortingMatrix[i, k] = sortTemp;
                }
            }
        }
    }
    PrintArray(sortingMatrix);
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
