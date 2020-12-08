using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirCompany.Classes;

namespace AirCompany.List_Interface
{
    interface IAirline
    {
        void Add(Airplane Plane);
        int PlaneCapacity();
        double PlaneTonnage();
        void SortDistance();
        IEnumerable<Airplane> FindPlaneByLevelFuel(double low, double high);
        void ShowPlane();
        void FuelOfCompsution();
        
    }
}
