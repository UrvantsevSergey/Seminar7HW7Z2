using System;

class Program
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Введите число 1: ");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine ("Введите число 2: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine($"Результат функции Аккермана: {Akkerman(m, n)}");

    int Akkerman(int m, int n)
    {
      if (m == 0)
      {
        return n + 1;
      }
      else if (m > 0 && n == 0)
      {
        return Akkerman(m - 1, 1);
      }
      return Akkerman(m - 1, Akkerman(m, n - 1));
    }
  }
}