/* Напишите программу, которая принимает на вход координаты точки(х,у),
 причем х или у не равны нулю и выдает номер четверти плоскости,
в которой находится эта точка.

        y ^
          |
    2     |    1        
-------------------->
    3     |    4    x
          |
          |
*/

void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0 or y = 0");
    else if (x > 0 && y > 0)
        Console.WriteLine(" I ");
    else if (x < 0 && y > 0)
        Console.WriteLine(" II ");
    else if (x < 0 && y < 0)
        Console.WriteLine(" III ");
    else if (x > 0 && y < 0)
        Console.WriteLine(" IV ");
}

int num_1 = int.Parse (Console.ReadLine()!);
int num_2 = int.Parse (Console.ReadLine()!);
Quarters(num_1, num_2);








