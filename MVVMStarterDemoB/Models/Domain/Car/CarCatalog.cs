using ExtensionsModel.Implementation;
using MVVMStarterDemoB.Configuration.App;
using MVVMStarterDemoB.DataTransformations.Domain.Car;

namespace MVVMStarterDemoB.Models.Domain.Car
{
    public class CarCatalog : WebAPIPersistableCatalog<Car, CarVMO, CarDTO>
    {
        #region Model Singleton implementation
        private static CarCatalog _instance;

        public static CarCatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new CarCatalog();
                return _instance;
            }
        }

        private CarCatalog() : base(AppConfig.ServerURL, "Cars")
        {
        }
        #endregion

        #region Data transformations
        public override Car CreateDomainObjectFromDTO(CarDTO dtoObj)
        {
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

        public override CarDTO CreateDTO(Car obj)
        {
            CarDTO dtoObj = new CarDTO();

            dtoObj.Id = obj.Key;
            dtoObj.Brand = obj.Brand;
            dtoObj.Model = obj.Model;
            dtoObj.LicensePlate = obj.LicensePlate;
            dtoObj.Year = obj.Year;
            dtoObj.Seats = obj.Seats;
            dtoObj.Price = obj.Price;
            dtoObj.EngineSize = obj.EngineSizeCm3;
            dtoObj.HorsePower = obj.HorsePower;
            dtoObj.ImageKey = obj.ImageKey;

            return dtoObj;
        }

        public override Car CreateDomainObjectFromVMO(CarVMO vmObj)
        {
            return new Car(
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

        public override CarVMO CreateVMO(Car obj)
        {
            CarVMO vmoObj = new CarVMO();

            vmoObj.Key = obj.Key;
            vmoObj.LicensePlate = obj.LicensePlate;
            vmoObj.Brand = obj.Brand;
            vmoObj.Model = obj.Model;
            vmoObj.Year = obj.Year;
            vmoObj.EngineSizeCm3 = obj.EngineSizeCm3;
            vmoObj.HorsePower = obj.HorsePower;
            vmoObj.Seats = obj.Seats;
            vmoObj.Price = obj.Price;
            vmoObj.ImageKey = obj.ImageKey;

            return vmoObj;
        } 
        #endregion
    }
}