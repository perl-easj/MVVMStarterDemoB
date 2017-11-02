using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Sale
{
    public class SaleViewModelFactory : FactoryBase<Models.Domain.Sale.Sale, SaleViewModel>
    {
        public override Models.Domain.Sale.Sale CreateDomainObject(SaleViewModel vmObj)
        {
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