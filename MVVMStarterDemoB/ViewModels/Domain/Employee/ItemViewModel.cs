using DTO.Interfaces;
using ExtensionsViewModel.Implementation;
using MVVMStarterDemoB.Models.Domain.Employee;

namespace MVVMStarterDemoB.ViewModels.Domain.Employee
{
    public class ItemViewModel : ItemViewModelWithImage<EmployeeDTO>
    {
        public override int ImageKey
        {
            get { return TypedDataObject.ImageKey; }
        }

        public override string Description
        {
            get { return TypedDataObject.FullName; }
        }

        public ItemViewModel(IDTO obj) : base(obj)
        {
        }
    }
}