using DataTransformation.Interfaces;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Customer;

namespace MVVMStarterDemoB.ViewModels.Domain.Customer
{
    public class ItemViewModel : ItemViewModelWithImage<CustomerViewModel>
    {
        public override int ImageKey
        {
            get { return TypedDataObject.ImageKey; }
        }

        public override string Description
        {
            get { return TypedDataObject.FullName; }
        }

        public ItemViewModel(ITransformedData obj) : base(obj)
        {
        }
    }
}