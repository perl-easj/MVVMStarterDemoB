using DTO.Interfaces;
using MVVMStarterDemoB.Models.Domain.Customer;
using ViewModel.Implementation;

namespace MVVMStarterDemoB.ViewModels.Domain.Customer
{
    public class ViewModelFactory : ViewModelFactoryBase<CustomerDTO>
    {
        public override IDTOWrapper CreateDetailsViewModel(IDTO obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDTOWrapper CreateItemViewModel(IDTO obj)
        {
            return new ItemViewModel(obj);
        }
    }
}