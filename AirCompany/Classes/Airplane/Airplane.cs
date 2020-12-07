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
        public double Tonnage { get; private set; }
        public double Distance { get; private set; }

        public Airplane(string name, double fuelVolume, int capacity, double tonnage, double distance) 
        {
            Name = name;
            FuelVolume = fuelVolume;
            Capacity = capacity;
            Tonnage = tonnage;
            Distance = distance;
        }
        public abstract void Rise();
        public abstract void Landing();
        public abstract void Load();
    }
}
