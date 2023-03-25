// Задача 4: Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в целую степень B 
// с помощью рекурсии.
// A = 3; B = 5 -> 243 (3)^5 
// A = 2; B = 3 -> 8

int Degree(int a, int b)        
{
    if (b == 0) return 1;
    Console.WriteLine($"Метод от {b}  = {a} * рекурсия от ({b - 1})");
    return a * Degree(a, b - 1);
}

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень: ");
int B = int.Parse(Console.ReadLine()!);

int res = Degree(A, B);
Console.WriteLine();
Console.WriteLine($"Возведение в степень: {res} ");