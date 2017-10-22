using System;
using MVVMStarterDemoB.Models.Base;

namespace MVVMStarterDemoB.Models.Domain.Employee
{
    public class Employee : PersonBase
    {
        private static Sale.SaleCatalog _saleCatalog;

        public Employee(int key, int imageKey, string fullName, string phone, string email, string title, DateTimeOffset employedDate)
            : base(key, imageKey, fullName, phone, email)
        {
            Title = title;
            EmployedDate = employedDate;
            _saleCatalog = Sale.SaleCatalog.Instance;
        }

        public string Title { get; set; }

        public DateTimeOffset EmployedDate { get; set; }

        public int CarsSold
        {
            get { return _saleCatalog.CarsSoldByEmployee(Key); }
        }
    }
}