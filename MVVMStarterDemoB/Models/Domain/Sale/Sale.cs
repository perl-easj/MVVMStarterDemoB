using System;
using InMemoryStorage.Implementation;

namespace MVVMStarterDemoB.Models.Domain.Sale
{
    public class Sale : StorableBase
    {
        public Sale(int key, int carKey, int customerKey, int employeeKey, DateTimeOffset salesDate, int finalPrice)
            : base(key)
        {
            CarKey = carKey;
            CustomerKey = customerKey;
            EmployeeKey = employeeKey;

            SalesDate = salesDate;
            FinalPrice = finalPrice;
        }

        public int CarKey { get; set; }

        public int CustomerKey { get; set; }

        public int EmployeeKey { get; set; }

        public DateTimeOffset SalesDate { get; set; }

        public int FinalPrice { get; set; }
    }
}