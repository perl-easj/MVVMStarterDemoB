using System;
using DTO.Implementation;
using DTO.Interfaces;

namespace MVVMStarterDemoB.Models.Domain.Car
{
    public class CarDTOFactory : DTOFactoryBase<Car, CarDTO>
    {
        public override Car CreateT(IDTO obj)
        {
            CarDTO dtoObj = (obj as CarDTO);
            if (dtoObj == null)
            {
                throw new ArgumentException(nameof(CarDTOFactory));
            }

            return new Car(
                dtoObj.Key,
                dtoObj.ImageKey,
                dtoObj.LicensePlate,
                dtoObj.Brand,
                dtoObj.Model,
                dtoObj.Year,
                dtoObj.EngineSizeCm3,
                dtoObj.HorsePower,
                dtoObj.Seats,
                dtoObj.Price);
        }
    }
}