// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа: ");

int a = int.Parse(Console.ReadLine()!),
    b = int.Parse(Console.ReadLine()!);

if (a > b)
{
    Console.Write("Большее число : ");
    Console.WriteLine(a);
    Console.Write("Меньшее число : ");
    Console.WriteLine(b);
}
else
{
    Console.Write("Большее число : ");
    Console.WriteLine(b);
    Console.Write("Меньшее число : ");
    Console.WriteLine(a); 
}

