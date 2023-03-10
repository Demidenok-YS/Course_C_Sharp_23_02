/* Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
*/

void massiv(int mas)
{
    int[] numbers = new int[mas];
    for (int i = 0; i < mas; i++)
    {
        numbers [i] = new Random().Next(2);  // диапазон не включает последнюю цифру
        Console.WriteLine(numbers[i]);
    } 
}
Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
massiv(m);
