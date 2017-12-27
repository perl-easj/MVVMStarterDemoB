using System;
using MVVMStarterDemoB.DataTransformations.Base;

namespace MVVMStarterDemoB.DataTransformations.PersistentData
{
    public class EmployeePersistentData : PersistentDataAppBase
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime EmployedDate { get; set; }
        public int ImageKey { get; set; }
        public int CarsSold { get; set; }
    }
}