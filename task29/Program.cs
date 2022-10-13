// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int [] arr = new int[8];
int[] resArr = GetArr(arr);
PrintArr(arr);
int[] GetArr(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,100);

    }
    return arr;
}
void PrintArr(int[]arr)
{
    int count = arr.Length;
    for (int i  = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}");

    }
    Console.WriteLine();
}