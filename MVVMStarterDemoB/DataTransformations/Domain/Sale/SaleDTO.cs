using System;
using InMemoryStorage.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Sale
{
    public class SaleDTO : CopyableBase
    {
        public int Id { get; set; }

        public int CarKey { get; set; }

        public int CustomerKey { get; set; }

        public int EmployeeKey { get; set; }

        public DateTime SalesDate { get; set; }

        public int FinalPrice { get; set; }
    }
}