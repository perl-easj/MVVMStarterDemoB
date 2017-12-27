using System.Collections.Generic;
using Data.Transformed.Interfaces;
using MVVMStarterDemoB.DataTransformations.ViewData;
using MVVMStarterDemoB.Models.App;
using MVVMStarterDemoB.ViewModels.Base;
using MVVMStarterDemoB.ViewModels.Data;

namespace MVVMStarterDemoB.ViewModels.Page
{
    public class SalePageViewModel : PageViewModelAppBase<SaleViewData>
    {
        public SalePageViewModel()
            : base(DomainModel.Catalogs.Sales,
                new List<string> { "Car", "Customer", "Employee" },
                new List<string> { "Date", "Price" })
        {
        }

        public override IDataWrapper<SaleViewData> CreateDataViewModel(SaleViewData obj)
        {
            return new SaleDataViewModel(obj);
        }
    }
}