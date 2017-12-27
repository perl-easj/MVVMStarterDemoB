using System;
using MVVMStarterDemoB.DataTransformations.Base;

namespace MVVMStarterDemoB.DataTransformations.PersistentData
{
    public class SalePersistentData : PersistentDataAppBase
    {
        public int CarKey { get; set; }
        public int CustomerKey { get; set; }
        public int EmployeeKey { get; set; }
        public DateTime SalesDate { get; set; }
        public int FinalPrice { get; set; }
    }
}