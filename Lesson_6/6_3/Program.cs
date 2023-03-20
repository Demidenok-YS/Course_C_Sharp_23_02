// Задача 3: Не используя рекурсию, выведите первые N 
// чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3 
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fibonachi(int N )
{
    int a = 0;
    int b = 1;

    for (int i = 0; i < N; i++)
    {
        Console.Write(a + " ");
        (a, b) = (b, a + b);
    }
}
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
Fibonachi(n);
