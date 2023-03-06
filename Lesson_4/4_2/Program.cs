/* Напишите программму, которая принимает на вход число N и 
выдает произведение чисел от 1 до N.
*/

int CompositionNum(int num)
{
    int all_comp = 1;
    for (int i = 1; i <= num; i++)  //i=i+2 или i+=2 (для увеличения на 2)
    {
        all_comp *= i;   // all_comp = all_comp * i;
    }
    return all_comp;
}

int A = int.Parse(Console.ReadLine()!);
int result = CompositionNum(A);
Console.WriteLine(result);
