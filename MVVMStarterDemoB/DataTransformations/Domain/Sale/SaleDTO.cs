using System;
using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Sale
{
    public class SaleDTO : TransformedBase<Models.Domain.Sale.Sale>
    {
        public int Id { get; set; }

        public int CarKey { get; set; }

        public int CustomerKey { get; set; }

        public int EmployeeKey { get; set; }

        public DateTime SalesDate { get; set; }

        public int FinalPrice { get; set; }

        public override void SetValuesFromObject(Models.Domain.Sale.Sale saleObj)
        {
            Id = saleObj.Key;
            CarKey = saleObj.CarKey;
            CustomerKey = saleObj.CustomerKey;
            EmployeeKey = saleObj.EmployeeKey;

            SalesDate = saleObj.SalesDate.DateTime;
            FinalPrice = saleObj.FinalPrice;
        }
    }
}