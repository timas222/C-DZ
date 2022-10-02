// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

bool IsSquare(int num1, int num2)
{
    return num2 == num1 * num1 || num1 == num2 * num2;
}

if (IsSquare(num1, num2)) Console.WriteLine($"{num1},{num2} => Да!");
else Console.WriteLine($"{num1},{num2} => Нет!");
