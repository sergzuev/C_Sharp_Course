// Напишите программу, которая принимает на вход число N и
// выдает количество цифр в числе.
// 456 -> 3; 78 -> 2; 89126 -> 5 .

int NumbCount(int n)

{
    int count = 0;
    if (n == 0)
    {
        return 1;
    }
    while (n > 0)
    {
        n = n / 10;
        count++;
    }
    return count;
}

Console.WriteLine(NumbCount(int.Parse(Console.ReadLine())));

