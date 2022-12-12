// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет; 23432 -> да; 12821 -> да .

Console.WriteLine("Введите пятизначное число : ");
string Palindrome(int N)
{
    int num = 10000;
    if(N > 100000 || N < 10000)
       return "Это число не пятизначное!";
    else
       while (num > 1)
       {
           if (N / num % 10 != N % 10)
              return "нет";
           N /= 10;
           num /= 100;  
       }   
       return "да";
}

Console.WriteLine(Palindrome(int.Parse(Console.ReadLine())));