using System.Collections.Generic;
using Data.Transformed.Interfaces;
using MVVMStarterDemoB.DataTransformations.ViewData;
using MVVMStarterDemoB.Models.App;
using MVVMStarterDemoB.ViewModels.Base;
using MVVMStarterDemoB.ViewModels.Data;

namespace MVVMStarterDemoB.ViewModels.Page
{
    public class EmployeePageViewModel : PageViewModelAppBase<EmployeeViewData>
    {
        public EmployeePageViewModel()
            : base(DomainModel.Catalogs.Employees,
                new List<string> { "Name", "CarsSold" },
                new List<string> { "Image", "Title", "Phone", "Email", "Employed" })
        {
        }

        public override IDataWrapper<EmployeeViewData> CreateDataViewModel(EmployeeViewData obj)
        {
            return new EmployeeDataViewModel(obj);
        }
    }
}