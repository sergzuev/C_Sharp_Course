// Напишите прогhамму, которая принимает на вход число (N)
// и выдает произведение чисел от 1 до N.
// 4 -> 24 ; 5 -> 120.

Console.WriteLine(" Введите число N : ");
int Proiz(int num)
{
    int all_proiz = 1;
    for (int i = 1; i <= num; i++)
    {
        all_proiz = all_proiz * i;
    }
    return all_proiz;
}

Console.WriteLine(Proiz(int.Parse(Console.ReadLine())));
