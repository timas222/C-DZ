﻿// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

bool IsAliqut(int arg1,int arg2)
{
    return arg1 % arg2 == 0;
}
if (IsAliqut(num1,num2)) Console.WriteLine($"{num1} кратно {num2}!");
else Console.Write($"{num1} не кратно {num2}! остаток:{num1 % num2}");