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
                           let i = item.GetFuelCompsution()
                           where (i >= low && i <= high)
                           select item;
           return FindPlane;
        }

        public int GetPlaneCapacity()
        {
            return aircompany.Sum(x => x.Capacity);
        }

        public double GetPlaneTonnage()
        {
            return aircompany.Sum(x => x.Tonnage);
        }

        public IEnumerable<Airplane> GetSortDistanceDec()
        {
            return aircompany.OrderByDescending(x => x.Distance);
        }

        public IEnumerable<Airplane> GetSortDistanceInc()
        {
            return aircompany.OrderBy(x => x.Distance);
        }
        
        public void GetShowPlane()
        {
            Console.WriteLine("Список самолётов: ");
            foreach (var i in aircompany)
            {
                i.GetShowPlane();
            }
        }
    }
}
