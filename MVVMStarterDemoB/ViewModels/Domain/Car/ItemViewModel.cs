using DataTransformation.Interfaces;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Car;

namespace MVVMStarterDemoB.ViewModels.Domain.Car
{
    public class ItemViewModel : ItemViewModelWithImage<CarViewModel>
    {
        public override int ImageKey
        {
            get { return TypedDataObject.ImageKey; }
        }

        public override string Description
        {
            get { return TypedDataObject.LicensePlate; }
        }

        public ItemViewModel(ITransformedData obj) : base(obj)
        {
        }
    }
}