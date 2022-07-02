//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");
System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result;

for (int i = 1; i <= number; i++)
{
    result = i *i *i;
    Console.Write(i);
    System.Console.Write(" ");
    Console.Write(result);
    System.Console.WriteLine(" ");    
}