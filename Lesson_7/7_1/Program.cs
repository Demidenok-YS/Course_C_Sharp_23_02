// Задача 1: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₙₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4. 
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
int[,] MassNum(int row, int column)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            arr[i, j] = i + j;
    }
    return arr;
}

Console.WriteLine("Введите число строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов: ");
int col_num = int.Parse(Console.ReadLine()!);

Console.WriteLine();

int[,] mass = MassNum(row_num, col_num);
Console.WriteLine("Массив:  ");
Print(mass);
