using System.Collections.Generic;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Car;
using MVVMStarterDemoB.Models.App;

namespace MVVMStarterDemoB.ViewModels.Domain.Car
{
    public class MasterDetailsViewModel : MasterDetailsViewModelCRUD<CarVMO>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.CarCatalog,
                new List<string> { "Plate", "Model", "Brand", "Year" },
                new List<string> { "CCM", "HK", "Seats", "Price", "Image" })
        {
        }
    }
}