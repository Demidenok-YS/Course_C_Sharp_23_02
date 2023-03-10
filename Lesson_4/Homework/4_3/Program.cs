/*Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void ArrayRandom(int size)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(-50,51);
        Console.WriteLine($"{mas[i] }");
    }
}
Console.Write("Введите размерность массива: ");
int z = int.Parse(Console.ReadLine()!);
ArrayRandom(z);

