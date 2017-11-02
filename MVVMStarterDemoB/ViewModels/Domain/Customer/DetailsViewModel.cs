using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Customer;

namespace MVVMStarterDemoB.ViewModels.Domain.Customer
{
    public class DetailsViewModel : DetailsViewModelWithSelectableImage<CustomerViewModel>
    {
        public string Name
        {
            get { return DataObject.FullName; }
            set
            {
                DataObject.FullName = value;
                OnPropertyChanged();
            }
        }

        public string Address
        {
            get { return DataObject.Address; }
            set
            {
                DataObject.Address = value;
                OnPropertyChanged();
            }
        }

        public int ZipCode
        {
            get { return DataObject.ZipCode; }
            set
            {
                DataObject.ZipCode = value;
                OnPropertyChanged();
            }
        }

        public string City
        {
            get { return DataObject.City; }
            set
            {
                DataObject.City = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get { return DataObject.Phone; }
            set
            {
                DataObject.Phone = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return DataObject.Email; }
            set
            {
                DataObject.Email = value;
                OnPropertyChanged();
            }
        }

        public int MinPrice
        {
            get { return DataObject.MinPrice; }
            set
            {
                DataObject.MinPrice = value;
                OnPropertyChanged();
            }
        }

        public int MaxPrice
        {
            get { return DataObject.MaxPrice; }
            set
            {
                DataObject.MaxPrice = value;
                OnPropertyChanged();
            }
        }

        public bool NewsLetter
        {
            get { return DataObject.NewsLetter; }
            set
            {
                DataObject.NewsLetter = value;
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

        public DetailsViewModel(CustomerViewModel obj) : base(obj, "Customer")
        {
        }
    }
}