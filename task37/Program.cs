﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



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

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] MultiplyFirstLastNum (int[] array)
{
    int lengthNewArr = default;
    if (array.Length % 2 == 0) lengthNewArr = array.Length / 2;
    else lengthNewArr = array.Length / 2 + 1;
    int[] newArr = new int[lengthNewArr];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = array[i] * array[array.Length - 1 - i];
    } 
    if (array.Length % 2 == 1) newArr[newArr.Length - 1] = array[array.Length / 2];
    return newArr;
}

int[] arr = CreateArrayRndInt(9, 1, 5);
PrintArray(arr);

int[] multiplyFirstLastNum = MultiplyFirstLastNum(arr);
PrintArray(multiplyFirstLastNum);