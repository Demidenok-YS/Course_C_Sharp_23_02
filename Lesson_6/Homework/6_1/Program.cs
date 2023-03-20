// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int Vvod (int num)
{
    int count = 0;

    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int a = int.Parse(Console.ReadLine()!);
        if (a > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите количество цифр:");
int a = int.Parse(Console.ReadLine()!);
int result = Vvod(a);

Console.Write("Количество чисел больше нуля : ");
Console.WriteLine(result);


// 2 вариант

// int CountNum()
// {
//     int count = 0;
//     string word;

//     while(true)       //бесконечный цикл
//     {
//         Console.Write("Введите значение: ");
//         word = Console.ReadLine()!;

//         if (word == "") return count;   // "" пустая строка, кот заканчивается enter
//         else if (int.Parse(word > 0) count += 1;
//     }
// }

// int count = CountNum();
// Console.WriteLine("Количество чисел больше нуля:");