using DTO.Interfaces;
using MVVMStarterDemoB.Models.Domain.Car;
using ViewModel.Implementation;

namespace MVVMStarterDemoB.ViewModels.Domain.Car
{
    public class ViewModelFactory : ViewModelFactoryBase<CarDTO>
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