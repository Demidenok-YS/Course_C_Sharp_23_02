// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели,и проверяет, является ли этот
// день выходным.

void Day(int num)
{
    if (num == 1) 
    {
        Console.WriteLine("Понедельник. Не является выходным днем.");
    }
    else if (num == 2) 
    {
        Console.WriteLine("Вторник. Не является выходным днем.");
    }
    else if (num == 3) 
    {
        Console.WriteLine("Среда. Не является выходным днем.");
    }
    else if (num == 4) 
    {
        Console.WriteLine("Четверг. Не является выходным днем.");
    }
    else if (num == 5) 
    {
        Console.WriteLine("Пятница. Не является выходным днем.");
    }
    else if (num == 6) 
    {
        Console.WriteLine("Суббота. Является выходным днем.");
    }
    else if (num == 7) 
    {
        Console.WriteLine("Воскресенье. Является выходным днем.");
    }
}

Console.WriteLine("Введите число: ");
int a = int.Parse (Console.ReadLine()!);

if (a < 0)
{
    Console.WriteLine("Введенное число - отрицательное");
}
else if (a > 7)
{
    Console.WriteLine("Введенное число не соответствует дню недели");
}
else 
{
    Day(a);
}


/*

void Weekend(int num)
{
    string text = "no";

    if (num == 7 || num == 6) text = "weekend";
    else if (num < 6 && num > 0) text = "workday";
    else text = "not quite a week";
    Console.WriteLine($"{num} -> {text}");
}

Weekend(int.Parse(Console.ReadLine()!));

*/