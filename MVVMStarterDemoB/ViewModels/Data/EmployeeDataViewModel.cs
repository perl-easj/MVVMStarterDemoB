using System;
using MVVMStarterDemoB.DataTransformations.ViewData;
using MVVMStarterDemoB.ViewModels.Base;

namespace MVVMStarterDemoB.ViewModels.Data
{
    public class EmployeeDataViewModel : DataViewModelAppBase<EmployeeViewData>
    {
        public EmployeeDataViewModel(EmployeeViewData obj) : base(obj, "Employee")
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

        public string Title
        {
            get { return DataObject.Title; }
            set
            {
                DataObject.Title = value;
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

        public int CarsSold
        {
            get { return DataObject.CarsSold; }
        }

        public DateTimeOffset Employed
        {
            get { return DataObject.EmployedDate; }
            set
            {
                DataObject.EmployedDate = value.Date;
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
            get { return Phone; }
        }
    }
}