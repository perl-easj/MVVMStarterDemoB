using System;
using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Sale
{
    public class SaleVMO : CopyableWithDefaultValuesBase
    {
        public int CarKey { get; set; }

        public int CustomerKey { get; set; }

        public int EmployeeKey { get; set; }

        public DateTimeOffset SalesDate { get; set; }

        public int FinalPrice { get; set; }

        public override void SetDefaultValues()
        {
            Key = NullKey;
            CarKey = NullKey;
            CustomerKey = NullKey;
            EmployeeKey = NullKey;

            SalesDate = DateTimeOffset.Now;
            FinalPrice = 0;
        }
    }
}