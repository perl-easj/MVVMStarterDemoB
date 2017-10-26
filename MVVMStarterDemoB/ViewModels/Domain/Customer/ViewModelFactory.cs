using DataTransformation.Interfaces;
using MVVMStarterDemoB.DataTransformations.Domain.Customer;
using ViewModel.Implementation;

namespace MVVMStarterDemoB.ViewModels.Domain.Customer
{
    public class ViewModelFactory : ViewModelFactoryBase<CustomerViewModel>
    {
        public override ITransformedDataWrapper CreateDetailsViewModel(ITransformedData obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ITransformedDataWrapper CreateItemViewModel(ITransformedData obj)
        {
            return new ItemViewModel(obj);
        }
    }
}