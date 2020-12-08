using AirCompany.Classes;
using AirCompany.List_Interface;
using System;
using System.Collections.Generic;

namespace AirCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Airplane> airPlanes = new List<Airplane>();
            airPlanes.Add(new CargoPlane("грузовой0", 100.0, 1000.0, 8, 11200.0, 1100.0));
            airPlanes.Add(new CargoPlane("грузовой1", 65.0, 900.0, 4, 9600.0, 910.0));
            airPlanes.Add(new PassengerPlane("пассажирский0", 70.0, 600.0, 66, 10500.0, 67));
            airPlanes.Add(new PassengerPlane("пассажирский1", 45.0, 450.0, 40, 5500.0, 34));

            //Airplane[] airPlanes = new Airplane [4];
            //airPlanes[0] = new CargoPlane ("грузовой0", 100.0, 1000.0, 8, 11200.0, 30.8);
            //airPlanes[1] = new CargoPlane("грузовой1", 65.0, 900.0, 4, 9600.0, 15.4);
            //airPlanes[2] = new PassengerPlane("пассажирский0", 70.0,600.0, 5, 10500.0, 67);
            //airPlanes[3] = new PassengerPlane("пассажирский1", 45.0, 450.0, 2, 5500.0, 34);

            Airline company = new Airline();

            foreach (Airplane i in airPlanes)
            {
                company.Add(i);
            }
            
            company.SortDistance();
            company.ShowPlane();

            Console.WriteLine();

            Console.WriteLine("Общая вместимость: {0} человек", company.PlaneCapacity());
            Console.WriteLine("Общая грузоподъемность: {0} тонн", company.PlaneTonnage());

            Console.WriteLine();

            Console.WriteLine("Список самолётов по расходу топлива:");
            foreach (var plane in company.FindPlaneByLevelFuel(20, 80))
            {
                Console.WriteLine("Название самолета: {0}, Топливо: {1}", plane.Name, plane.FuelVolume);
            }

            Console.ReadLine();
        }
    }
}
