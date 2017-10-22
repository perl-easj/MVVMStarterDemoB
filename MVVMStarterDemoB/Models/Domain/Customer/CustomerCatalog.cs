using ExtensionsModel.Implementation;
using MVVMStarterDemoB.Configuration.App;

namespace MVVMStarterDemoB.Models.Domain.Customer
{
    public class CustomerCatalog : WebAPIPersistableCatalog<Customer, CustomerDBO>
    {
        #region Model Singleton implementation
        private static CustomerCatalog _instance;

        public static CustomerCatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new CustomerCatalog();
                return _instance;
            }
        }

        private CustomerCatalog() : base(AppConfig.ServerURL, "Customers", new CustomerDTOFactory(), new CustomerDBOFactory())
        {
        }
        #endregion
    }
}