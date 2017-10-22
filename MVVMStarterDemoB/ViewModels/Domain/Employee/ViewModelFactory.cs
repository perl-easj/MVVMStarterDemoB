using DTO.Interfaces;
using MVVMStarterDemoB.Models.Domain.Employee;
using ViewModel.Implementation;

namespace MVVMStarterDemoB.ViewModels.Domain.Employee
{
    public class ViewModelFactory : ViewModelFactoryBase<EmployeeDTO>
    {
        public override IDTOWrapper CreateDetailsViewModel(IDTO obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDTOWrapper CreateItemViewModel(IDTO obj)
        {
            return new ItemViewModel(obj);
        }
    }
}