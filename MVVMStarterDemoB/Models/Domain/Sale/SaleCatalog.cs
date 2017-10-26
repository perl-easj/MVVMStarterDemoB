using ExtensionsModel.Implementation;
using MVVMStarterDemoB.Configuration.App;
using MVVMStarterDemoB.DataTransformations.Domain.Sale;
using MVVMStarterDemoB.ViewModels.Domain.Sale;

namespace MVVMStarterDemoB.Models.Domain.Sale
{
    public class SaleCatalog : WebAPIPersistableCatalog<Sale, SaleDTO>
    {
        #region Model Singleton implementation
        private static SaleCatalog _instance;

        public static SaleCatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new SaleCatalog();
                return _instance;
            }
        }

        private SaleCatalog() : base(AppConfig.ServerURL, "Sales", new SaleViewModelFactory(), new SaleDTOFactory())
        {
        }
        #endregion

        public int CarsSoldByEmployee(int employeeKey)
        {
            return All.FindAll(obj => obj.EmployeeKey == employeeKey).Count;
        }
    }
}