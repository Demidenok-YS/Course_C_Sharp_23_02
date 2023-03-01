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
