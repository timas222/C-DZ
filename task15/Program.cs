//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// по легкому пути)

// Console.Write("введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num == 1) Console.WriteLine("->нет");
// else if (num == 2) Console.WriteLine("->нет");
// else if (num == 3) Console.WriteLine("->нет");
// else if (num == 4) Console.WriteLine("->нет");
// else if (num == 5) Console.WriteLine("->нет");
// else if (num == 6) Console.WriteLine("->да");
// else if (num == 7) Console.WriteLine("->да");
// else Console.WriteLine("ведите верный номер");

Console.Write("Введи цифру от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

void checkday(int num)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine("(выходной) -> да");
    }
    else if (num < 1 || num > 7)
    {
        Console.WriteLine("введите верный номер");
    }
    else Console.WriteLine("(выходной) -> нет");
}
checkday(num);
