﻿using System;
using System.Collections.Generic;
using System.Linq;
using AirCompany.List_Interface;

namespace AirCompany.Classes
{
    public class Airline : IAirline
    {
        private ICollection<Airplane> Airplanes;

        public Airline()
        {
            Airplanes = new List<Airplane>();
        }

        public void Add(Airplane Plane)
        {
            Airplanes.Add(Plane);
        }

        public IEnumerable<Airplane> FindPlaneByLevelFuel(double low, double high)
        {
            return Airplanes.Where(x => (x.FuelVolume >= low) && (x.FuelVolume <= high)).ToList();
        }

        public int PlaneCapacity()
        {
            return Airplanes.Sum(x => x.Capacity);
        }
        public double PlaneTonnage()
        {
            return Airplanes.Sum(x => x.Tonnage);
        }

        public void SortDistance()
        {
            var sortedPlane = from i in Airplanes orderby i.Distance select i;
            foreach(Airplane i in sortedPlane)
                Console.WriteLine(i.Name);   

            /*var result = Airplanes.OrderBy(x => x.Distance).ToList();
            //result.Clear();
            foreach (var i in result)
            {
                Airplanes.Add(i);
            }*/
        }

        public void ShowPlane()
        {
            Console.WriteLine("Список самолётов: ");
            foreach (var n in Airplanes)
            {
                Console.WriteLine("Имя самолета: {0}, Количество топлива: {1}, Грузоподъемность: {2}, Вместимость: {3}, Дистанция полета: {4},",
                    n.Name, n.FuelVolume, n.Tonnage, n.Capacity, n.Distance);
            }
        }
    }
}
