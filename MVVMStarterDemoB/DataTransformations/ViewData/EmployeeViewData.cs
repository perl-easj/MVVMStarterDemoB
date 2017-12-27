using System;
using MVVMStarterDemoB.DataTransformations.Base;
using MVVMStarterDemoB.Models.App;

namespace MVVMStarterDemoB.DataTransformations.ViewData
{
    public class EmployeeViewData : ViewDataAppBase
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public DateTime EmployedDate { get; set; }
        public int ImageKey { get; set; }

        public int CarsSold
        {
            get { return DomainModel.Instance.CarsSoldByEmployee(Key); }
        }

        public override void SetDefaultValues()
        {
            Key = NullKey;
            FullName = "(not set)";
            Phone = "(not set)";
            Email = "(not set)";
            Title = "(not set)";
            EmployedDate = DateTimeOffset.Now.Date;
            ImageKey = NullKey;
        }
    }
}