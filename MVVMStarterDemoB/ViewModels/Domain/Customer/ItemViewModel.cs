using DTO.Interfaces;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.Models.Domain.Customer;

namespace MVVMStarterDemoB.ViewModels.Domain.Customer
{
    public class ItemViewModel : ItemViewModelWithImage<CustomerDTO>
    {
        public override int ImageKey
        {
            get { return TypedDataObject.ImageKey; }
        }

        public override string Description
        {
            get { return TypedDataObject.FullName; }
        }

        public ItemViewModel(IDTO obj) : base(obj)
        {
        }
    }
}