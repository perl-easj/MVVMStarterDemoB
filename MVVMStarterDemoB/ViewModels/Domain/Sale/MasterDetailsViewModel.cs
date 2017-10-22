using System.Collections.Generic;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.Models.App;

namespace MVVMStarterDemoB.ViewModels.Domain.Sale
{
    public class MasterDetailsViewModel : MasterDetailsViewModelDefault<Models.Domain.Sale.Sale>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.SaleCatalog,
                new List<string> { "Car", "Customer", "Employee" },
                new List<string> { "Date", "Price" })
        {
        }
    }
}