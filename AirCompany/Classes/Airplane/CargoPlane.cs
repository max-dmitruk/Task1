using System;

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

        public override double FuelCompsution()
        {
            return (FuelVolume * WeightOfCargo) / Distance;
        }

        public override void ShowPlane()
        {
           Console.WriteLine("\n Имя самолета: {0}  \n Количество топлива: {1} л \n Грузоподъемность: {2} кг\n Вместимость груза: {3} кг \n Дистанция полета: {4} км" +
           " \n Вес перевозимого груза: {5} кг",Name, FuelVolume, Tonnage, Capacity, Distance, WeightOfCargo);
        }
    }
}
