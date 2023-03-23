// Задача 1. Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

void Print (int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
    Console.WriteLine();
    }
}
int[,] MassNum(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    }
    return arr;
}

void ReplaceIndex(int[,] arr)
{
    int row = arr.GetLength(0); //строки
    int col = arr.GetLength(1); // столбцы

    for (int j = 0; j < col; j++)
    {
        (arr[0,j], arr[row -1,j]) = (arr[row - 1,j], arr[0, j]);
    }

}

Console.WriteLine("Введите число строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов: ");
int col_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите нижнюю границу массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхнюю границу массива: ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] mass = MassNum(row_num, col_num, start, stop);
Console.WriteLine("Массив:  ");
Print(mass);
ReplaceIndex(mass);
Console.WriteLine("Массив 2:  ");
Print(mass);