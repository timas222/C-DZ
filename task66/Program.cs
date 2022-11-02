// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30




Console.WriteLine("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = SumOfNaturalNumbersFromMToN(numberM, numberN);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} -> {result}");

int SumOfNaturalNumbersFromMToN(int numM, int numN)
{
    if (numM < numN) return numN + SumOfNaturalNumbersFromMToN(numM, numN - 1);
    if (numM > numN) return numN + SumOfNaturalNumbersFromMToN(numM, numN + 1);
    return numM;
}
