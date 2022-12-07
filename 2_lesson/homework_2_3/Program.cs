//Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

void Weekend(int num)
{
    string text = "нет";

    if (num == 7 || num == 6) text = "да";
    Console.WriteLine($"{num} -> {text}");
}
 Weekend(int.Parse(Console.ReadLine()));