// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число A");
int n = int.Parse(Console.ReadLine() ?? "0");
int count = 0;
int nRes = n;
while (nRes != 0)
{
    count += nRes % 10;
    nRes = nRes / 10;
}
Console.Write($"Сумма сумму цифр в числе {n} : {count}");
