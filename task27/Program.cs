// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int SumDigits(int num)
{
    int res = default;
    while(num > 0)
    {
        int lastDigit = num % 10;
        num = num / 10;
        res = res +lastDigit;
    }
    return res;
}
int sumDigits = SumDigits(num);
Console.WriteLine(sumDigits);