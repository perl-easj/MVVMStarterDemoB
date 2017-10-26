using ExtensionsModel.Implementation;
using MVVMStarterDemoB.Configuration.App;
using MVVMStarterDemoB.DataTransformations.Domain.Customer;
using MVVMStarterDemoB.ViewModels.Domain.Customer;

namespace MVVMStarterDemoB.Models.Domain.Customer
{
    public class CustomerCatalog : WebAPIPersistableCatalog<Customer, CustomerDTO>
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

        private CustomerCatalog() : base(AppConfig.ServerURL, "Customers", new CustomerViewModelFactory(), new CustomerDTOFactory())
        {
        }
        #endregion
    }
}