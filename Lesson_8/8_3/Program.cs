// Задача 3: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз 
// встречается элемент входных данных.
// Набор данных                        Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }         0 встречается 2 раза 
//                                    1 встречается 1 раз 
//                                    2 встречается 1 раз 
//                                    8 встречается 1 раз 
//                                    9 встречается 3 раза

// 1, 2, 3                            1 встречается 3 раза
// 4, 6, 1                            2 встречается 2 раз
// 2, 1, 6                            3 встречается 1 раз
//                                    4 встречается 1 раз 
//                                    6 встречается 2 раза

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
int[,] MassNum(int row, int column, int to)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(0, to); // arr[i, j] = new Random().Next(to + 1); с нуля до макс значения
    }
    return arr;
}

int[] Frequency(int[,] arr, int max)
{
    int[] dict = new int[max + 1];

    foreach (int element in arr)
    {
        dict[element] += 1;
    }
    return dict;
}

string PrintFrequency(int[] arr)
{
    string res = String.Empty;
    for (int i = 0; i < arr.Length; i++)
        res += $"Число {i} встречается {arr[i]} раз\n";
    return res;
}


Console.WriteLine("Введите число строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов: ");
int col_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхнюю границу массива: ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] mass = MassNum(row_num, col_num, stop);
Console.WriteLine("Массив:  ");
Print(mass);

int[] dictionary = Frequency(mass, stop);
string res = PrintFrequency(dictionary);
Console.WriteLine(res);