using System;
using System.Collections.Generic;

namespace AirCompany.Classes
{
    public class PassengerPlane : Airplane
    {
        private int numberOfPassengers;
        public int NumberOfPassengers
        {
            get
            {
                return numberOfPassengers;
            }
            set
            {
                if (value > Capacity)
                {
                    Console.WriteLine("Перебор пассажиров!!!");
                    numberOfPassengers = 0;
                }
                else
                {
                    numberOfPassengers = value;
                }
            }
        }

        public PassengerPlane(string name, double fuelvolume, double tonnage, int capacity, double distance, int numberOfPassengers)
            : base(name, fuelvolume, tonnage, capacity, distance)
        {
            NumberOfPassengers = numberOfPassengers;
        }

        public override void FuelCompsution()
        {
            double Compsution;
            Compsution = (FuelVolume * numberOfPassengers) / Distance;
            Console.WriteLine("Расход топлива пассажирского самолета  {0} с людьми {1}", Compsution, numberOfPassengers);
        }

        public override void ShowPlane()
        {
         Console.WriteLine("Имя самолета: {0}, Количество топлива: {1}, Грузоподъемность: {2}, Вместимость: {3}, Дистанция полета: {4}," +
         " Количество пасадочных мест: {5}",Name, FuelVolume, Tonnage, Capacity, Distance,NumberOfPassengers);
        }
    }
}
