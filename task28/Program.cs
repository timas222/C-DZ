// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = DigitMultiplication(num);
Console.WriteLine($"произвидение числе от 1 до {num} = {result}");
int DigitMultiplication(int num)
{
    int mult = 1;
    for(int i = 1; i <= num; i++)
    {
        mult = mult * i;
    }
    return mult;
}
