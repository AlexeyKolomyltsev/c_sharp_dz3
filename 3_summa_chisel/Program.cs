// Найти сумму чисел от 1 до А
Console.WriteLine("Введите число A");
int n = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
for (int i = 2; i <= n; i++) count += i;
Console.Write($"Сумма чисел от 1 до {n} : {count}");
