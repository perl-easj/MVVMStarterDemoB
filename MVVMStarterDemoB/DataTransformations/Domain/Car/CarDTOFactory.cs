using System;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;

namespace MVVMStarterDemoB.DataTransformations.Domain.Car
{
    public class CarDTOFactory : TransformedDataFactoryBase<Models.Domain.Car.Car, CarDTO>
    {
        public override Models.Domain.Car.Car CreateDomainObject(ITransformedData obj)
        {
            CarDTO dtoObj = (obj as CarDTO);
            if (dtoObj == null)
            {
                throw new ArgumentException(nameof(CarDTOFactory));
            }

            return new Models.Domain.Car.Car(
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