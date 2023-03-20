// Задача 1: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5   7   -2 
// -0,2  1  -3,3 
//  8  -9,9   8 
// 7,8 -7,1   9 

void Print (double[,] arr)
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
double[,] MassNum(int row, int column, int from, int to)
{
    double[,] arr = new double[row, column];
     Random n_new = new Random();   

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);
    }
    return arr;
}

Console.WriteLine("Введите число строк m: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов n: ");
int col_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите нижнюю границу массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхнюю границу массива: ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();

double[,] mass = MassNum(row_num, col_num, start, stop);
Console.WriteLine("Массив:  ");
Print(mass);
