using DTO.Interfaces;
using ExtensionsViewModel.Implementation;
using InMemoryStorage.Implementation;
using MVVMStarterDemoB.Models.App;
using MVVMStarterDemoB.Models.Domain.Car;
using MVVMStarterDemoB.Models.Domain.Customer;
using MVVMStarterDemoB.Models.Domain.Employee;
using MVVMStarterDemoB.Models.Domain.Sale;

namespace MVVMStarterDemoB.ViewModels.Domain.Sale
{
    public class ItemViewModel : ItemViewModelWithImage<SaleDTO>
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

        private CarDTO GetCar()
        {
            return ObjectProvider.CarCatalog.ReadDTO(TypedDataObject.CarKey) as CarDTO;
        }

        private CustomerDTO GetCustomer()
        {
            return ObjectProvider.CustomerCatalog.ReadDTO(TypedDataObject.CustomerKey) as CustomerDTO;
        }

        private EmployeeDTO GetEmployee()
        {
            return ObjectProvider.EmployeeCatalog.ReadDTO(TypedDataObject.EmployeeKey) as EmployeeDTO;
        }

        public ItemViewModel(IDTO obj) : base(obj)
        {
        }
    }
}