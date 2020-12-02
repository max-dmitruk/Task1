using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirCompany.Classes;

namespace AirCompany.List_Interface
{
    interface IAirCompany
    {
        IEnumerable <Airplane> Plane { get; set; }
        int PlaneCapacity();//вместимость
        int PlaneTonnage();//грузоподъемность
        void SortDistance();//поиск по дальней дистанции
        IEnumerable<Airplane> FindPlaneByLevelFuel(double low, double high);// поиск по уровню топливу
    }
}
