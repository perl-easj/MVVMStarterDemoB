using System;
using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Car
{
    public class CarViewModel : TransformedDataBase
    {
        public string LicensePlate { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int EngineSizeCm3 { get; set; }

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
            EngineSizeCm3 = 0;
            HorsePower = 0;
            Seats = 0;
            Price = 0;
            ImageKey = NullKey;
        }

        public override void SetValuesFromObject(Object obj)
        {
            Models.Domain.Car.Car carObj = (obj as Models.Domain.Car.Car);
            if (carObj == null)
            {
                throw new ArgumentException(nameof(SetValuesFromObject));
            }

            Key = carObj.Key;
            LicensePlate = carObj.LicensePlate;
            Brand = carObj.Brand;
            Model = carObj.Model;
            Year = carObj.Year;
            EngineSizeCm3 = carObj.EngineSizeCm3;
            HorsePower = carObj.HorsePower;
            Seats = carObj.Seats;
            Price = carObj.Price;
            ImageKey = carObj.ImageKey;
        }
    }
}