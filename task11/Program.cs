// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100,1000);
int RemoveSecondDigit(int num)
{
    int thirDigit = num % 10;
    int firstDigit = num / 100;
    return firstDigit * 10 + thirDigit;
}
int result = RemoveSecondDigit(num);
Console.WriteLine($"итоговое числоот от {num} => {result}");