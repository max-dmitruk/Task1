using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Classes
{
    public class CargoPlane : Airplane
    {
        public double WidthCargoHatch { get; private set; }
        public CargoPlane(string name, double fuelvolume, double tonnage, int capacity, double distance, double widthCargoHatch)
            : base(name, fuelvolume, tonnage, capacity, distance)
        {
            WidthCargoHatch = widthCargoHatch;
        }
    }
}
