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

