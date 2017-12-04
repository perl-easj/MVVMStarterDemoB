using InMemoryStorage.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Car
{
    public class CarDTO : CopyableBase
    {
        public int Id { get; set; }

        public string LicensePlate { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int EngineSize { get; set; }

        public int HorsePower { get; set; }

        public int Seats { get; set; }

        public int Price { get; set; }

        public int ImageKey { get; set; }
    }
}