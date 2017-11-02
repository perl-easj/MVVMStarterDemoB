using System.Collections.Generic;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Sale;
using MVVMStarterDemoB.Models.App;

namespace MVVMStarterDemoB.ViewModels.Domain.Sale
{
    public class MasterDetailsViewModel : MasterDetailsViewModelCRUD<Models.Domain.Sale.Sale, SaleViewModel, SaleDTO>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.SaleCatalog,
                new List<string> { "Car", "Customer", "Employee" },
                new List<string> { "Date", "Price" })
        {
        }
    }
}