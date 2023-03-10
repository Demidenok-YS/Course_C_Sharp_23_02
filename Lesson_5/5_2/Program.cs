/* Задайте массив. Напишите программу, которая определяет, присутствует
 ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет 
3; массив [6, 7, 19, 345, 3] -> да
*/

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

void SearchNum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            Console.WriteLine("yes");
            return;
        }
        
    }
    Console.WriteLine("no");
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

Console.WriteLine("Введите искомое число: ");
int ch = int.Parse(Console.ReadLine()!);

SearchNum(mass, ch);