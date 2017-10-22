using System;
using DBOImplementation;

namespace MVVMStarterDemoB.Models.Domain.Sale
{
    public class SaleDBO : DBOBase
    {
        public int Id { get; set; }

        public int CarKey { get; set; }

        public int CustomerKey { get; set; }

        public int EmployeeKey { get; set; }

        public DateTime SalesDate { get; set; }

        public int FinalPrice { get; set; }

        public override void SetValuesFromObject(object obj)
        {
            Sale saleObj = (obj as Sale);
            if (saleObj == null)
            {
                throw new ArgumentException(nameof(SetValuesFromObject));
            }

            Id = saleObj.Key;
            CarKey = saleObj.CarKey;
            CustomerKey = saleObj.CustomerKey;
            EmployeeKey = saleObj.EmployeeKey;

            SalesDate = saleObj.SalesDate.DateTime;
            FinalPrice = saleObj.FinalPrice;
        }
    }
}