// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N :");
void Cubes(int N)
{
    double[] nums = new double[N];
    int index = 0;

    Console.Write($"{N} -> ");

    while (index < N)
    {
        nums[index] = Math.Pow(index + 1, 3);
        Console.Write($"{nums[index]}, ");
        index++;
    }
    Console.WriteLine();
}
Cubes(int.Parse(Console.ReadLine()));