/* Напишите программу, которая принимает на вход число (N)
и выдает таблицу квадратов чисел от 1 до N.
*/

void Pow(int N)
{
    int i = 1;
    while (i <= N)
    {
        Console.WriteLine(Math.Pow(i, 2));
        i++;
    }


}

int res = int.Parse(Console.ReadLine()!);
Pow(res);