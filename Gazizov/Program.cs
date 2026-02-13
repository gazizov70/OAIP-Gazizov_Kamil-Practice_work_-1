using Gazizov.AirplaneProject;
using System;

class Program
{
    static void Main()
    {
        PassengerAirplane Boeing = new PassengerAirplane("Boeing 737-800", 160, 700, "Авиакомпания", 60, true);
        Boeing.PerformPreFlightCheck();
        Boeing.ShowInfo();
        Boeing.ServeMeals();
        Boeing.AnnounceFlightInfo();
    }
}