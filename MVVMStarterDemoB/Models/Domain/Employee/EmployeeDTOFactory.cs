using System;
using DTO.Implementation;
using DTO.Interfaces;

namespace MVVMStarterDemoB.Models.Domain.Employee
{
    public class EmployeeDTOFactory : DTOFactoryBase<Employee, EmployeeDTO>
    {
        public override Employee CreateT(IDTO obj)
        {
            EmployeeDTO dtoObj = (obj as EmployeeDTO);
            if (dtoObj == null)
            {
                throw new ArgumentException(nameof(EmployeeDTOFactory));
            }

            return new Employee(
                dtoObj.Key,
                dtoObj.ImageKey,
                dtoObj.FullName,
                dtoObj.Phone,
                dtoObj.Email,
                dtoObj.Title,
                dtoObj.EmployedDate);
        }
    }
}