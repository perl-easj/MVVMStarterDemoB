using DataTransformation.Interfaces;
using MVVMStarterDemoB.DataTransformations.Domain.Sale;
using ViewModel.Implementation;

namespace MVVMStarterDemoB.ViewModels.Domain.Sale
{
    public class ViewModelFactory : ViewModelFactoryBase<SaleViewModel>
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