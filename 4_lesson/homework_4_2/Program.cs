﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
       Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Massiv(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
       arr[i] = new Random().Next(1,100);
    return arr;
}

Console.WriteLine("Введите количество элементов массива:");
int[] arr = Massiv(int.Parse(Console.ReadLine()));
Print(arr);

