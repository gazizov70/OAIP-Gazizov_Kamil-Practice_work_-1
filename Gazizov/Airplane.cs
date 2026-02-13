using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazizov
{
    using System;

    namespace AirplaneProject
    {
        public class Airplane
        {
            public string Model { get; set; }
            public int Capacity { get; set; }
            public double MaxSpeed { get; set; }
            public string Airline { get; set; }

            public Airplane(string model, int capacity, double maxSpeed, string airline)
            {
                Model = model;
                Capacity = capacity;
                MaxSpeed = maxSpeed;
                Airline = airline;
            }

            public void TakeOff()
            {
                Console.WriteLine($"Самолет {Model} (а/к {Airline}) взлетает.");
            }

            public void Land()
            {
                Console.WriteLine($"Самолет {Model} (а/к {Airline}) совершает посадку.");
            }

            public void CheckEngine()
            {
                Console.WriteLine("Проверка двигателей базового самолета...");
            }

            public void UpdateMaintenanceLog()
            {
                Console.WriteLine("Обновление журнала техобслуживания базового самолета.");
            }

            public virtual void PerformPreFlightCheck()
            {
                Console.WriteLine($"Выполнение предполетной проверки для базового самолета {Model}.");
            }

            public virtual void ShowInfo()
            {
                Console.WriteLine($"\n--- Информация о базовом самолете ---");
                Console.WriteLine($"Модель: {Model}");
                Console.WriteLine($"Вместимость: {Capacity} пассажиров");
                Console.WriteLine($"Макс. скорость: {MaxSpeed} км/ч");
                Console.WriteLine($"Авиакомпания: {Airline}");
            }
        }

        public class PassengerAirplane : Airplane
        {
            public int BusinessClassSeats { get; set; }
            public bool HasEntertainmentSystem { get; set; }

            public PassengerAirplane(string model, int capacity, double maxSpeed, string airline,
                                    int businessClassSeats, bool hasEntertainmentSystem)
                : base(model, capacity, maxSpeed, airline)
            {
                BusinessClassSeats = businessClassSeats;
                HasEntertainmentSystem = hasEntertainmentSystem;
            }

            public override void PerformPreFlightCheck()
            {
                Console.WriteLine($"Выполнение предполетной проверки для пассажирского самолета {Model}.");
            }

            public override void ShowInfo()
            {
                Console.WriteLine($"\n--- Информация о пассажирском самолете ---");
                Console.WriteLine($"Модель: {Model}");
                Console.WriteLine($"Вместимость: {Capacity} пассажиров");
                Console.WriteLine($"Макс. скорость: {MaxSpeed} км/ч");
                Console.WriteLine($"Авиакомпания: {Airline}");
                Console.WriteLine($"Мест бизнес-класса: {BusinessClassSeats}");
                Console.WriteLine($"Развлекательная система: {(HasEntertainmentSystem ? "Есть" : "Нет")}");
            }

            public void ServeMeals()
            {
                Console.WriteLine("Подача питания пассажирам.");
            }

            public void AnnounceFlightInfo()
            {
                Console.WriteLine("Объявление информации о рейсе для пассажиров.");
            }
        }
    }
}
