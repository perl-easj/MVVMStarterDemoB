using DataTransformation.Interfaces;
using ExtensionsViewModel.Implementation;
using InMemoryStorage.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Car;
using MVVMStarterDemoB.DataTransformations.Domain.Customer;
using MVVMStarterDemoB.DataTransformations.Domain.Employee;
using MVVMStarterDemoB.DataTransformations.Domain.Sale;
using MVVMStarterDemoB.Models.App;
using MVVMStarterDemoB.ViewModels.Domain.Car;
using MVVMStarterDemoB.ViewModels.Domain.Customer;
using MVVMStarterDemoB.ViewModels.Domain.Employee;

namespace MVVMStarterDemoB.ViewModels.Domain.Sale
{
    public class ItemViewModel : ItemViewModelWithImage<SaleViewModel>
    {
        public string DescriptionCar
        {
            get { return GetCar() == null ? string.Empty : GetCar().LicensePlate; }
        }

        public string DescriptionCustomer
        {
            get { return GetCustomer() == null ? string.Empty : "Bought by " + GetCustomer().FullName; }
        }

        public string DescriptionEmployee
        {
            get { return GetEmployee() == null ? string.Empty : "Sold by " + GetEmployee().FullName; }
        }

        public override string Description
        {
            get { return "Not used"; }
        }

        public override int FontSize
        {
            get { return 14; }
        }

        public override int ImageKey
        {
            get { return GetCar() != null ? GetCar().ImageKey : StorableBase.NullKey; }
        }

        private CarViewModel GetCar()
        {
            return ObjectProvider.CarCatalog.Read(DataObject.CarKey) as CarViewModel;
        }

        private CustomerViewModel GetCustomer()
        {
            return ObjectProvider.CustomerCatalog.Read(DataObject.CustomerKey) as CustomerViewModel;
        }

        private EmployeeViewModel GetEmployee()
        {
            return ObjectProvider.EmployeeCatalog.Read(DataObject.EmployeeKey) as EmployeeViewModel;
        }

        public ItemViewModel(SaleViewModel obj) : base(obj)
        {
        }
    }
}