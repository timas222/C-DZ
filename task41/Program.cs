// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



Console.WriteLine("Введите количество чисел: ");
int quantNum = Convert.ToInt32(Console.ReadLine());

int QuantPositNum (int number, int quant)
{
    int counter = default;
    for (int i = 0; i < quant; i++)
    {
        Console.WriteLine("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > number) counter++;
    }
    return counter;
}

int quantPositNum = QuantPositNum (0, quantNum);
Console.WriteLine($"Количество чисел больше 0 => {quantPositNum}");

