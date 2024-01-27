// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

int[] CreateArray(int size)
{
    int[] arrayRnd = new int[size];
    for (int i = 0; i < size; i++)
        arrayRnd[i] = new Random().Next(0, 99);
    return arrayRnd;
}
void ShowArray(int[] arr, int i = 0)
{
    if (i < arr.Length)
    {
        Console.Write($"{arr[i]} ");
        ShowArrayBackwards(arr, i + 1);
    }
}
void ShowArrayBackwards(int[] arr, int i = 0)
{
    if (i < arr.Length)
    {
        ShowArrayBackwards(arr, i + 1);
        Console.Write($"{arr[i]} ");
    }
}
Console.Clear();
int[] array = CreateArray(5);
ShowArray(array);
Console.WriteLine();
ShowArrayBackwards(array);