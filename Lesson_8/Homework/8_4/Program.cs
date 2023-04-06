// Задача 4: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.


void Print (int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"   {arr[i, j]}   ");
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

int MinRow(int[,] arr)
{
    int index_min_i = 0;
    int min = arr[0,0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           if (arr[i,j] < min) 
           {
                min = arr[i,j];
                index_min_i = i; 
           }
        }
    }
    return index_min_i;
}

int MinCol(int[,] arr)
{
    int index_min_j = 0;
    int min = arr[0,0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] < min)
            {
                min = arr[i,j];
                index_min_j = j; 
            }
        }
    }
    return index_min_j;
}

int[,] DelRowCol(int[,] arr, int i_min, int j_min)
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    int[,] massive = new int[row - 1, col -1];
    for (int i = 0, a = 0; i < row; i++, a++)
    {
        if (i != i_min)
        {
            for (int j = 0, b = 0; j < col; j++, b++)
            {
                if (j != j_min)
                    massive[a,b] = arr[i,j];
                else b--;
            }
        }
        else a--;
    }
    return massive;
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

int ind_i = MinRow(mass);
Console.WriteLine($" i = {ind_i}");
int ind_j = MinCol(mass);
Console.WriteLine($" j = {ind_j}");

int[,] array = DelRowCol(mass, ind_i, ind_j);

Console.WriteLine("Результат выполнения метода:  ");
Print(array);