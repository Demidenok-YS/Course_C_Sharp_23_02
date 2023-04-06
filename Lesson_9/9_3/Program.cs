// Задача 3: Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12 
// 45 -> 9
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
