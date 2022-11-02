// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29




Console.WriteLine("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = AkkermanFunction(numberM, numberN);
if(numberM >= 0 && numberN >= 0) Console.WriteLine(result);
else Console.WriteLine("Введите корректное число");

int AkkermanFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if ((numN == 0) && (numM > 0)) return AkkermanFunction(numM - 1, 1);
    return AkkermanFunction(numM - 1, AkkermanFunction(numM, numN - 1));
}
