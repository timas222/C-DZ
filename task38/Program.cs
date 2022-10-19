// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] CreateArrRndInt(int size, int min, int max)
{
    double[] arr = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round (rnd.NextDouble() * (max - min) + min, 1);
    }
    return arr;
}

void PrintArr (double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double GetMinM (double[] arr)
{
    double minRes = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minRes) minRes = arr[i];
    }
    return minRes;
}

double GetMaxM (double[] arr)
{
    double maxRes =  arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxRes) maxRes = arr[i];
    }

    return maxRes;
}

double GetDiffMaxMin (double[] arr)
{
    double maxM = GetMaxM(arr);
    double minM = GetMinM(arr);
    double res = Math.Round(maxM - minM, 1);
    return res;
}


double[] arr = CreateArrRndInt(5, -10, 10);
PrintArr(arr);

double diffMaxMinM = GetDiffMaxMin(arr);
Console.WriteLine(diffMaxMinM);