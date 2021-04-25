using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LINQCars {
  class Program {
    static void Main() {

      // База данных автомабилей.
      List<Car> CarsList = new List<Car> {
        new Car {
          Make = "Saab", Model = "9-3 cabrio", Year = 2011, Color = Colors.DeepPink
        }, new Car {
          Make = "BMW", Model = "X6 F16", Year = 2014, Color = Colors.Black
        }, new Car {
          Make = "BMW", Model = "M8 Gran Coupe", Year = 2019, Color = Colors.DarkGreen
        }, new Car {
          Make = "Chrysler", Model = "Pacifica", Year = 2020, Color = Colors.Purple
        }
      };

      // база данных покупателей
      List<Customer> CustomersList = new List<Customer> {
        new Customer {
          CarModel = "M8 Gran Coupe", Name = "Ivan Ivanov", Phone = "416-15-89"
        }, new Customer {
          CarModel = "M8 Gran Coupe", Name = "Andrey Andreev", Phone = "296-19-74"
        }, new Customer {
          CarModel = "Pacifica", Name = "Petr Petrov", Phone = "154-84-47"
        }, new Customer {
          CarModel = "X6 F16", Name = "Alex Alexeev", Phone = "383-26-24"
        }, new Customer {
          CarModel = "9-3 cabrio", Name = "Egor Egorov", Phone = "634-83-71"
        }, new Customer {
          CarModel = "9-3 cabrio", Name = "Stepan Stepanov", Phone = "578-51-28"
        }
      };

      var query = from car in CarsList
                  select new {
                    car,
                    cmr = from cmr in CustomersList
                          where car.Model == cmr.CarModel
                          select new { cmr }
                  };

      foreach (var car in query) {
        Console.WriteLine(car.car);
        foreach (var cmr in car.cmr) {
          Console.WriteLine($"\t{cmr.cmr}");
        }
      }

    }
  }

  /// <summary>
  /// Класс автомобиль 
  /// </summary>
  public class Car {
    /// <summary>
    /// марка
    /// </summary>
    public string Make { get; set; }

    /// <summary>
    /// модель
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// год выпуска
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// цвет 
    /// </summary>
    public Color Color { get; set; }

    public override string ToString() {
      return $"Авто < марка: {Make}, модель:{Model}, год выпуска: {Year}, цвет: {Color} >";
    }
  }

  /// <summary>
  /// Класс покупатель 
  /// </summary>
  public class Customer {
    /// <summary>
    /// модель автомобиля
    /// </summary>
    public string CarModel { get; set; }

    /// <summary>
    /// имя
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// телефон
    /// </summary>
    public string Phone { get; set; }

    public override string ToString() {
      return $"Покупатель < модель автомобиля: {CarModel}, Имя:{Name}, телефон: {Phone} >";
    }
  }
}
