﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int i =1;
bool not = true;
Console.WriteLine(" введите числ: ");
int num= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("четые числа от 1 до "+num);
while(i <= num)
{
    if (i % 2 !=1)
{
    Console.Write(i + ", ");
    not = false;
}
i++;
}
if(not)
{
    Console.WriteLine(" четных чисел нет ");
}

