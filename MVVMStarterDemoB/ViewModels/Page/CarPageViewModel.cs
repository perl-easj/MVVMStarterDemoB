using System.Collections.Generic;
using Data.Transformed.Interfaces;
using MVVMStarterDemoB.DataTransformations.ViewData;
using MVVMStarterDemoB.Models.App;
using MVVMStarterDemoB.ViewModels.Base;
using MVVMStarterDemoB.ViewModels.Data;

namespace MVVMStarterDemoB.ViewModels.Page
{
    public class CarPageViewModel : PageViewModelAppBase<CarViewData>
    {
        public CarPageViewModel()
            : base(DomainModel.Catalogs.Cars,
                new List<string> { "Plate", "Model", "Brand", "Year" },
                new List<string> { "CCM", "HK", "Seats", "Price", "Image" })
        {
        }

        public override IDataWrapper<CarViewData> CreateDataViewModel(CarViewData obj)
        {
            return new CarDataViewModel(obj);
        }
    }
}