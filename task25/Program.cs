// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int newNum = GetDegree(num1, num2);
int GetDegree(int num1, int num2)
{
    int res = 1;
    for (int i = 1; i <= num2; i++)
    {
        res = num1 * res;
    
    }
    return res;

}
Console.WriteLine(newNum);