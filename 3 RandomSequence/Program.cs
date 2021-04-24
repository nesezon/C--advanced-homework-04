using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSequence {
  static class Program {
    static void Main() {
      
      var Random30 = RndSequence().Take(30).ToArray();

      // выводим исходную последовательность
      foreach (var NextRandom in Random30) {
        Console.Write(NextRandom);
        Console.Write(" ");
      }
      Console.WriteLine();

      // Первый положительный элемент
      try {
        int firstPositive = Random30.First(n => n >= 0);
        Console.Write("Первый положительный: ");
        Console.WriteLine(firstPositive);
      }
      catch (Exception) {
        // ignored
      }

      // Последний отрицательный элемент
      try {
        int LastNegative = Random30.Last(n => n < 0);
        Console.Write("Последний отрицательный: ");
        Console.WriteLine(LastNegative);
      }
      catch (Exception) {
        // ignored
      }

      Console.ReadKey();
    }

    /// <summary>
    /// Последовательность случайных чисел от -99 до 99
    /// </summary>
    static IEnumerable<int> RndSequence() {
      Random rnd = new Random();
      while (true) {
        yield return rnd.Next(-99, 100);
      }
    }
  }
}
