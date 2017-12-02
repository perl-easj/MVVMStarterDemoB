using DataTransformation.Interfaces;
using MVVMStarterDemoB.DataTransformations.Domain.Customer;
using ViewModel.Implementation;

namespace MVVMStarterDemoB.ViewModels.Domain.Customer
{
    public class ViewModelFactory : ViewModelFactoryBase<CustomerVMO>
    {
        public override IDataWrapper<CustomerVMO> CreateDetailsViewModel(CustomerVMO obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDataWrapper<CustomerVMO> CreateItemViewModel(CustomerVMO obj)
        {
            return new ItemViewModel(obj);
        }
    }
}