using System.Collections.Generic;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.Models.App;

namespace MVVMStarterDemoB.ViewModels.Domain.Car
{
    public class MasterDetailsViewModel : MasterDetailsViewModelDefault<Models.Domain.Car.Car>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.CarCatalog,
                new List<string> { "Plate", "Model", "Brand", "Year" },
                new List<string> { "CCM", "HK", "Seats", "Price", "Image" })
        {
        }
    }
}