// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int SumDigits(int N)        
{
    if (N == 0) return 0;       
    Console.WriteLine($"Число {N}, Сумма = {N % 10} + рекурсия от ({N / 10})");
    return N % 10 + SumDigits(N / 10);
    
}

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

int sum = SumDigits(n);
Console.WriteLine($"Сумма = {sum}");