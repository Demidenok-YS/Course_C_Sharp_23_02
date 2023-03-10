/*Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int PowNum(int num, int z)
{
    int result = 1;
    for (int i = 1; i <= z; i++)
    {
        result *= num;
    }
    return result;
} 
 Console.Write("Введите число А: ");
 int A = int.Parse(Console.ReadLine()!);
 Console.Write("Введите степень В: ");
 int B = int.Parse(Console.ReadLine()!);

 Console.WriteLine("Результат возведения числа А в степень В: ");
 int res = PowNum(A, B);
 Console.Write(res);