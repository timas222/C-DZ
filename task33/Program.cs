﻿// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

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

bool CheckMatchNum (int[] array, int num)
{
    bool checkMatchNum = false;
    for (int i = 0; i < array.Length; i++)
   {
        if(array[i] == num) 
        {
            checkMatchNum = true;
            break;
        }

   }
    return checkMatchNum;
}

int[] arr = CreateArrayRndInt(10, 0, 10);
PrintArray(arr);
if (CheckMatchNum(arr, number)) Console.WriteLine("Да");
else Console.WriteLine("Нет");
