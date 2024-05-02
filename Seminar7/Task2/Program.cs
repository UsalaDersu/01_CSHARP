﻿﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int FuncAkkerman(int m, int n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    else if (n == 0 && m > 0)
    {
        return FuncAkkerman(m - 1, 1);
    }
    else 
    {
        return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
    }
    
}

Console.Clear();
Console.Write($"Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write($"Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine()!);

if (m>=0 && n>=0)
{
    System.Console.WriteLine($"A( {m}, {n}) = {FuncAkkerman(m, n)}");
}
else
{
    System.Console.WriteLine($"Функция не имеет смысла");
}
// ответ
// Введите неотрицательное число m: 3
// Введите неотрицательное число n: 2
// A( 3, 2) = 29