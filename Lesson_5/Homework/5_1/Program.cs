/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая 
покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void Print (int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
int[] MassNum(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100, 1000);
    return arr;
}

int ChetNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count +=1;
    }
    return count;
}

Console.WriteLine("Введите размерность массива: ");
int num = int.Parse(Console.ReadLine()!);
int[] mass = MassNum(num);
Console.WriteLine();

Console.WriteLine("Массив:  ");
Print(mass);
Console.WriteLine();
Console.WriteLine("Количество четных элементов массива: ");
int z = ChetNum(mass);
Console.WriteLine(z);



