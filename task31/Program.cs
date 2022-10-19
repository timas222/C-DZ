﻿// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.


int[] CreateArrayRndInt(int size, int min, int max)
{
int[] array = new int[size];
var rnd = new Random();

for (int i = 0; i < size; i++)
{
array[i] = rnd.Next(min, max + 1);
}
return array;
}
void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if (i < array.Length - 1) Console.Write($"{array[i]}, ");
else Console.Write($"{array[i]}");
}
Console.WriteLine("]");
}
int[] GetSumPositiveNegativeElem(int[] array)
{
int sumPositve = default;
int sumNegative = default;

for (int i = 0; i < array.Length; i++)
{
if (array[i] < 0) sumNegative += array[i]; // sumNegative = sumNegative + array[i]
else sumPositve += array[i]; // sumPositve = sumPositve + array[i];
}

return new int[] { sumPositve, sumNegative };
}
int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] getSumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {getSumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {getSumPositiveNegativeElem[1]}");