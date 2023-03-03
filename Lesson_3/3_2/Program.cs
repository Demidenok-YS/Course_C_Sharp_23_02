/* Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 2D пространстве.
*/

double Dis(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

int A_x1 = int.Parse (Console.ReadLine()!);
int A_y1 = int.Parse (Console.ReadLine()!);
int B_x1 = int.Parse (Console.ReadLine()!);
int B_y1 = int.Parse (Console.ReadLine()!);

Console.WriteLine(Dis(A_x1, A_y1, B_x1, B_y1));