// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A(3,6); B(2,1) -> 5,09
// A(7,-5); B(1,-1) -> 7,21

int ReadNumber(string message)
{
    Console.WriteLine(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
double Distance( int ax, int ay, int bx, int by)
{
   double result;
   result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
   return result;
}
 
 int ax = ReadNumber("Введите ax: ");
 int ay = ReadNumber("Введите ay: ");
int bx = ReadNumber("Введите bx: ");
int by = ReadNumber("Введите by: ");

Console.WriteLine(Math.Round(Distance(ax, ay, bx, by), 2));