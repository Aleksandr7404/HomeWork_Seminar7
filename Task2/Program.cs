﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return akkerman(m - 1, 1);
    else
        return akkerman(m - 1, akkerman(m, n - 1));
}
Console.Clear();
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Функция Аккермана({m},{n}) = {akkerman(m, n)} ");