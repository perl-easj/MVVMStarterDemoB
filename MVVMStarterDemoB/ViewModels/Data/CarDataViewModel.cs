﻿using MVVMStarterDemoB.DataTransformations.ViewData;
using MVVMStarterDemoB.ViewModels.Base;

namespace MVVMStarterDemoB.ViewModels.Data
{
    public class CarDataViewModel : DataViewModelAppBase<CarViewData>
    {
        public CarDataViewModel(CarViewData obj) : base(obj, "Car")
        {
        }

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
            get { return DataObject.EngineSize; }
            set
            {
                DataObject.EngineSize = value;
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

        public override string HeaderText
        {
            get { return Plate; }
        }

        public override string ContentText
        {
            get { return DataObject.Brand + " " + DataObject.Model; }
        }
    }
}