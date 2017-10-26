using System;
using DataTransformation.Implementation;
using MVVMStarterDemoB.Models.App;

namespace MVVMStarterDemoB.DataTransformations.Domain.Employee
{
    public class EmployeeViewModel : TransformedDataBase
    {
        public string FullName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Title { get; set; }

        public DateTimeOffset EmployedDate { get; set; }

        public int ImageKey { get; set; }

        public int CarsSold
        {
            get { return ObjectProvider.SaleCatalog.CarsSoldByEmployee(Key); }
        }

        public override void SetDefaultValues()
        {
            Key = NullKey;
            FullName = "(not set)";
            Phone = "(not set)";
            Email = "(not set)";
            Title = "(not set)";
            EmployedDate = DateTimeOffset.Now;
            ImageKey = NullKey;
        }

        public override void SetValuesFromObject(Object obj)
        {
            Models.Domain.Employee.Employee employeeObj = (obj as Models.Domain.Employee.Employee);
            if (employeeObj == null)
            {
                throw new ArgumentException(nameof(SetValuesFromObject));
            }

            Key = employeeObj.Key;
            FullName = employeeObj.FullName;
            Phone = employeeObj.Phone;
            Email = employeeObj.Email;
            Title = employeeObj.Title;
            EmployedDate = employeeObj.EmployedDate;
            ImageKey = employeeObj.ImageKey;
        }
    }
}