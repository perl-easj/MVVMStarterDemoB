using DataTransformation.Interfaces;
using MVVMStarterDemoB.DataTransformations.Domain.Customer;
using ViewModel.Implementation;

namespace MVVMStarterDemoB.ViewModels.Domain.Customer
{
    public class ViewModelFactory : ViewModelFactoryBase<Models.Domain.Customer.Customer, CustomerViewModel>
    {
        public override IDataWrapper<CustomerViewModel> CreateDetailsViewModel(CustomerViewModel obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDataWrapper<CustomerViewModel> CreateItemViewModel(CustomerViewModel obj)
        {
            return new ItemViewModel(obj);
        }
    }
}