// Показать кубы четных чисел от A до B
Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine() ?? "0");
int aForRes = a;
if (a % 2 != 0) a += 1;
Console.WriteLine($"Кубы четных чисел от {aForRes} до {b} :");
for (int i = a; i <= b; i += 2)
{
    Console.WriteLine($"{i} -> {i * i * i}");
}