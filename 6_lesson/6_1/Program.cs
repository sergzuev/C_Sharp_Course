// Напишите программу, которая принимает на вход 3 числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.

void TryG()
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    if (a < b + c & b < a + c & c < a + b)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
}

TryG();