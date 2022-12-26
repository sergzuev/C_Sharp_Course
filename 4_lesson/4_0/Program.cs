// Напишите прогhамму, которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А.
// 7 -> 28 ; 4 -> 10 ; 8 -> 36 .

Console.WriteLine(" Введите число А : ");
int SumNumes(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
    {
        all_sum += i;
    }
    return all_sum;
}

Console.WriteLine(SumNumes(int.Parse(Console.ReadLine())));