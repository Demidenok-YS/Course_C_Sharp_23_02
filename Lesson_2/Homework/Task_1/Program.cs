// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.


int TakeNum(int num)
{
    // Console.WriteLine(num);
    return num / 10 % 10;
}

Console.WriteLine("Введите трехзначное число:");

int N = int.Parse(Console.ReadLine()!);

if (N > 99 & N <1000)
{
    int res = TakeNum(N);
    Console.Write("Вторая цифра числа : ");
    Console.WriteLine(res);
}
else 
{
    Console.WriteLine("Введенное число не является трехзначным");
}


/*
 Эталонное решение

string NumSec(int num)   -- функция возвращает строку
{
    if ((-1000 < num && num < -100) || (num < 1000 && num > 100))
        returm $"{num / 10 % 10}";
    return "Введенное число не является трехзначным";
}

Console.WriteLine(NumSec(int.Parse(Console.ReadLine()!)));

123 / 10   -> 12
123 / 100  -> 1
123 % 10  -> 3
123 % 100 -> 23

123 / 10 -> 12 % 10 -> 2

*/