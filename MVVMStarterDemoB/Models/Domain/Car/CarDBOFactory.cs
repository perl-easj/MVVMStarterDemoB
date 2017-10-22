using System;
using DBOInterfaces;
using DBOImplementation;

namespace MVVMStarterDemoB.Models.Domain.Car
{
    public class CarDBOFactory : DBOFactoryBase<Car, CarDBO>
    {
        public override Car CreateT(IDBO obj)
        {
            CarDBO dtoObj = (obj as CarDBO);
            if (dtoObj == null)
            {
                throw new ArgumentException(nameof(CarDBOFactory));
            }

            return new Car(
                dtoObj.Id,
                dtoObj.ImageKey,
                dtoObj.LicensePlate,
                dtoObj.Brand,
                dtoObj.Model,
                dtoObj.Year,
                dtoObj.EngineSize,
                dtoObj.HorsePower,
                dtoObj.Seats,
                dtoObj.Price);
        }
    }
}