// Напишите программу, которая принимает на вход число
// и проверяет , кратно ли оно одновременно 7 и 23.

void Div (int N)
{
    if (N % 7 == 0 & N % 23 == 0)
        Console.WriteLine("кратно");
    else
        Console.WriteLine("не кратно ");
}

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);

Div(N);
