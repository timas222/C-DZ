// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.WriteLine("введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

void SearchDigit(int num)
{
    int num1 = num / 10000;
    int num2 = num /1000 % 10;
    int num3 = num % 100 / 10;
    int num4 = num % 10;
    if (num1 == num4 && num2 == num3) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
SearchDigit(num);