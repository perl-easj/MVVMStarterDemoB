using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.DataTransformations.Domain.Employee;

namespace MVVMStarterDemoB.ViewModels.Domain.Employee
{
    public class ItemViewModel : ItemViewModelWithImage<EmployeeViewModel>
    {
        public override int ImageKey
        {
            get { return DataObject.ImageKey; }
        }

        public override string Description
        {
            get { return DataObject.FullName; }
        }

        public ItemViewModel(EmployeeViewModel obj) : base(obj)
        {
        }
    }
}