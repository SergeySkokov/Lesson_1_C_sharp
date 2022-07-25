﻿// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
int result = NaturalNumber(firstNumber, secondNumber);
Console.WriteLine(result);

static int NaturalNumber(int firstNum, int secondNum)
{
    return firstNum == secondNum ? secondNum : firstNum + NaturalNumber(firstNum + 1, secondNum);
}
