//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.
int[] array = { 12, 2, 3, 45, 53, 63, 75, 87, 93, 10 };
int max = array[0];
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
        min = array[i];
    if (array[i] > max)
        max = array[i];
}
Console.WriteLine(max-min);