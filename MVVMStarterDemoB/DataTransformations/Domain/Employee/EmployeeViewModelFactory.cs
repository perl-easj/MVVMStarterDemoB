using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Employee
{
    public class EmployeeViewModelFactory : FactoryBase<Models.Domain.Employee.Employee, EmployeeViewModel>
    {
        public override Models.Domain.Employee.Employee CreateDomainObject(EmployeeViewModel vmObj)
        {
            return new Models.Domain.Employee.Employee(
                vmObj.Key,
                vmObj.ImageKey,
                vmObj.FullName,
                vmObj.Phone,
                vmObj.Email,
                vmObj.Title,
                vmObj.EmployedDate);
        }
    }
}