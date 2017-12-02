using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Car;

namespace MVVMStarterDemoB.ViewModels.Domain.Car
{
    public class ItemViewModel : ItemViewModelWithImage<CarVMO>
    {
        public override int ImageKey
        {
            get { return DataObject.ImageKey; }
        }

        public override string Description
        {
            get { return DataObject.LicensePlate; }
        }

        public ItemViewModel(CarVMO obj) : base(obj)
        {
        }
    }
}