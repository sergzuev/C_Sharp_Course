// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

c
int CountDiap(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        {
           count++;
        }
    }
    return count;
}

int[] arr_1 = ArrayNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine())) ;
Print(arr_1);
Console.Write(CountDiap(arr_1));
