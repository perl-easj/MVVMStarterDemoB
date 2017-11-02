using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Sale
{
    public class SaleDTOFactory : FactoryBase<Models.Domain.Sale.Sale, SaleDTO>
    {
        public override Models.Domain.Sale.Sale CreateDomainObject(SaleDTO dtoObj)
        {
            return new Models.Domain.Sale.Sale(
                dtoObj.Id,
                dtoObj.CarKey,
                dtoObj.CustomerKey,
                dtoObj.EmployeeKey,
                dtoObj.SalesDate,
                dtoObj.FinalPrice);
        }
    }
}