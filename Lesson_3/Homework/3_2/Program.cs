/* Напишите программу, которая принимает на вход координаты двух
 точек и находит расстояние между ними в 3D пространстве.
*/

double Dis3D(double x1, double y1, double z1,double x2, double y2, double z2)
{
    return Math.Round((Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))),2);
}

Console.WriteLine("Введите значения координат двух точек A и B. ");
Console.WriteLine("Значения координат точки А : ");
int x_1 = int.Parse(Console.ReadLine()!);
int y_1 = int.Parse(Console.ReadLine()!);
int z_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Значения координат точки В : ");
int x_2 = int.Parse(Console.ReadLine()!);
int y_2 = int.Parse(Console.ReadLine()!);
int z_2 = int.Parse(Console.ReadLine()!);
Console.Write("Расстояние между двумя точками в 3D протранстве: ");
Console.WriteLine(Dis3D(x_1, y_1, z_1, x_2, y_2, z_2));