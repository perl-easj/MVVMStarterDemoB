using System;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;

namespace MVVMStarterDemoB.DataTransformations.Domain.Car
{
    public class CarViewModelFactory : TransformedDataFactoryBase<Models.Domain.Car.Car, CarViewModel>
    {
        public override Models.Domain.Car.Car CreateDomainObject(ITransformedData tObj)
        {
            CarViewModel vmObj = (tObj as CarViewModel);
            if (vmObj == null)
            {
                throw new ArgumentException(nameof(CarViewModelFactory));
            }

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