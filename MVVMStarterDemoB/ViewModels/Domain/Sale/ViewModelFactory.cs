using DataTransformation.Interfaces;
using MVVMStarterDemoB.DataTransformations.Domain.Sale;
using ViewModel.Implementation;

namespace MVVMStarterDemoB.ViewModels.Domain.Sale
{
    public class ViewModelFactory : ViewModelFactoryBase<SaleVMO>
    {
        public override IDataWrapper<SaleVMO> CreateDetailsViewModel(SaleVMO obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDataWrapper<SaleVMO> CreateItemViewModel(SaleVMO obj)
        {
            return new ItemViewModel(obj);
        }
    }
}