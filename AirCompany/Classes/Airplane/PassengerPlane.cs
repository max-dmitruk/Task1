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

        public override void FuelCompsution()
        {
            double Compsution;
            Compsution = (FuelVolume * numberOfPassengers) / Distance;
            Console.WriteLine("Расход топлива пассажирского самолета  {0} с людьми {1}", Compsution, numberOfPassengers);
        }

    }
}
