using System;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;

namespace MVVMStarterDemoB.DataTransformations.Domain.Employee
{
    public class EmployeeDTOFactory : TransformedDataFactoryBase<Models.Domain.Employee.Employee, EmployeeDTO>
    {
        public override Models.Domain.Employee.Employee CreateDomainObject(ITransformedData obj)
        {
            EmployeeDTO dboObj = (obj as EmployeeDTO);
            if (dboObj == null)
            {
                throw new ArgumentException(nameof(EmployeeDTOFactory));
            }

            return new Models.Domain.Employee.Employee(
                dboObj.Id,
                dboObj.ImageKey,
                dboObj.FullName,
                dboObj.Phone,
                dboObj.Email,
                dboObj.Title,
                dboObj.EmployedDate);
        }
    }
}