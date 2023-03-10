/* Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
*/

void Cube(int num) 
{
    int i = 1;
    while (i <= num)
   {
        Console.WriteLine(Math.Pow(i, 3));
        i++;
   }

}

Console.WriteLine("Введите число для расчета таблицы кубов. ");
Console.WriteLine("N : ");
int N = int.Parse(Console.ReadLine()!);
Cube(N);

