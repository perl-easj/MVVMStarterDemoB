using System.Collections.Generic;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Employee;
using MVVMStarterDemoB.Models.App;

namespace MVVMStarterDemoB.ViewModels.Domain.Employee
{
    public class MasterDetailsViewModel : MasterDetailsViewModelCRUD<EmployeeVMO>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.EmployeeCatalog,
                new List<string> { "Name", "CarsSold" },
                new List<string> { "Image", "Title", "Phone", "Email", "Employed" })
        {
        }
    }
}