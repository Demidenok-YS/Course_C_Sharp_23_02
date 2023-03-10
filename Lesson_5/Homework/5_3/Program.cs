/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void Print (int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
int[] MassNum(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int[] MultiNum(int[] arr)
{
    int size = arr.Length;
    int[] newMass = new int[size/2 + size%2];
    for (int i = 0; i < size/2; i++) 
    {
        newMass[i] = arr[i] * arr[size - 1 - i];
    }
    if (size%2 == 1)
    {
        newMass[newMass.Length - 1] = arr[arr.Length/2];
    }
    return newMass;
}

Console.WriteLine("Введите размерность массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите нижнюю границу массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхнюю границу массива: ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[] mass = MassNum(num, start, stop);
Console.WriteLine("Массив:  ");
Print(mass);

int[] SecMass = MultiNum(mass);
Print(SecMass);
