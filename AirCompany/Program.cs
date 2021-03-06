﻿using AirCompany.Classes;
using System;
using System.Collections.Generic;

namespace AirCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Airplane> Planes = new List<Airplane>()
            {
            new CargoPlane("АН-124", 32500.0, 17300.0, 8, 9000.0, 1000.0),
            new CargoPlane("АН-225", 25000.0, 15000.0, 8, 10000.0, 3000.0),
            new PassengerPlane("Airbus A-380", 4250.0, 6000.0, 450, 10500.0, 398),
            new PassengerPlane("Boeing 747", 4700.0, 4500.0, 756, 7500.0, 743)
            };

            Airline Company = new Airline(Planes);

            Company.GetShowPlane();

            Console.WriteLine("\n--------------------------------------------------------------");

            Console.WriteLine("Список самолётов по дистанции (убывание):");
            foreach (var n in Company.GetSortDistanceDec())
            {
                Console.WriteLine("Название самолета: {0}; Расстояние: {1} км", n.Name, n.Distance);
            }

            Console.WriteLine();

            Console.WriteLine("Список самолётов по дистанции (возрастание):");
            foreach (var n in Company.GetSortDistanceInc())
            {
                Console.WriteLine("Название самолета: {0}; Расстояние: {1} км", n.Name, n.Distance);
            }
            Console.WriteLine("\n--------------------------------------------------------------");

            Console.WriteLine("Общая пассажировместимость: {0} человек(а)", Company.GetPlaneCapacity());
            Console.WriteLine("Общая грузоподъемность: {0} кг", Company.GetPlaneTonnage());

            Console.WriteLine("\n--------------------------------------------------------------");

            Console.WriteLine("Список самолётов по расходу топлива:");
            foreach (var n in Company.FindPlaneByLevelFuel(0, 500000))
            {
              Console.WriteLine("Название самолета: {0}; Топливо: {1} л", n.Name, n.GetFuelCompsution());
            }

            Console.ReadLine();
        }
    }
}

