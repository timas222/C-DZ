// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
bool IsAliqut7and23(int arg)
{
    return arg % 7 == 0 && arg % 23 ==0;
}
if(IsAliqut7and23(num))Console.WriteLine("Да");
else Console.WriteLine("Нет");


// Console.WriteLine("введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num %7 == 0 && num %23 ==0) Console.WriteLine($"{num}, кратно числам 7 и 23");
// else Console.WriteLine($"{num}, не кратно числам 7 и 23");