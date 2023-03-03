// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

void DelNum(int num)
{
    string z = num.ToString();  // int -> string
    z = z.Remove(1,1);          // удалили символ с индексом 1
    Console.WriteLine("Удалена вторая цифра числа: ");
    Console.WriteLine(z);
}

Console.WriteLine("Случайное число: ");

int M = new Random().Next(100,999);
Console.WriteLine(M);

DelNum(M);

/*

void NumRendon()    -- ставим 1ю и 3ю цифру рядом
{
    int num = new.Random().Next(100, 1000);
    Console.WriteLine($"{num} -> {num / 100}{num % 10}");
}

NumRendom();

Или

string SecondNum(int num)   -- 
{
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
        returm $"{num} -> {num / 100 * 10 + num % 10}";
    return "Введенное число не является трехзначным";
}

Console.WriteLine(SecondNum(int.Parse(Console.ReadLine()!)));

123 -> 13
123/100 ->1  находим первую цифру
123%10 ->3   находим последнюю
1 * 10 + 3 = 13
*/
