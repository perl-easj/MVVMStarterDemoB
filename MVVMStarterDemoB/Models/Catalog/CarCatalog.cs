using MVVMStarterDemoB.DataTransformations.PersistentData;
using MVVMStarterDemoB.DataTransformations.ViewData;
using MVVMStarterDemoB.Models.Base;

namespace MVVMStarterDemoB.Models.Catalog
{
    public class CarCatalog : CatalogAppBase<Data.Domain.Car, CarViewData, CarPersistentData>
    {
        public CarCatalog() : base("Cars")
        {
        }

        public override Data.Domain.Car CreateDomainObjectFromViewDataObject(CarViewData vdObj)
        {
            return new Data.Domain.Car
            (
                vdObj.Key, 
                vdObj.ImageKey,
                vdObj.LicensePlate, 
                vdObj.Brand, 
                vdObj.Model, 
                vdObj.Year, 
                vdObj.EngineSize,
                vdObj.HorsePower,
                vdObj.Seats, 
                vdObj.Price
            );
        }

        public override CarViewData CreateViewDataObject(Data.Domain.Car obj)
        {
            return new CarViewData
            {
                Key = obj.Key,
                ImageKey = obj.ImageKey,
                LicensePlate = obj.LicensePlate.TrimEnd(' '),
                Brand = obj.Brand.TrimEnd(' '),
                Model = obj.Model.TrimEnd(' '),
                Year = obj.Year,
                EngineSize = obj.EngineSize,
                HorsePower = obj.HorsePower,
                Seats = obj.Seats,
                Price = obj.Price
            };
        }

        public override CarPersistentData CreatePersistentDataObject(Data.Domain.Car obj)
        {
            return new CarPersistentData
            {
                Id = obj.Key,
                Key = obj.Key,
                ImageKey = obj.ImageKey,
                LicensePlate = obj.LicensePlate,
                Brand = obj.Brand,
                Model = obj.Model,
                Year = obj.Year,
                EngineSize = obj.EngineSize,
                HorsePower = obj.HorsePower,
                Seats = obj.Seats,
                Price = obj.Price            
            };
        }

        public override Data.Domain.Car CreateDomainObjectFromPersistentDataObject(CarPersistentData pdObj)
        {
            return new Data.Domain.Car
            (
                pdObj.Key,
                pdObj.ImageKey,
                pdObj.LicensePlate,
                pdObj.Brand,
                pdObj.Model,
                pdObj.Year,
                pdObj.EngineSize,
                pdObj.HorsePower,
                pdObj.Seats,
                pdObj.Price
            );
        }
    }
}