using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Customer
{
    public class CustomerViewModelFactory : FactoryBase<Models.Domain.Customer.Customer, CustomerViewModel>
    {
        public override Models.Domain.Customer.Customer CreateDomainObject(CustomerViewModel vmObj)
        {
            return new Models.Domain.Customer.Customer(
                vmObj.Key,
                vmObj.ImageKey,
                vmObj.FullName,
                vmObj.Phone,
                vmObj.Email,
                vmObj.Address,
                vmObj.ZipCode,
                vmObj.City,
                vmObj.MinPrice,
                vmObj.MaxPrice,
                vmObj.NewsLetter);
        }
    }
}