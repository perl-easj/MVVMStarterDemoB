using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Employee
{
    public class EmployeeDTOFactory : FactoryBase<Models.Domain.Employee.Employee, EmployeeDTO>
    {
        public override Models.Domain.Employee.Employee CreateDomainObject(EmployeeDTO dtoObj)
        {
            return new Models.Domain.Employee.Employee(
                dtoObj.Id,
                dtoObj.ImageKey,
                dtoObj.FullName,
                dtoObj.Phone,
                dtoObj.Email,
                dtoObj.Title,
                dtoObj.EmployedDate);
        }
    }
}