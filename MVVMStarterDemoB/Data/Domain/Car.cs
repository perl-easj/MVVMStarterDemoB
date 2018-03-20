using MVVMStarterDemoB.Data.Base;

namespace MVVMStarterDemoB.Data.Domain
{
    public class Car : DomainAppBase
    {
        public Car(int key, int imageKey, string licensePlate, string brand, string model, int year, int engineSize, int horsePower, int seats, int price)
            : base(key, imageKey)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Model = model;
            Year = year;
            EngineSize = engineSize;
            HorsePower = horsePower;
            Seats = seats;
            Price = price;
        }

        public Car() : base(NullKey, NullKey)
        {
        }

        public string LicensePlate { get; }
        public string Brand { get; }
        public string Model { get; }
        public int Year { get; }
        public int EngineSize { get; set; }
        public int HorsePower { get; set; }
        public int Seats { get; set; }
        public int Price { get; set; }
    }
}