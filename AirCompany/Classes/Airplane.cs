using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Classes
{
    public abstract class Airplane
    {
        public string Name { get; set; }
        public double EngineVolume { get; set; }
        public int Capacity { get; set; }
        public double Cost { get; set; }

        public Airplane(string name, double engineVolume, int capacity, double cost) 
        {
            Name = name;
            EngineVolume = engineVolume;
            Capacity = capacity;
            Cost = cost;
        }
        public abstract void Rise();
        public abstract void Landing();
        public abstract void Load();
    }
}
