using System.Collections.Generic;
using AirCompany.Classes;

namespace AirCompany.List_Interface
{
    interface IAirline
    {
       IEnumerable<Airplane> FindPlaneByLevelFuel(double low, double high);
    }
}
