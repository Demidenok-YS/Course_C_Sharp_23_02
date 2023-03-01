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

