// напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
string NumSecond(int num)
{
    if ((-1000 < num && num < -100) || (num <1000 && num > 100))
       return $"{num / 10 % 10}";
    return "Число не является трёхзначным";
}

Console.WriteLine(NumSecond(int.Parse(Console.ReadLine())));
