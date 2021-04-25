using System;
using System.Collections.Generic;
using System.Linq;

namespace FitnessCenter {
  class Program {
    static void Main(string[] args) {

      // Посещаемость fitness-центра.
      List<Customer> CustomersList = new List<Customer> {
        new Customer {
          Code = 15, Year = 2020, Month = 3, Duration = 18
        }, new Customer {
          Code = 69, Year = 2020, Month = 11, Duration = 36
        }, new Customer {
          Code = 74, Year = 2019, Month = 11, Duration = 30
        }, new Customer {
          Code = 29, Year = 2019, Month = 12, Duration = 29
        }, new Customer {
          Code = 85, Year = 2019, Month = 7, Duration = 25
        }, new Customer {
          Code = 70, Year = 2020, Month = 7, Duration = 18
        }, new Customer {
          Code = 37, Year = 2020, Month = 4, Duration = 41
        }, new Customer {
          Code = 23, Year = 2019, Month = 3, Duration = 21
        }
      };

      int minDuration = CustomersList.Min(cmr => cmr.Duration);
      Customer result = CustomersList.Last(cmr => cmr.Duration == minDuration);

      Console.WriteLine($"Минимальная продолжительность: {result.Duration} за {result.Year} год и {result.Month} месяц");
    }
  }

  /// <summary>
  /// Класс клиента
  /// </summary>
  public class Customer {
    /// <summary>
    /// код клиента
    /// </summary>
    public int Code { get; set; }

    /// <summary>
    /// год
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// месяц
    /// </summary>
    public int Month { get; set; }

    /// <summary>
    /// продолжительность занятий (часов)
    /// </summary>
    public int Duration { get; set; }
  }
}
