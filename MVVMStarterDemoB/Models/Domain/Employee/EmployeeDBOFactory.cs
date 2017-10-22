using System;
using DBOImplementation;
using DBOInterfaces;

namespace MVVMStarterDemoB.Models.Domain.Employee
{
    public class EmployeeDBOFactory : DBOFactoryBase<Employee, EmployeeDBO>
    {
        public override Employee CreateT(IDBO obj)
        {
            EmployeeDBO dboObj = (obj as EmployeeDBO);
            if (dboObj == null)
            {
                throw new ArgumentException(nameof(EmployeeDBOFactory));
            }

            return new Employee(
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