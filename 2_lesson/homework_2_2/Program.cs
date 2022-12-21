// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.


void NumThird(int num)
{
    Console.Write($"{num} -> ");
    if (num < 99)
    {
        Console.WriteLine("Третьей цифры нет");
        return;
    }
    while (num > 999) num /= 10;
    Console.WriteLine(num % 10);
}

NumThird(int.Parse(Console.ReadLine()));
