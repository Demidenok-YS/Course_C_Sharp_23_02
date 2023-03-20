// Задача 1: Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше
// суммы двух других сторон.

void Triangle (int A, int B, int C)
{
    if ( A < B + C && B < A + C && C < A + B)
        Console.WriteLine("Yes");
    else 
        Console.WriteLine("No");
}

Console.Write("Введите сторону А треугольника: ");
int a = int.Parse (Console.ReadLine()!);
Console.Write("Введите сторону B треугольника: ");
int b = int.Parse (Console.ReadLine()!);
Console.Write("Введите сторону C треугольника: ");
int c = int.Parse (Console.ReadLine()!);

Triangle(a, b, c);
