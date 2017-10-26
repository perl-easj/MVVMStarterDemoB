using System;
using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Sale
{
    public class SaleViewModel : TransformedDataBase
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

        public override void SetValuesFromObject(Object obj)
        {
            Models.Domain.Sale.Sale saleObj = (obj as Models.Domain.Sale.Sale);
            if (saleObj == null)
            {
                throw new ArgumentException(nameof(SetValuesFromObject));
            }

            Key = saleObj.Key;
            CarKey = saleObj.CarKey;
            CustomerKey = saleObj.CustomerKey;
            EmployeeKey = saleObj.EmployeeKey;

            SalesDate = saleObj.SalesDate;
            FinalPrice = saleObj.FinalPrice;
        }
    }
}