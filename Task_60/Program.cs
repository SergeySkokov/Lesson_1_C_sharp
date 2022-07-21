//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2

//66(0, 0, 0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)
GetMatrix();

static void GetMatrix()
{
    Console.WriteLine("Задайте размер матрицы:");
    Console.Write("Выберите длину массива: ");
    int lengthMatrix = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Выберите высоту массива: ");
    int heightMatrix = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Выберите ширину массива: ");
    int widthMatrix = int.Parse(Console.ReadLine());
    Console.WriteLine();
    int[,,] Matrix = new int[lengthMatrix, heightMatrix, widthMatrix];
    Random rnd = new Random();

    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix.GetLength(2); k++)
            {
                Matrix[i, j, k] = rnd.Next(1, 10);
            }
        }
    }
    Console.WriteLine();
    PrintArray(Matrix);

}

static void PrintArray(int[,,] arrPrint)
{
    Console.WriteLine();
    for (int i = 0; i < arrPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrPrint.GetLength(1); j++)
        {
            for (int k = 0; k < arrPrint.GetLength(2); k++)
            {
                Console.Write($"{arrPrint[i, j, k]} ({i})({j})({k})");

                if (j + 1 != arrPrint.GetLength(1) || k + 1 != arrPrint.GetLength(2)) Console.Write(", ");

            }
            Console.WriteLine();
        }

    }
}
