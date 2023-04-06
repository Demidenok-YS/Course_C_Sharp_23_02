// Задача 3: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

int[,] ProductMatrix(int[,] first_arr, int[,] second_arr, int row_1, int col_1, int col_2)
{
    int[,] array = new int[row_1, col_2];

    for (int i = 0; i < row_1; i++)
    {
        for (int k = 0; k < col_2; k++)
        {
            int sum_prod = 0;
            for (int j = 0; j < col_1; j++)
            {
                sum_prod += first_arr[i, j] * second_arr[j, k];
                array[i, k] = sum_prod;
            }
        }
        
    }
    return array;
} 

Console.WriteLine("Данные для первой матрицы:  ");
Console.WriteLine("Введите число строк: ");
int row_num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов: ");
int col_num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите нижнюю границу массива: ");
int start1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхнюю границу массива: ");
int stop1 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] mass_1 = MassNum(row_num1, col_num1, start1, stop1);

Console.WriteLine("Данные для второй матрицы:  ");
Console.WriteLine("Введите число строк: ");
int row_num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов: ");
int col_num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите нижнюю границу массива: ");
int start2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхнюю границу массива: ");
int stop2 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] mass_2 = MassNum(row_num2, col_num2, start2, stop2);

Console.WriteLine("Матрица 1:  ");
Print(mass_1);
Console.WriteLine();
Console.WriteLine("Матрица 2:  ");
Print(mass_2);

if (col_num1 == row_num2)
{
    int[,] massive = ProductMatrix(mass_1, mass_2, row_num1, col_num1, col_num2);
    Console.WriteLine("Произведение двух матриц:  ");
    Print(massive);
}
else 
Console.WriteLine("Невозможно найти произведение матриц,\nт.к. кол-во столбцов первой матрицы не равно количеству строк второй матрицы.");
