using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Car
{
    public class CarViewModelFactory : FactoryBase<Models.Domain.Car.Car, CarViewModel>
    {
        public override Models.Domain.Car.Car CreateDomainObject(CarViewModel vmObj)
        {
            return new Models.Domain.Car.Car(
                vmObj.Key,
                vmObj.ImageKey,
                vmObj.LicensePlate,
                vmObj.Brand,
                vmObj.Model,
                vmObj.Year,
                vmObj.EngineSizeCm3,
                vmObj.HorsePower,
                vmObj.Seats,
                vmObj.Price);
        }
    }
}