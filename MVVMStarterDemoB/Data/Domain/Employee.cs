using System;
using MVVMStarterDemoB.Data.Base;
using MVVMStarterDemoB.Models.App;

namespace MVVMStarterDemoB.Data.Domain
{
    public class Employee : DomainAppBase
    {
        public Employee(int key, int imageKey, string fullName, string phone, string email, string title, DateTime employedDate)
            : base(key, imageKey)
        {
            FullName = fullName;
            Phone = phone;
            Email = email;
            Title = title;
            EmployedDate = employedDate;
        }

        public Employee() : base(NullKey, NullKey)
        {
        }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public DateTime EmployedDate { get; set; }

        public int CarsSold
        {
            get { return DomainModel.Instance.CarsSoldByEmployee(Key); }
        }
    }
}