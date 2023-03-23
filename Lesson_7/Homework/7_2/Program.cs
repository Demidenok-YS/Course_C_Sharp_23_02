// Задача 2: Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
//  или же указание, что такого элемента нет.
// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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
string SeachNum(int[,] arr, int r, int c)   
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (i == r && j == c )
            return $"[Введенная позиция элемента {r},{c} , результат: [{arr[i -1, j - 1]}]]";
        }
    }
    return $"[Введенная позиция элемента {r},{c} , результат: такого элемента нет.]";
    
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
Console.WriteLine();
Console.Write("Введите позицию элемента(строка): ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите позицию элемента(столбец): ");
int num_2 = int.Parse(Console.ReadLine()!);

string result = SeachNum(mass, num_1, num_2);
Console.WriteLine(result);