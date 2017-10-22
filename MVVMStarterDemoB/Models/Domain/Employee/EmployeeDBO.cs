using System;
using DBOImplementation;

namespace MVVMStarterDemoB.Models.Domain.Employee
{
    public class EmployeeDBO : DBOBase
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Title { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime EmployedDate { get; set; }

        public int ImageKey { get; set; }

        public int CarsSold { get; set; }

        public override void SetValuesFromObject(object obj)
        {
            Employee employeeObj = (obj as Employee);
            if (employeeObj == null)
            {
                throw new ArgumentException(nameof(SetValuesFromObject));
            }

            Id = employeeObj.Key;
            FullName = employeeObj.FullName;
            Phone = employeeObj.Phone;
            Email = employeeObj.Email;
            Title = employeeObj.Title;
            EmployedDate = employeeObj.EmployedDate.DateTime;
            ImageKey = employeeObj.ImageKey;
            CarsSold = employeeObj.CarsSold;
        }
    }
}