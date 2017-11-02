using DataTransformation.Interfaces;
using MVVMStarterDemoB.DataTransformations.Domain.Car;
using ViewModel.Implementation;

namespace MVVMStarterDemoB.ViewModels.Domain.Car
{
    public class ViewModelFactory : ViewModelFactoryBase<Models.Domain.Car.Car, CarViewModel>
    {
        public override IDataWrapper<CarViewModel> CreateDetailsViewModel(CarViewModel obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDataWrapper<CarViewModel> CreateItemViewModel(CarViewModel obj)
        {
            return new ItemViewModel(obj);
        }
    }
}