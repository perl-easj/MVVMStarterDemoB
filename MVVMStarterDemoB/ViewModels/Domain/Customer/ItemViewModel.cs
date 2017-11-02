using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Customer;

namespace MVVMStarterDemoB.ViewModels.Domain.Customer
{
    public class ItemViewModel : ItemViewModelWithImage<CustomerViewModel>
    {
        public override int ImageKey
        {
            get { return DataObject.ImageKey; }
        }

        public override string Description
        {
            get { return DataObject.FullName; }
        }

        public ItemViewModel(CustomerViewModel obj) : base(obj)
        {
        }
    }
}