using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksFromManualHomeWork9
{
    abstract class Car : IVehicle
    {
        private double _fuel;
        private double _consumption; // na 100 km
                    
        public double Consumption
        {
            get { return _consumption; }
            set { _consumption = value; }
        }


        public double Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public Car(double fuel, double consumption)
        {
            Fuel = fuel;
            Consumption = consumption;
        }

        public void PrintFuelLeft()
        {
            Console.WriteLine($"Осталось топлива: {Fuel}");
        }

        public void Drive(double distance)
        {
            if (Fuel > 0 && Fuel > (Consumption / 100) * distance)
            {
                double cons = (Consumption / 100) * distance;
                Fuel -= cons;
                Console.WriteLine($"За поездку на {distance} км. вы потратили {cons} литров топлива");
            }
            else
            {
                Console.WriteLine("Нет топлива.");
            }
            
        }

        public bool Refuel(double volume)
        {
            Fuel += volume;
            Console.WriteLine($"Было топлива: {Fuel-volume}\nСтало топлива: {Fuel}");
            return true;
        }
    }
}
