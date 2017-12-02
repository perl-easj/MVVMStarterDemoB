using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Employee;

namespace MVVMStarterDemoB.ViewModels.Domain.Employee
{
    public class ItemViewModel : ItemViewModelWithImage<EmployeeVMO>
    {
        public override int ImageKey
        {
            get { return DataObject.ImageKey; }
        }

        public override string Description
        {
            get { return DataObject.FullName; }
        }

        public ItemViewModel(EmployeeVMO obj) : base(obj)
        {
        }
    }
}