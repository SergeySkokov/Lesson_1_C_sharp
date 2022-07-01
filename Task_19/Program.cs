//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Программа, которая проверяет является ли число палиндромом.");
Console.WriteLine("Введите пятизначное число для проверки: ");
int value = int.Parse(Console.ReadLine());
while (value < 10000 && value > 99999)
{
    System.Console.WriteLine("Число " + value + " не пятизначное. Попробуйте ещё раз!");
}
int firstNum = value / 10000;
int secondNum = (value / 1000) % 10;
int thirdNum = (value / 100) % 10;
int fourthNum = (value / 10) % 10;
int fiveNum = value % 10;
int result = fiveNum * 10000 + fourthNum * 1000 + thirdNum * 100 + secondNum * 10 + firstNum;

if (value == result) Console.WriteLine("Число " + value + " является палиндромом");
else System.Console.WriteLine("Число " + value + " не является палиндромом");
