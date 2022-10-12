// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("введите четверть");
int quater = Convert.ToInt32(Console.ReadLine());

void Range(int quater1)
{
    if (quater1 == 1) Console.WriteLine ("x > 0, y > 0");
    else if (quater1 == 2) Console.WriteLine ("x > 1, y < 0");
    else if (quater1 == 3) Console.WriteLine ("x < 0, y < 0");
    else if (quater1 == 4) Console.WriteLine ("x > 0, y < 0");
    else  Console.WriteLine ("введены некоретные данные");
}

Range(quater);