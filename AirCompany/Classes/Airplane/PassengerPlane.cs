using System;

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

        public override double GetFuelCompsution()
        {
            return (FuelVolume * NumberOfPassengers) / Distance;
        }

        public override void GetShowPlane()
        {
         Console.WriteLine("\n Имя самолета: {0} \n Количество топлива: {1} л \n Грузоподъемность: {2} кг \n Вместимость пассажиров: {3} мест \n Дистанция полета: {4} км " +
         " \n Количество пасадочных мест: {5}", Name, FuelVolume, Tonnage, Capacity, Distance,NumberOfPassengers);
        }
    }
}
