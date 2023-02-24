// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число(N):");

int N = int.Parse(Console.ReadLine()!),
    count = 2;

Console.Write("Последовательность четных чисел от 1 до ");
Console.Write(N);
Console.WriteLine(":");

while (count <= N)
{
    Console.Write($"{count} ");
    count+=2;
}