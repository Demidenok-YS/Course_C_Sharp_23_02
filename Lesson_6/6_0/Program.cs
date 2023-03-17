// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]

void Print (int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
int[] MassNum(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void RevMas(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size / 2; i++)
    {
        (arr[i], arr[size - i -1]) = (arr[size - i -1], arr[i]);
    }
}

Console.WriteLine("Введите размерность массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите нижнюю границу массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхнюю границу массива: ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[] mass = MassNum(num, start, stop);
Console.WriteLine("Массив:  ");
Print(mass);
RevMas(mass);
Print(mass);