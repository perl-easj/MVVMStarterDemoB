using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Customer
{
    public class CustomerDTOFactory : FactoryBase<Models.Domain.Customer.Customer, CustomerDTO>
    {
        public override Models.Domain.Customer.Customer CreateDomainObject(CustomerDTO dtoObj)
        {
            return new Models.Domain.Customer.Customer(
                dtoObj.Id,
                dtoObj.ImageKey,
                dtoObj.FullName,
                dtoObj.Phone,
                dtoObj.Email,
                dtoObj.Address,
                dtoObj.ZipCode,
                dtoObj.City,
                dtoObj.MinPrice,
                dtoObj.MaxPrice,
                dtoObj.NewsLetter);
        }
    }
}