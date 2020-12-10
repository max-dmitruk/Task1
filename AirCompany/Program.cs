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
            IList<Airplane> plane = new List<Airplane>()
            {
            new CargoPlane("грузовой0", 100.0, 1000.0, 8, 11200.0, 500.0),
            new CargoPlane("грузовой1", 650.0, 900.0, 4, 9600.0, 500.0),
            new PassengerPlane("пассажирский0", 250, 600.0, 100, 10500.0, 67),
            new PassengerPlane("пассажирский1", 450.0, 450.0, 40, 5500.0, 34)
            };

            Airline company = new Airline(plane);

            //Airplane[] airPlanes = new Airplane [4];
            //airPlanes[0] = new CargoPlane ("грузовой0", 100.0, 1000.0, 8, 11200.0, 30.8);
            //airPlanes[1] = new CargoPlane("грузовой1", 65.0, 900.0, 4, 9600.0, 15.4);
            //airPlanes[2] = new PassengerPlane("пассажирский0", 70.0,600.0, 5, 10500.0, 67);
            //airPlanes[3] = new PassengerPlane("пассажирский1", 45.0, 450.0, 2, 5500.0, 34);

            //foreach (Airplane i in plane)
            //{
            //company.Add(i);
            //}
            company.ShowPlane();
            Console.WriteLine();


            Console.WriteLine("Список самолётов по дистанции:");
            foreach (var n in company.SortDistanceDec())
            {
                Console.WriteLine("Название самолета: {0}, расстояние: {1}", n.Name, n.Distance);
            }
            Console.WriteLine("Список самолётов по дистанции:");
            foreach (var n in company.SortDistanceInc())
            {
                Console.WriteLine("Название самолета: {0}, расстояние: {1}", n.Name, n.Distance);
            }
            Console.WriteLine();

            Console.WriteLine("Общая вместимость: {0} человек(а)", company.PlaneCapacity());
            Console.WriteLine("Общая грузоподъемность: {0} тонн", company.PlaneTonnage());

            Console.WriteLine();

            Console.WriteLine("Список самолётов по расходу топлива:");
            foreach (var n in company.FindPlaneByLevelFuel(20, 80))
            {
              Console.WriteLine("Название самолета: {0}, Топливо: {1}", n.Name, n.FuelCompsution());
            }
            
            Console.ReadLine();
        }
    }
}
