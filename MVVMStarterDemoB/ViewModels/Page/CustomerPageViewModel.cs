using System.Collections.Generic;
using Data.Transformed.Interfaces;
using MVVMStarterDemoB.DataTransformations.ViewData;
using MVVMStarterDemoB.Models.App;
using MVVMStarterDemoB.ViewModels.Base;
using MVVMStarterDemoB.ViewModels.Data;

namespace MVVMStarterDemoB.ViewModels.Page
{
    public class CustomerPageViewModel : PageViewModelAppBase<CustomerViewData>
    {
        public CustomerPageViewModel()
            : base(DomainModel.Catalogs.Customers,
                new List<string> { "Name" },
                new List<string> { "Image", "Address", "ZipCode", "City", "Phone", "Email", "MaxPrice", "MinPrice", "Newsletter" })
        {
        }

        public override IDataWrapper<CustomerViewData> CreateDataViewModel(CustomerViewData obj)
        {
            return new CustomerDataViewModel(obj);
        }
    }
}