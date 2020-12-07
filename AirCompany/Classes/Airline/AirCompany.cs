using System;
using System.Collections.Generic;
using System.Linq;
using AirCompany.List_Interface;

namespace AirCompany.Classes
{
    public class AirCompany : IAirCompany
    {
        private ICollection<Airplane> airplanes;

        public AirCompany()
            {
            airplanes = new List<Airplane>();
            }   
        public IEnumerable<Airplane> plane 
        {
            get
            {
                return plane;
            }
        }

        public void Buy(Airplane Plane)
        {
            airplanes.Add(Plane);   
        }

        public IEnumerable<Airplane> FindPlaneByLevelFuel(double low, double high)
        {
            return plane.Where(x => (x.FuelVolume >= low) && (x.FuelVolume <= high)).ToList();
        }

        public int PlaneCapacity()
        {
            throw new NotImplementedException();
        }

        public int PlaneTonnage()
        {
            throw new NotImplementedException();
        }

        public void SortDistance()
        {
            throw new NotImplementedException();
        }
    }
}
