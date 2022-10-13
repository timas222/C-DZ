// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int QuantityNumbers(int num)
{
    int i = 0;

    while (num > 0)
    {
        int result = num / 10; ;
        i++;
        num = result;
    }

    return i;
}
int res = QuantityNumbers(num);
Console.WriteLine(res);


