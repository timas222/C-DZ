//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введи трёхзначное число: ");
int threeDigitnum = Convert.ToInt32(Console.ReadLine());
string stringnum = Convert.ToString(threeDigitnum);
Console.WriteLine("вторая цифра этого числа -> "+stringnum[1]);
int digit = stringnum.ToString().Length;
if (digit < 3 || digit > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}