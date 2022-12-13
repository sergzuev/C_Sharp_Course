// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.
// 3, 5 -> 243 (3⁵) ; 2, 4 -> 16 .

double StepNum(int A, int B)
{
    double n_step = 1;
    int B_abs = Math.Abs(B);

    for (int i = 1; i <= B_abs; i++)
    {
        if (B > 0)
           n_step *= A;
        else
           n_step /= A;
    }
    return n_step;
}

Console.WriteLine("Введите число A:");
int num_A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень B:");
int num_B = int.Parse(Console.ReadLine());

Console.WriteLine(StepNum(num_A, num_B));