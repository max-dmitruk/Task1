namespace AirCompany.Classes
{
    public abstract class Airplane 
    {
        public string Name { get; private set; }
        public double FuelVolume { get; private set; }
        public int Capacity { get; private set; }
        public double Tonnage { get; private set; }
        public double Distance { get; private set; }

        public Airplane(string name, double fuelVolume, double tonnage, int capacity, double distance) 
        {
            Name = name;
            FuelVolume = fuelVolume;
            Capacity = capacity;
            Tonnage = tonnage;
            Distance = distance;
        }
        
        public abstract double GetFuelCompsution();

        public abstract void GetShowPlane();
    }
}
