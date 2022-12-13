// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];
    
    for (int i = 0; i < size; i++)
        arr[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    return arr;
}

void MinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        min = array[i];
        if(array[i] > max)
        max = array[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным эелементом: {Math.Round(max - min, 3)}");
}

double[] arr_1 = MassNums(int.Parse(Console.ReadLine()));
Print(arr_1);
MinMax(arr_1);