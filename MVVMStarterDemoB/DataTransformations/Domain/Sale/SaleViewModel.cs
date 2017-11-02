using System;
using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Sale
{
    public class SaleViewModel : TransformedWithDefaultBase<Models.Domain.Sale.Sale>
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

        public override void SetValuesFromObject(Models.Domain.Sale.Sale saleObj)
        {
            Key = saleObj.Key;
            CarKey = saleObj.CarKey;
            CustomerKey = saleObj.CustomerKey;
            EmployeeKey = saleObj.EmployeeKey;

            SalesDate = saleObj.SalesDate;
            FinalPrice = saleObj.FinalPrice;
        }
    }
}