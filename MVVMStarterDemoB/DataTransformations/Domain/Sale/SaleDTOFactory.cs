using System;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;

namespace MVVMStarterDemoB.DataTransformations.Domain.Sale
{
    public class SaleDTOFactory : TransformedDataFactoryBase<Models.Domain.Sale.Sale, SaleDTO>
    {
        public override Models.Domain.Sale.Sale CreateDomainObject(ITransformedData obj)
        {
            SaleDTO dboObj = (obj as SaleDTO);
            if (dboObj == null)
            {
                throw new ArgumentException(nameof(SaleDTOFactory));
            }

            return new Models.Domain.Sale.Sale(
                dboObj.Id,
                dboObj.CarKey,
                dboObj.CustomerKey,
                dboObj.EmployeeKey,
                dboObj.SalesDate,
                dboObj.FinalPrice);
        }
    }
}