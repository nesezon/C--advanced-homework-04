using System;

namespace DynamicCalculator {
  class Program {
    static void Main(string[] args) {
      var calc = new Calculator();
      showInfo(calc.Add(1, 3));     // 1 + 3 = 4 Int32
      showInfo(calc.Add(1, 3.1));   // 1 + 3.1 = 4,1 Double
      showInfo(calc.Sub(7, 3));     // 7 - 3 = 4 Int32
      showInfo(calc.Sub(3.1, 2));   // 3.1 - 2 = 1,1 Double
      showInfo(calc.Mlt(7, 3));     // 7 * 3 = 21 Int32
      showInfo(calc.Mlt(3.1, 2));   // 3.1 * 2 = 6,2 Double
      showInfo(calc.Div(8, 2));     // 8 / 2 = 4 Int32
      showInfo(calc.Div(8, 3));     // 8 / 3 = 2,66666666666667 Double
      showInfo(calc.Div(2.2, 2));   // 2.2 / 2 = 1,1 Double
      showInfo(calc.Div(2.2, 0));   // 2.2 / 0 = Infinity Double
    }

    private static void showInfo(dynamic result) {
      if (double.IsInfinity(result)) Console.WriteLine("деление на 0");
      else {
        Console.Write(result);
        Console.Write(" ");
        Console.WriteLine(result.GetType().Name);
      }
      Console.WriteLine(new string('-', 10));
    }
  }

  class Calculator {
    /// <summary>
    /// Сложить
    /// </summary>
    public dynamic Add(dynamic arg1, dynamic arg2) {
      return arg1 + arg2;
    }

    /// <summary>
    /// Вычесть
    /// </summary>
    public dynamic Sub(dynamic arg1, dynamic arg2) {
      return arg1 - arg2;
    }

    /// <summary>
    /// Умножить
    /// </summary>
    public dynamic Mlt(dynamic arg1, dynamic arg2) {
      return arg1 * arg2;
    }

    /// <summary>
    /// Разделить
    /// </summary>
    public dynamic Div(dynamic arg1, dynamic arg2) {
      dynamic result1 = arg1 / arg2;
      dynamic result2 = Convert.ToDouble(arg1) / Convert.ToDouble(arg2);
      if (result1 == result2) return result1;
      return result2;
    }
  }
}
