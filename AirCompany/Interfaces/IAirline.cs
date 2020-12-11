using System.Collections.Generic;
using AirCompany.Classes;

namespace AirCompany.List_Interface
{
    public interface IAirline
    {
       IEnumerable<Airplane> FindPlaneByLevelFuel(double low, double high);
    }
}
