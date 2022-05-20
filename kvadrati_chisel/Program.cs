// Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Квадраты чисел от 1 до {n} :");
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} -> {i*i}");
}