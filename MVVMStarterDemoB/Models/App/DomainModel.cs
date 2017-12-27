using MVVMStarterDemoB.Models.Catalog;

namespace MVVMStarterDemoB.Models.App
{
    public class DomainModel
    {
        #region Instance fields
        private CarCatalog _carCatalog;
        private CustomerCatalog _customerCatalog;
        private EmployeeCatalog _employeeCatalog;
        private SaleCatalog _saleCatalog;
        #endregion

        #region Singleton implementation
        private static DomainModel _instance;
        public static DomainModel Instance
        {
            get
            {
                _instance = _instance ?? (_instance = new DomainModel());
                return _instance;
            }
        }

        public static DomainModel Catalogs { get { return Instance; } }
        #endregion

        #region Constructor
        private DomainModel()
        {
            _carCatalog = new CarCatalog();
            _customerCatalog = new CustomerCatalog();
            _employeeCatalog = new EmployeeCatalog();
            _saleCatalog = new SaleCatalog();
        }
        #endregion

        #region Properties
        public CarCatalog Cars { get { return _carCatalog; } }
        public CustomerCatalog Customers { get { return _customerCatalog; } }
        public EmployeeCatalog Employees { get { return _employeeCatalog; } }
        public SaleCatalog Sales { get { return _saleCatalog; } }
        #endregion

        public void Load()
        {
            _carCatalog.Load();
            _customerCatalog.Load();
            _employeeCatalog.Load();
            _saleCatalog.Load();
        }

        public void Save()
        {
            _carCatalog.Save();
            _customerCatalog.Save();
            _employeeCatalog.Save();
            _saleCatalog.Save();
        }

        #region Business logic methods
        public int CarsSoldByEmployee(int employeeKey)
        {
            return Sales.All.FindAll(obj => obj.EmployeeKey == employeeKey).Count;
        }
        #endregion
    }
}