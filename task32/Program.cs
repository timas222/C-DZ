﻿// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     var rnd = new Random(); // var или Random тип данных с левой стороны

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max +1);
    
//     }
//     return array;
// }

// void PrintArray(int[]array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i < array.Length - 1) Console.Write($"{array[1]},");
//         else Console.Write($"{array[i]}");
//     }
//     Console.Write("]");

// }

// int[] InversionNum(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * (-1);
//     }
// }
// int[] arr = CreateArrayRndInt(4, -8, 2);
// PrintArray(arr);
// int[] inversionNum = InversionNum(arr);
// PrintArray(inversionNum);


int[] CreateArrayRndInt(int size, int min, int max)
{
int[] array = new int[size];
var rnd = new Random(); // var или Random тип данных с левой стороны

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
if (i < array.Length - 1) Console.Write($"{array[1]}, ");
else Console.Write($"{array[i]}");
}
Console.WriteLine("]");
}

int[] InversionNum(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = array[i] * (-1);
}
return array;
}
int[] arr = CreateArrayRndInt(4, -8, 8);
PrintArray(arr);
int[] inversionNum = InversionNum(arr);
PrintArray(inversionNum);