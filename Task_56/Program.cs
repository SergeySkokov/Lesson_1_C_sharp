//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки
//с наименьшей суммой элементов: 1 строка
GetMatrix();
static void GetMatrix()
{
    Console.WriteLine("Задайте размер матрицы:");
    Console.Write("Выберите количество строк: ");
    int rowMatrix = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Выберите количество столбцов: ");
    int colMatrix = int.Parse(Console.ReadLine());
    Console.WriteLine();
    int[,] Matrix = new int[rowMatrix, colMatrix];
    Random rnd = new Random();

    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = rnd.Next(1, 10);
        }
    }
    Console.WriteLine();
    int[] sourceMin = GetSumRowMatrix(Matrix);
    int result = SourceMinValue(sourceMin);
    PrintArray(Matrix, result);

}
static int[] GetSumRowMatrix(int[,] matr)
{
    int[] sumRows = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumRows[i] += matr[i, j];
        }
    }
    return sumRows;
}
static int SourceMinValue(int[] minValue)
{
    int numberTemp = minValue[0];
    int numberString = 0;
    for (int i = 0; i < minValue.Length; i++)
    {
        if (numberTemp > minValue[i])
        {
            numberTemp = minValue[i];
            numberString = i;
        }
    }
    return numberString;
}
static void PrintArray(int[,] arrPrint, int printRes)
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
    Console.WriteLine($"Строка с наименьшей суммой элементов: {printRes + 1}");
}
