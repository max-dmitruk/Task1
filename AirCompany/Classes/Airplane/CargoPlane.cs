using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Classes
{
    public class CargoPlane : Airplane
    {
        private double weightOfCargo;
        public double WeightOfCargo 
        {

            get
            {
                return weightOfCargo;
            }
            set
            {
                if (value > Tonnage)
                {
                    Console.WriteLine("Перебор груза!!!");
                }
                else
                {
                    weightOfCargo = value;
                }

            }
        }

        public CargoPlane(string name, double fuelvolume, double tonnage, int capacity, double distance, double weightOfCargo)
            : base(name, fuelvolume, tonnage, capacity, distance)
        {
            WeightOfCargo = weightOfCargo;
        }

        public override void FuelCompsution()
        {
            throw new NotImplementedException();
        }
    }
}
