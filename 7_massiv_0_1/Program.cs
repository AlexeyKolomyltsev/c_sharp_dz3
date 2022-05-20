// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void PrintArr(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++) Console.Write($"{array[i]} ");
}

int[] array0_1 = new int[8];
int len = array0_1.Length;
for (int i = 0; i < len; i++) array0_1[i] = new Random().Next(0, 2);
PrintArr(array0_1);