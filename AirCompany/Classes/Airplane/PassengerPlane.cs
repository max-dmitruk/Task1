using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Classes
{
    public class PassengerPlane : Airplane
    {
        private int numberOfPassengers;
        public  int NumberOfPassengers 
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
                }
                else
                {
                    numberOfPassengers = value;
                }
                
            }
        }

        public PassengerPlane(string name, double fuelvolume,double tonnage, int capacity, double distance,int numberOfPassengers)
            : base(name, fuelvolume, tonnage, capacity, distance)
        {
            NumberOfPassengers = numberOfPassengers;
        }

        public override void FuelCompsution()
        {
            throw new NotImplementedException();
        }
    }
}
