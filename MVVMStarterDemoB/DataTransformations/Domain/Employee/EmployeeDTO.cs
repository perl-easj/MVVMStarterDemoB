using System;
using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Employee
{
    public class EmployeeDTO : CopyableBase
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Title { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime EmployedDate { get; set; }

        public int ImageKey { get; set; }

        public int CarsSold { get; set; }
    }
}