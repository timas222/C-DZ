// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введи число: ");
int randomnum = Convert.ToInt32(Console.ReadLine());
string randomnumText = Convert.ToString(randomnum);
if (randomnumText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + randomnumText[2]);
}
else
{
  Console.WriteLine("-> третьей цифры нет");
}