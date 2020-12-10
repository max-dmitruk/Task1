using System;
using System.Collections.Generic;
using System.Linq;
using AirCompany.List_Interface;

namespace AirCompany.Classes
{
    public class Airline : IAirline,ISortDistance,IShow,IPlaneCapacity,IPlaneTonnage
    {
        private ICollection<Airplane> airplanes;

        public Airline(ICollection<Airplane> Airplanes)
        {
            airplanes = Airplanes;
        }
        
        public void Add(Airplane item)
        {
            airplanes.Add(item);
        }

        public IEnumerable<Airplane> FindPlaneByLevelFuel(double low, double high)
        {
           var FindPlane = from item in airplanes
                       let i = item.FuelCompsution()
                       where (i >= low && i <= high)
                       select item;
           return FindPlane;
        }

        public int PlaneCapacity()
        {
            return airplanes.Sum(x => x.Capacity);
        }

        public double PlaneTonnage()
        {
            return airplanes.Sum(x => x.Tonnage);
        }

        public IEnumerable<Airplane> SortDistance()
        {
            return airplanes.OrderBy(x => x.Distance).ToList();
        }
        /*public void SortDistance()
        {
            var sortedPlane = airplanes.OrderBy(x => x.Distance).ToList();
            airplanes.Clear();
            foreach (var i in sortedPlane)
            {
                airplanes.Add(i);
            }
        }*/

        public void ShowPlane()
        {
            Console.WriteLine("Список самолётов: ");
            foreach (var i in airplanes)
            {
                i.ShowPlane();
            }
        }
    }
}
