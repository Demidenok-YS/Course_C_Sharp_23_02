// Задача 2: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120 
// M = 4; N = 8 -> 30

int Sum(int M, int N)        
{
    if (M > N) return 0;       
    Console.WriteLine($"Сумма = {N} + рекурсия от ({N -1})"); // вывод на экран для самопонимания)
    return  N + Sum(M, N-1);
    
}

Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(); 
Console.WriteLine($"Сумма = {Sum(m,n)}"); 