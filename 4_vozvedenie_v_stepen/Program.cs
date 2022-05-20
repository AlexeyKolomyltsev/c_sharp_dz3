// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine() ?? "0");
int a_res = a;
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i < b; i++) a_res *= a;
Console.Write($"Число {a} в степени {b} = {a_res}");