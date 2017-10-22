namespace MVVMStarterDemoB.Models.App
{
    public class ObjectProvider
    {
        public static Domain.Car.CarCatalog CarCatalog
        {
            get { return Domain.Car.CarCatalog.Instance; }
        }

        public static Domain.Customer.CustomerCatalog CustomerCatalog
        {
            get { return Domain.Customer.CustomerCatalog.Instance; }
        }

        public static Domain.Employee.EmployeeCatalog EmployeeCatalog
        {
            get { return Domain.Employee.EmployeeCatalog.Instance; }
        }

        public static Domain.Sale.SaleCatalog SaleCatalog
        {
            get { return Domain.Sale.SaleCatalog.Instance; }
        }
    }
}