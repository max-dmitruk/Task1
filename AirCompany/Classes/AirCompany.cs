using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirCompany.List_Interface;

namespace AirCompany.Classes
{
    class AirCompany : IAirCompany
    {
        public IEnumerable<Airplane> Plane { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Buy(Airplane planes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Airplane> FindPlaneByLevelFuel(double low, double high)
        {
            throw new NotImplementedException();
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
