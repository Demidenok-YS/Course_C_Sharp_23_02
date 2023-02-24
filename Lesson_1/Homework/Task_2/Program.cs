// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа: ");

int a = int.Parse(Console.ReadLine()!),
    b = int.Parse(Console.ReadLine()!),
    c = int.Parse(Console.ReadLine()!);

int max = a;

if ((max > b) & (max > c))
{
    Console.Write("Максимальное число : ");
    Console.WriteLine(max);
}
if ((max < b) & (b > c))
{
    max = b;
    Console.Write("Максимальное число : ");
    Console.WriteLine(max);
} 
if ((max < c) & (c > b)) 
{
    max = c;
    Console.Write("Максимальное число : ");
    Console.WriteLine(max);
}