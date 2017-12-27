using System;
using MVVMStarterDemoB.DataTransformations.ViewData;
using MVVMStarterDemoB.ViewModels.Base;

namespace MVVMStarterDemoB.ViewModels.Data
{
    public class CustomerDataViewModel : DataViewModelAppBase<CustomerViewData>
    {
        public CustomerDataViewModel(CustomerViewData obj) : base(obj, "Customer")
        {
        }

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

        public override string HeaderText
        {
            get
            {
                if (Name == null || !Name.Contains(" "))
                {
                    return Name;
                }
                else
                {
                    int index = Name.IndexOf(" ", StringComparison.Ordinal);
                    var shortName = Name.Substring(0, index + 1);
                    if (Name.Length > index + 1)
                    {
                        shortName += Name.Substring(index + 1, 1) + ".";
                    }
                    return shortName;
                }
            }
        }

        public override string ContentText
        {
            get { return City; }
        }
    }
}