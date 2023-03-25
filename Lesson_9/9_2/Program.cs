// Задача 2: Задайте значения M и N. 
// Напишите программу, которая рекурсивно выведет все натуральные числа
// в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 6, 7, 8"

void NumsFromTo(int M, int N)        
{
    if (M > N) return;       
    NumsFromTo(M, N-1);
    Console.Write($"{N}, ");
}

Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
NumsFromTo(m,n);