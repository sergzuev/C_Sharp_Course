﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задайте значения M и N. Напишите программу, которая 
// рекурсивно выведет все натуральные числа в промежутке от M до N.


void Spacing(int M, int N)
{
    if (N < M) return;
    Spacing(M, N);
    Console.Write($"{N}, ");
}

Spacing(1, 15);