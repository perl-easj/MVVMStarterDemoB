using System;
using DBOImplementation;
using DBOInterfaces;

namespace MVVMStarterDemoB.Models.Domain.Sale
{
    public class SaleDBOFactory : DBOFactoryBase<Sale, SaleDBO>
    {
        public override Sale CreateT(IDBO obj)
        {
            SaleDBO dboObj = (obj as SaleDBO);
            if (dboObj == null)
            {
                throw new ArgumentException(nameof(SaleDBOFactory));
            }

            return new Sale(
                dboObj.Id,
                dboObj.CarKey,
                dboObj.CustomerKey,
                dboObj.EmployeeKey,
                dboObj.SalesDate,
                dboObj.FinalPrice);
        }
    }
}