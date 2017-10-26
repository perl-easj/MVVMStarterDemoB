using DataTransformation.Interfaces;
using MVVMStarterDemoB.DataTransformations.Domain.Employee;
using ViewModel.Implementation;

namespace MVVMStarterDemoB.ViewModels.Domain.Employee
{
    public class ViewModelFactory : ViewModelFactoryBase<EmployeeViewModel>
    {
        public override ITransformedDataWrapper CreateDetailsViewModel(ITransformedData obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ITransformedDataWrapper CreateItemViewModel(ITransformedData obj)
        {
            return new ItemViewModel(obj);
        }
    }
}