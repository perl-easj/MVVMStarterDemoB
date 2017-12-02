using DataTransformation.Interfaces;
using MVVMStarterDemoB.DataTransformations.Domain.Employee;
using ViewModel.Implementation;

namespace MVVMStarterDemoB.ViewModels.Domain.Employee
{
    public class ViewModelFactory : ViewModelFactoryBase<EmployeeVMO>
    {
        public override IDataWrapper<EmployeeVMO> CreateDetailsViewModel(EmployeeVMO obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDataWrapper<EmployeeVMO> CreateItemViewModel(EmployeeVMO obj)
        {
            return new ItemViewModel(obj);
        }
    }
}