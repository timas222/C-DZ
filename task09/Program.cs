// Напишите программу, которая выводит
// выводит случайное число из отрезка [10, 99] и показывает
// показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8
// 99 -> цифры равны

// int num = new Random().Next(10, 100);

// int maxDigit = firstDigit;
// if (secondDigit > firstDigit) maxDigit = secondDigit;

// int maxDigit1 = firstDigit > secondDigit ? firstDigit : secondDigit;

// Console.WriteLine();


int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    if (IsEqualDigits(firstDigit,secondDigit)) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int num = new Random().Next(10, 100);
int maxDigit = MaxDigit (num);

String result = maxDigit > 0? maxDigit.ToString() : "цифры равны";
Console.WriteLine($"наибольшая цифра числа {num} = {maxDigit}");

bool IsEqualDigits(int num1, int num2)
{
    return num1 == num2;
}