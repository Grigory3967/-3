﻿//Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
int[] array = { 30, 20, 32, 4, 15, 66, 76, 87, 9, 88 };
int x = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        x++;
    }

}
Console.WriteLine(x);