// 2. Задайте двумерный массив. Напишите программу,
//    которая заменяет строки на столбцы. В случае, если это невозможно,
//    программа должна вывести сообщение для пользователя.

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

bool Check(int row, int column)
{
    bool res = row != column; // проверка row не равно column 
    return res;
}

string MatrixT(int[,] arr)
{
    if (Check(arr.GetLength(0), arr.GetLength(1))) return "Матрица не транспонируется!";

    for (int i = 1; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            (arr[i,j], arr[j, i]) = (arr[j, i], arr[i,j]);
        }
    }

    Console.WriteLine("Массив 2:  ");
    Print(arr);
    return "Матрица транспонируется!";

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
string matr = MatrixT(mass);

Console.WriteLine(matr);
Console.WriteLine();