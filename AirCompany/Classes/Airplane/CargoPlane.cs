using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Classes
{
    public class CargoPlane : Airplane
    {
        public double Tonnage { get; private set; }
        public CargoPlane(string name, double fuelvolume, int capacity, double tonnage, double distance)
            : base(name, fuelvolume, capacity, distance)
        {
            Tonnage = tonnage;
        }
    }
}
