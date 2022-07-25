//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 3, n = 2->A(m, n) = 29
Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
int result = GetResFunctionAkkerman(firstNumber, secondNumber);
Console.WriteLine(result);

static int GetResFunctionAkkerman(int firstNum, int secondNum)
{
    if (firstNum == 0) return secondNum + 1;
    else if ((firstNum > 0) && (secondNum == 0)) return
            GetResFunctionAkkerman(firstNum - 1, 1);
    else if ((firstNum > 0) && (secondNum > 0)) return
            GetResFunctionAkkerman(firstNum - 1,
            GetResFunctionAkkerman(firstNum, secondNum - 1));
    else return secondNum + 1;
}