// Напишите программу, которая принимает на вход число (N) и выдает
// таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4 .

void Chet(int N)
{
    int i = 0;
    double pere;
    while (i < N)
    {
        i++;
        if (i == (N))
        {
            pere = Math.Pow(i, 2);
            Console.Write($"{pere}");
        }
        else
        {
            pere = Math.Pow(i, 2);
            Console.Write($"{pere},");
        }
    }
}
Console.WriteLine("Введите число : ");
int chislo = int.Parse(Console.ReadLine());
Console.WriteLine();
Chet(chislo);





