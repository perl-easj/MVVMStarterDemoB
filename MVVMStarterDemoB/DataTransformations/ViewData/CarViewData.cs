using MVVMStarterDemoB.DataTransformations.Base;

namespace MVVMStarterDemoB.DataTransformations.ViewData
{
    public class CarViewData : ViewDataAppBase
    {
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int EngineSize { get; set; }
        public int HorsePower { get; set; }
        public int Seats { get; set; }
        public int Price { get; set; }
        public int ImageKey { get; set; }

        public override void SetDefaultValues()
        {
            Key = NullKey;
            LicensePlate = "(not set)";
            Brand = "(not set)";
            Model = "(not set)";
            Year = 2000;
            EngineSize = 0;
            HorsePower = 0;
            Seats = 0;
            Price = 0;
            ImageKey = NullKey;
        }
    }
}