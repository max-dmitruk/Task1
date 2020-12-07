using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Classes
{
    public class PassengerPlane : Airplane
    {
        public  int NumberOfSeats { get; private set; }
        public PassengerPlane(string name, double fuelvolume,double tonnage, int capacity, double distance,int numberOfseats)
            : base(name, fuelvolume, tonnage, capacity, distance)
        {
            NumberOfSeats = numberOfseats;
        }
    }
}
