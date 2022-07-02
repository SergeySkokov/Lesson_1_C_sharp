//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("Введите координаты точки А:");
Console.WriteLine("x: ");
int xA = int.Parse(Console.ReadLine());
Console.WriteLine("y: ");
int yA = int.Parse(Console.ReadLine());
Console.WriteLine("z: ");
int zA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.WriteLine("x: ");
int xB = int.Parse(Console.ReadLine());
Console.WriteLine("y: ");
int yB = int.Parse(Console.ReadLine());
Console.WriteLine("z: ");
int zB = int.Parse(Console.ReadLine());

double catX = (xA - xB) * (xA - xB);
double catY = (yA - yB) * (yA - yB);
double catZ = (zA - zB) * (zA - zB);

double distance = Math.Sqrt(catX + catY + catZ);

Console.WriteLine("Рассояние между точками А и В: " + Math.Round(distance, 2));