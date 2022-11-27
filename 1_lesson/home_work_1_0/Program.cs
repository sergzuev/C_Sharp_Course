// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

 Console.WriteLine("Введите первое число: ");
 string num1 = Console.ReadLine();
 int a = int.Parse(num1);

 Console.WriteLine("Введите второе число: ");
 string num2 = Console.ReadLine();
 int b = int.Parse(num2);

 if(a > b)
 {
     Console.WriteLine($"Max = {a}");
     Console.Write($"Min = {b}");
 }
 else if(a < b)
 {
     Console.WriteLine($"Max = {b}");
     Console.Write($"Min = {a}");
 }
 else
 {
    Console.Write("Числа равны. Невозможно определить Max и Min"); 
 }