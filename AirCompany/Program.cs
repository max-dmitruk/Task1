using AirCompany.Classes;

namespace AirCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane[] airplanes = new Airplane [4];
            airplanes[0] = new CargoPlane ("грузовой0", 100.0, 8, 30.8, 11200.0);
            airplanes[1] = new CargoPlane("грузовой1", 65.0, 5, 15.4, 9600.0);
            airplanes[2] = new PassengerPlane("пассажирский0", 70.0, 4, 10500.0, 67);
            airplanes[3] = new PassengerPlane("пассажирский1", 45.0, 2, 5500.0, 34);

            Airline company = new Airline();
            foreach (Airplane i in airplanes)
            {
                company.Add(i);
            }

            foreach (var plane in company.FindPlaneByLevelFuel(20, 50))
            {
                System.Console.WriteLine("Название самолета: {0}, Топливо: {1}",plane.Name,plane.FuelVolume);
            }
            System.Console.WriteLine(company.PlaneCapacity());
            System.Console.WriteLine();

            company.SortDistance();
            company.ShowPlane();
            System.Console.ReadLine();
        }
    }
}
