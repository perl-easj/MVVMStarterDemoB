using System.Collections.Generic;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Customer;
using MVVMStarterDemoB.Models.App;

namespace MVVMStarterDemoB.ViewModels.Domain.Customer
{
    public class MasterDetailsViewModel : MasterDetailsViewModelCRUD<Models.Domain.Customer.Customer, CustomerViewModel, CustomerDTO>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.CustomerCatalog,
                new List<string> { "Name" },
                new List<string> { "Image", "Address", "ZipCode", "City", "Phone", "Email", "MaxPrice", "MinPrice", "Newsletter" })
        {
        }
    }
}