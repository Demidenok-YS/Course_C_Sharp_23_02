// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

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

void Print2 (int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
            Console.Write($" {arr[i]}, ");
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

string Check(int row, int col)
 {
    if (row != col ) 
    return "Задан прямоугольный массив. Задача будет решена корректно.";
    else 
    return "Задан не прямоугольный массив. Задача решится некорректно.\n Нажмите enter и попробуйте снова.";
 }

int[] SearchSum(int[,] arr)
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);

    int[] array = new int[row];
    int z = 0;
    for (int i = 0; i < row; i++)
    {
        int sum = 0;
        for (int j = 0; j < col; j++)
        {
            sum += arr[i,j];
        }
    array[z] = sum;
    z++;
    }
    return array;
    
}

int MinSum(int[] arr)
{
    int min_num = arr[0];
    int min_index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (min_num > arr[i])
        min_index = i;
    }
    return min_index;
}
Console.WriteLine("Введите число строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов: ");
int col_num = int.Parse(Console.ReadLine()!);
string text = Check(row_num, col_num);
Console.WriteLine(text);
Console.WriteLine();
Console.WriteLine("Введите нижнюю границу массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхнюю границу массива: ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] mass = MassNum(row_num, col_num, start, stop);
Console.WriteLine("Массив:  ");
Print(mass);

int[] mass1 = SearchSum(mass);
Console.WriteLine("Построчная сумма :  ");
Print2(mass1);

int str = MinSum(mass1);
Console.WriteLine($"В {str} строке наименьшая сумма элементов.");