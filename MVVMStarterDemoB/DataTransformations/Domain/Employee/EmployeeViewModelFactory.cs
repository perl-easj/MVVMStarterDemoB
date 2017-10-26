using System;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;

namespace MVVMStarterDemoB.DataTransformations.Domain.Employee
{
    public class EmployeeViewModelFactory : TransformedDataFactoryBase<Models.Domain.Employee.Employee, EmployeeViewModel>
    {
        public override Models.Domain.Employee.Employee CreateDomainObject(ITransformedData tObj)
        {
            EmployeeViewModel vmObj = (tObj as EmployeeViewModel);
            if (vmObj == null)
            {
                throw new ArgumentException(nameof(EmployeeViewModelFactory));
            }

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