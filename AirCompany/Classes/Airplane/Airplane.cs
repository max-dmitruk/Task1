using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Classes
{
    public abstract class Airplane
    {
        public string Name { get; private set; }
        public double FuelVolume { get; private set; }
        public int Capacity { get; private set; }
        public double Distance { get; private set; }

        public Airplane(string name, double fuelVolume, int capacity, double distance) 
        {
            Name = name;
            FuelVolume = fuelVolume;
            Capacity = capacity;
            Distance = distance;
        }

    }
}
