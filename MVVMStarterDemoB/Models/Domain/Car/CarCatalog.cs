using ExtensionsModel.Implementation;
using MVVMStarterDemoB.Configuration.App;
using MVVMStarterDemoB.DataTransformations.Domain.Car;
using MVVMStarterDemoB.ViewModels.Domain.Car;

namespace MVVMStarterDemoB.Models.Domain.Car
{
    public class CarCatalog : WebAPIPersistableCatalog<Car, CarDTO>
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

        private CarCatalog() : base(AppConfig.ServerURL, "Cars", new CarViewModelFactory(), new CarDTOFactory())
        {
        }
        #endregion
    }
}