using System;
using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Car
{
    public class CarDTO : TransformedDataBase
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

        public override void SetDefaultValues()
        {
        }

        public override void SetValuesFromObject(object obj)
        {
            Models.Domain.Car.Car carObj = (obj as Models.Domain.Car.Car);
            if (carObj == null)
            {
                throw new ArgumentException(nameof(SetValuesFromObject));
            }

            Id = carObj.Key;
            Brand = carObj.Brand;
            Model = carObj.Model;
            LicensePlate = carObj.LicensePlate;
            Year = carObj.Year;
            Seats = carObj.Seats;
            Price = carObj.Price;
            EngineSize = carObj.EngineSizeCm3;
            HorsePower = carObj.HorsePower;
            ImageKey = carObj.ImageKey;
        }
    }
}