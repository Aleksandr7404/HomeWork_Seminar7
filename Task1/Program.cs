// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void Interval(int m, int n)
{
    if (n == m - 1)
    {
        return;
    }
    Interval(m, n - 1);
    Console.Write($"{n} ");
}

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Interval(m, n);