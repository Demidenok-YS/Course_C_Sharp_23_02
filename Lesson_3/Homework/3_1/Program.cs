/* Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.
*/

void Pal(int num)
{ 
    if ((num / 10000 == num % 10) && (num / 1000 % 10 == num % 100 / 10))
    Console.WriteLine("Число является палиндромом.");
    else
    Console.WriteLine("Введенное число не является палиндромом.");
}

Console.WriteLine("Введите пятизначное число: ");
int z = int.Parse(Console.ReadLine()!);
if (z > 9999 && z < 100000) 
Pal(z);
else 
Console.WriteLine("Введенное число не является пятизначным.");


