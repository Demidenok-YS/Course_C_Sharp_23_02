/*
 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int SumNumNech(int[] arr)
{
    int s = 0;
    for (int i = 0; i < arr.Length; i+=2) 
    {
        s += arr[i];
    }
    return s;
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

Console.WriteLine();
Console.WriteLine("Сумма элементов на нечетных позициях: ");
int sum = SumNumNech(mass);
Console.WriteLine(sum);