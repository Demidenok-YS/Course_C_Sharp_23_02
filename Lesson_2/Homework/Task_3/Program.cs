// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

int Con (int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int res = num % 10;
    return res;
}

Console.WriteLine("Введите число: ");
int v = int.Parse(Console.ReadLine()!);

if (v > 99) 
{
    int result = Con(v);
    Console.WriteLine("Третья цифра заданного числа : ");
    Console.WriteLine(result);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}

/*

void ThirdNum(int num)
{
    Console.Write($"{num} ->");   -- отображение результата "12345 -> 3"
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return;    --завершает функцию текста
    }
    while (num > 999) num /= 10;  -- num = num / 10
    Console.WriteLine(num % 10); 
}

ThirdNum(int.Parse(Console.ReadLine()!));



*/