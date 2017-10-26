using DataTransformation.Interfaces;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Customer;

namespace MVVMStarterDemoB.ViewModels.Domain.Customer
{
    public class DetailsViewModel : DetailsViewModelWithSelectableImage<CustomerViewModel>
    {
        public string Name
        {
            get { return TypedDataObject.FullName; }
            set
            {
                TypedDataObject.FullName = value;
                OnPropertyChanged();
            }
        }

        public string Address
        {
            get { return TypedDataObject.Address; }
            set
            {
                TypedDataObject.Address = value;
                OnPropertyChanged();
            }
        }

        public int ZipCode
        {
            get { return TypedDataObject.ZipCode; }
            set
            {
                TypedDataObject.ZipCode = value;
                OnPropertyChanged();
            }
        }

        public string City
        {
            get { return TypedDataObject.City; }
            set
            {
                TypedDataObject.City = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get { return TypedDataObject.Phone; }
            set
            {
                TypedDataObject.Phone = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return TypedDataObject.Email; }
            set
            {
                TypedDataObject.Email = value;
                OnPropertyChanged();
            }
        }

        public int MinPrice
        {
            get { return TypedDataObject.MinPrice; }
            set
            {
                TypedDataObject.MinPrice = value;
                OnPropertyChanged();
            }
        }

        public int MaxPrice
        {
            get { return TypedDataObject.MaxPrice; }
            set
            {
                TypedDataObject.MaxPrice = value;
                OnPropertyChanged();
            }
        }

        public bool NewsLetter
        {
            get { return TypedDataObject.NewsLetter; }
            set
            {
                TypedDataObject.NewsLetter = value;
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

        public DetailsViewModel(ITransformedData obj) : base(obj, "Customer")
        {
        }
    }
}