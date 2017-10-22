using ExtensionsModel.Implementation;
using MVVMStarterDemoB.Configuration.App;

namespace MVVMStarterDemoB.Models.Domain.Sale
{
    public class SaleCatalog : WebAPIPersistableCatalog<Sale, SaleDBO>
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

        private SaleCatalog() : base(AppConfig.ServerURL, "Sales", new SaleDTOFactory(), new SaleDBOFactory())
        {
        }
        #endregion

        public int CarsSoldByEmployee(int employeeKey)
        {
            SaleDTOFactory dtoFactory = new SaleDTOFactory();
            return AllDTO.FindAll(obj => dtoFactory.CreateT(obj).EmployeeKey == employeeKey).Count;
        }
    }
}