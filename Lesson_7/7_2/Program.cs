// Задача 2: Задайте двумерный массив. 
// Найдите элементы, у которых обе позиции чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 [81] 2 [9]
// 8 4 2 4

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
void PowNum(int[,] arr)   // так как мы преобразовываем готовый массив, можно void
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 1; i < row; i += 2)
    {
        for (int j = 1; j < column; j += 2)
            arr[i, j] = arr[i, j] * arr[i, j];
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
PowNum(mass);
Console.WriteLine("Массив 2:  ");
Print(mass);
