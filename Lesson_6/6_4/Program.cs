// Задача 4: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[,] FillMass(int rows, int columns, int start, int stop)
{
    int[,] arr = new int[rows, columns];        // rows - строки, columns - столбцы
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = new Random().Next(start, stop);
        }
    }
    return arr;
}

void PrintMas(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)    // 0 количество строк
    {
         for (int j = 0; j < arr.GetLength(1); j++)   // 1 количество столбцов
         {
            Console.Write($" {arr[i,j]} ");  
         }
    Console.WriteLine();
    }
}

int[,] CopyMass(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int[,] new_arr = new int[rows, columns];

    for (int i = 0; i < rows; i++)    
    {
         for (int j = 0; j < columns; j++)   
         {
            new_arr[i,j]= arr[i,j];
         }
    }
    return new_arr;
}



Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите нижнюю границу массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхнюю границу массива: ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] mass = FillMass(row, col, start, stop);
Console.WriteLine("Массив:  ");
PrintMas(mass);
int[,] new_mass = CopyMass(mass);
Console.WriteLine();
Console.WriteLine("Массив 2:  ");
PrintMas(new_mass);