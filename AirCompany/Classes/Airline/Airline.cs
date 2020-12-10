using System;
using System.Collections.Generic;
using System.Linq;
using AirCompany.List_Interface;

namespace AirCompany.Classes
{
    public class Airline : IAirline,ISortDistance,IShow,IPlaneCapacity,IPlaneTonnage
    {
        private ICollection<Airplane> aircompany;

        public Airline(ICollection<Airplane> AirCompany)
        {
            aircompany = AirCompany;
        }
        
        public void Add(Airplane item)
        {
            aircompany.Add(item);
        }

        public IEnumerable<Airplane> FindPlaneByLevelFuel(double low, double high)
        {
           var FindPlane = from item in aircompany
                           let i = item.FuelCompsution()
                           where (i >= low && i <= high)
                           select item;
           return FindPlane;
        }

        public int PlaneCapacity()
        {
            return aircompany.Sum(x => x.Capacity);
        }

        public double PlaneTonnage()
        {
            return aircompany.Sum(x => x.Tonnage);
        }

        public IEnumerable<Airplane> SortDistanceDec()
        {
            return aircompany.OrderByDescending(x => x.Distance);
        }

        public IEnumerable<Airplane> SortDistanceInc()
        {
            return aircompany.OrderBy(x => x.Distance);
        }
        
        public void ShowPlane()
        {
            Console.WriteLine("Список самолётов: ");
            foreach (var i in aircompany)
            {
                i.ShowPlane();
            }
        }
    }
}
