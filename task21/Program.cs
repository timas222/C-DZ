// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine("введите х1");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y1");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите z1");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите х2");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y2");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите z2");
double z2 = Convert.ToInt32(Console.ReadLine());

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double res = (Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)));
    return res;
}
double res = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(res);