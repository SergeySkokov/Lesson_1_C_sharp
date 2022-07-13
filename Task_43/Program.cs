
GetCoordinations();

static void GetCoordinations()
{
    double[] firstCoord = new double[2];
    double[] secondCoord = new double[2];

    Console.WriteLine("Введите координаты для первой прямой.");
    Console.Write("b1: ");
    firstCoord[0] = double.Parse(Console.ReadLine());
    Console.Write("k1: ");
    firstCoord[1] = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Введите координаты для второй прямой.");
    Console.Write("b2: ");
    secondCoord[0] = double.Parse(Console.ReadLine());
    Console.Write("k2: ");
    secondCoord[1] = double.Parse(Console.ReadLine());
    Console.WriteLine();
    bool check = CheckParallel(firstCoord, secondCoord);
    if (check)
    {
        double[] result = Finding(firstCoord, secondCoord);
        PrintResAndArray(result);
    }
    else Console.WriteLine("Прямые паралельны.");
}
static bool CheckParallel(double[] first, double[] second)
{
    double[] intersection = new double[2];
    double y1, y2;
    intersection[0] = (first[0] - second[0]) / -1 / (first[1] - second[1]);
    double temp = first[1] * intersection[0] + first[0] - (second[1] * intersection[0] + second[0]);
    y1 = first[1] * intersection[0] + first[0];
    y2 = second[1] * intersection[0] + second[0];
    if (y1 - y2 == temp)
    {
        return true;
    }
    else return false;
}

static double[] Finding(double[] first, double[] second)
{
    double[] intersection = new double[2];
    double y1, y2;
    intersection[0] = (first[0] - second[0]) / -1 / (first[1] - second[1]);
    double temp = first[1] * intersection[0] + first[0] - (second[1] * intersection[0] + second[0]);
    y1 = first[1] * intersection[0] + first[0];
    y2 = second[1] * intersection[0] + second[0];
    intersection[1] = y1;
    return intersection;
}

static void PrintResAndArray(double[] arrPrint)
{
    Console.WriteLine();
    Console.Write($"Координаты точки пересечения двух прямых: (");

    for (int i = 0; i < arrPrint.Length; i++)
    {
        Console.Write(arrPrint[i]);
        if (i + 1 != arrPrint.Length) Console.Write(", ");
        else Console.Write(")"); ;
    }
    Console.WriteLine();
}
