/* Напишите программу, которая принимает на вход число и 
выдает количество цифр в числе.
*/

int LenghtNum(int num)
{
    int a = 0;
    for (int i = 1; num > 0; i++)
    {
        num /= 10;
        a++;
    }
    return a;
}
Console.WriteLine("Введите число: ");
int num = int.Parse (Console.ReadLine()!);
int result = LenghtNum(num);
Console.WriteLine(result);