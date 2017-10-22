using ExtensionsModel.Implementation;

namespace MVVMStarterDemoB.Models.Domain.Car
{
    public class Car : ClassWithImage
    {
        public Car(int key, int imageKey, string licensePlate, string brand, string model, int year, int engineSizeCm3,
            int horsePower, int seats, int price)
            : base(key, imageKey)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Model = model;
            Year = year;
            EngineSizeCm3 = engineSizeCm3;
            HorsePower = horsePower;
            Seats = seats;
            Price = price;
        }

        public string LicensePlate { get; }

        public string Brand { get; }

        public string Model { get; }

        public int Year { get; }

        public int EngineSizeCm3 { get; set; }

        public int HorsePower { get; set; }

        public int Seats { get; set; }

        public int Price { get; set; }
    }
}