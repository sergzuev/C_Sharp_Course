//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Tochka(double b1, double k1, double b2, double k2)
{
   double k_diff = k1 - k2;
   if (k_diff != 0)
   { 
       double x = (b2 - b1) / k_diff;
       double y = (k1 * x + b1);
       Console.WriteLine($"Точка пересечения: ({x}; {y})");
   }
   else if (k1 == k2 && b1 == b2)
       Console.WriteLine("Точек пересечения бесконечное множество");
   else
       Console.WriteLine("Точек пересечения нет");
 
}

Tochka(int.Parse(Console.ReadLine()),
       int.Parse(Console.ReadLine()),
       int.Parse(Console.ReadLine()),
       int.Parse(Console.ReadLine()));