// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7->такого числа в массиве нет
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
    SearchValueMatrix(array);
}
static void SearchValueMatrix(int[,] arrayMatrix)
{
    Console.Write("Введите номер строки: ");
    int numRow = int.Parse(Console.ReadLine()) - 1;
    Console.WriteLine();
    Console.Write("Введите номер столбца: ");
    int numCol = int.Parse(Console.ReadLine()) - 1;

    if (numRow > arrayMatrix.GetLength(0) || numCol > arrayMatrix.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет.");
    }
    else PrintArray(arrayMatrix, arrayMatrix[numRow, numCol]);
}


static void PrintArray(int[,] arrPrint, int num)
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
    Console.WriteLine($"Значение элемента => {num}");
}