/*Напишите программу, которая принимает на вход число и
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumNum(int a)
{
    int z;
    int s = 0;
    for (int i = 0; a > 0; i++)
    {
        z = a % 10;
        a = a / 10;
        s += z;
    }
    Console.Write(s);
    return s;
}

Console.Write("Введите число: ");
int ch = int.Parse(Console.ReadLine()!);

Console.Write("Сумма цифр в введенном числе: ");
int sum_ch = SumNum(ch);