// Напишите программу, которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А.

int SumNum(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)  //i=i+2 или i+=2 (для увеличения на 2)
    {
        all_sum += i;   // all_sum = all_sum + i;
    }
    return all_sum;
}

int A = int.Parse(Console.ReadLine()!);
int result = SumNum(A);
Console.WriteLine(result);

