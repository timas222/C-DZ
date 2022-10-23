﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.WriteLine("Задайте значение b1: ");
double B1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Задайте значение k1: ");
double K1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Задайте значение b2: ");
double B2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Задайте значение k2: ");
double K2 = Convert.ToDouble(Console.ReadLine());

void IntersPoint (double b1, double b2, double k1, double k2)
{
    if (k1 == k2) Console.WriteLine("Прямые параллельны");

    else {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения прямых ({x}, {y})");
    }

}

IntersPoint(B1, B2, K1, K2);
