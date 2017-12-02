using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Car;

namespace MVVMStarterDemoB.ViewModels.Domain.Car
{
    public class DetailsViewModel : DetailsViewModelWithSelectableImage<CarVMO>
    {
        public string Plate
        {
            get { return DataObject.LicensePlate; }
            set
            {
                DataObject.LicensePlate = value;
                OnPropertyChanged();
            }
        }

        public string Brand
        {
            get { return DataObject.Brand; }
            set
            {
                DataObject.Brand = value;
                OnPropertyChanged();
            }
        }

        public string Model
        {
            get { return DataObject.Model; }
            set
            {
                DataObject.Model = value;
                OnPropertyChanged();
            }
        }

        public int Year
        {
            get { return DataObject.Year; }
            set
            {
                DataObject.Year = value;
                OnPropertyChanged();
            }
        }

        public int CCM
        {
            get { return DataObject.EngineSizeCm3; }
            set
            {
                DataObject.EngineSizeCm3 = value;
                OnPropertyChanged();
            }
        }

        public int HK
        {
            get { return DataObject.HorsePower; }
            set
            {
                DataObject.HorsePower = value;
                OnPropertyChanged();
            }
        }

        public int Seats
        {
            get { return DataObject.Seats; }
            set
            {
                DataObject.Seats = value;
                OnPropertyChanged();
            }
        }

        public int Price
        {
            get { return DataObject.Price; }
            set
            {
                DataObject.Price = value;
                OnPropertyChanged();
            }
        }

        public override int ImageKey
        {
            get { return DataObject.ImageKey; }
            set
            {
                DataObject.ImageKey = value;
                OnPropertyChanged();
            }
        }

        public DetailsViewModel(CarVMO obj) : base(obj, "Car")
        {
        }
    }
}