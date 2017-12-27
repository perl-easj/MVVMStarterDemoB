using System;
using Data.InMemory.Implementation;

namespace MVVMStarterDemoB.Data.Domain
{
    public class Sale : StorableBase
    {
        public Sale(int key, int carKey, int customerKey, int employeeKey, DateTime salesDate, int finalPrice)
            : base(key)
        {
            CarKey = carKey;
            CustomerKey = customerKey;
            EmployeeKey = employeeKey;

            SalesDate = salesDate;
            FinalPrice = finalPrice;
        }

        public Sale() : base(NullKey)
        {
        }

        public int CarKey { get; set; }
        public int CustomerKey { get; set; }
        public int EmployeeKey { get; set; }
        public DateTime SalesDate { get; set; }
        public int FinalPrice { get; set; }
    }
}