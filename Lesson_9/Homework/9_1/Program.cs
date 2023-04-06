// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void PrintEven(int M, int N)        
{
        if (M > N) return;
        PrintEven(M, N - 2);
        Console.Write($"{N}, "); 
}

Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

if (n / 2 != 0)
    n = n - 1;

Console.WriteLine("Вывод на экран: ");
PrintEven(m,n);