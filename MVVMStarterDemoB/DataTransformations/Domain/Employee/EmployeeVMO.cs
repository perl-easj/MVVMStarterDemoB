using System;
using DataTransformation.Implementation;
using MVVMStarterDemoB.Models.App;

namespace MVVMStarterDemoB.DataTransformations.Domain.Employee
{
    public class EmployeeVMO : CopyableWithDefaultValuesBase
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
    }
}