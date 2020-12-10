using AirCompany.Classes;
using System.Collections.Generic;

namespace AirCompany.List_Interface
{
    public interface ISortDistance
    {
        IEnumerable<Airplane> SortDistance();
    }
}
