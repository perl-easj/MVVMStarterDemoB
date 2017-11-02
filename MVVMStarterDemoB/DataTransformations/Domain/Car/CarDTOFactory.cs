using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Car
{
    public class CarDTOFactory : FactoryBase<Models.Domain.Car.Car, CarDTO>
    {
        public override Models.Domain.Car.Car CreateDomainObject(CarDTO dtoObj)
        {
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