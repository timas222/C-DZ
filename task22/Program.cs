// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.WriteLine("введите число:");
int num = Convert.ToInt32(Console.ReadLine());
void SquareTable(int num)
{
    int counter = 1;
    while (counter <= num)
    {
        Console.WriteLine($"{counter} {counter * counter}");
        counter++;

    }
}
if (num > 0) SquareTable(num);
else Console.WriteLine("введено некорректное значение");
