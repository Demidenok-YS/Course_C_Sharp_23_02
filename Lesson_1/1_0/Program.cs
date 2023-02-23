string s = Console.ReadLine()!; // ! гарантия , что не будет пустой строки
int num = int.Parse(s);   // преобразовали тип string (строку) в целочисленный int
// int num = int.Parse(Console.ReadLine()!); альтернатива

Console.WriteLine(num * num);
