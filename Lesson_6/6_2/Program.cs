// Задача 2: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101 
// 3 -> 11
// 2 -> 10

string ConvertBin (int num)
{
    string result = "";       //пустая строка
    while (num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}

Console.Write("Введите число для преобразования из 10СС в 2СС: ");
int N = int.Parse(Console.ReadLine()!);
string Bin = ConvertBin(N);
Console.WriteLine(Bin);
