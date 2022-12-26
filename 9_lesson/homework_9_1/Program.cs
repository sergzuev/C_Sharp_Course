// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


 int Summa(int m, int n)
 {
     int res = m;
     if (m == n)
         return 0;
     else
     {
         m++;
         res = m + Summa(m, n);
         return res;
     }
 }

 Console.Write("Введите число M: ");
 int m = int.Parse(Console.ReadLine());
 Console.Write("Введите число N: ");
 int n = int.Parse(Console.ReadLine());
 Console.WriteLine($"Сумма чисел = {Summa(m-1, n)} ");


