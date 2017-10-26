using DataTransformation.Interfaces;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Car;

namespace MVVMStarterDemoB.ViewModels.Domain.Car
{
    public class DetailsViewModel : DetailsViewModelWithSelectableImage<CarViewModel>
    {
        public string Plate
        {
            get { return TypedDataObject.LicensePlate; }
            set
            {
                TypedDataObject.LicensePlate = value;
                OnPropertyChanged();
            }
        }

        public string Brand
        {
            get { return TypedDataObject.Brand; }
            set
            {
                TypedDataObject.Brand = value;
                OnPropertyChanged();
            }
        }

        public string Model
        {
            get { return TypedDataObject.Model; }
            set
            {
                TypedDataObject.Model = value;
                OnPropertyChanged();
            }
        }

        public int Year
        {
            get { return TypedDataObject.Year; }
            set
            {
                TypedDataObject.Year = value;
                OnPropertyChanged();
            }
        }

        public int CCM
        {
            get { return TypedDataObject.EngineSizeCm3; }
            set
            {
                TypedDataObject.EngineSizeCm3 = value;
                OnPropertyChanged();
            }
        }

        public int HK
        {
            get { return TypedDataObject.HorsePower; }
            set
            {
                TypedDataObject.HorsePower = value;
                OnPropertyChanged();
            }
        }

        public int Seats
        {
            get { return TypedDataObject.Seats; }
            set
            {
                TypedDataObject.Seats = value;
                OnPropertyChanged();
            }
        }

        public int Price
        {
            get { return TypedDataObject.Price; }
            set
            {
                TypedDataObject.Price = value;
                OnPropertyChanged();
            }
        }

        public override int ImageKey
        {
            get { return TypedDataObject.ImageKey; }
            set
            {
                TypedDataObject.ImageKey = value;
                OnPropertyChanged();
            }
        }

        public DetailsViewModel(ITransformedData obj) : base(obj, "Car")
        {
        }
    }
}