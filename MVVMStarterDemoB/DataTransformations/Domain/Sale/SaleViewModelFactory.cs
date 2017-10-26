using System;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;

namespace MVVMStarterDemoB.DataTransformations.Domain.Sale
{
    public class SaleViewModelFactory : TransformedDataFactoryBase<Models.Domain.Sale.Sale, SaleViewModel>
    {
        public override Models.Domain.Sale.Sale CreateDomainObject(ITransformedData tObj)
        {
            SaleViewModel vmObj = (tObj as SaleViewModel);
            if (vmObj == null)
            {
                throw new ArgumentException(nameof(SaleViewModelFactory));
            }

            return new Models.Domain.Sale.Sale(
                vmObj.Key,
                vmObj.CarKey,
                vmObj.CustomerKey,
                vmObj.EmployeeKey,
                vmObj.SalesDate,
                vmObj.FinalPrice);
        }
    }
}