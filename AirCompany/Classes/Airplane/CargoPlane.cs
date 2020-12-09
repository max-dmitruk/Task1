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
                    weightOfCargo = 0;
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
            double Compsution;
            Compsution = (FuelVolume * weightOfCargo) / Distance;
            Console.WriteLine("Расход топлива грузового самолета  {0} с весом {1}", Compsution, weightOfCargo);
        }
        public override void ShowPlane()
        {
            Console.WriteLine("Имя самолета: {0}, Количество топлива: {1}, Грузоподъемность: {2}, Вместимость: {3}, Дистанция полета: {4}," +
            " Вес перевозимого груза: {5}", Name, FuelVolume, Tonnage, Capacity, Distance, WeightOfCargo);
        }
    }
}
