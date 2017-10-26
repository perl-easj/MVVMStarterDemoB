using System;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;

namespace MVVMStarterDemoB.DataTransformations.Domain.Customer
{
    public class CustomerDTOFactory : TransformedDataFactoryBase<Models.Domain.Customer.Customer, CustomerDTO>
    {
        public override Models.Domain.Customer.Customer CreateDomainObject(ITransformedData obj)
        {
            CustomerDTO dboObj = (obj as CustomerDTO);
            if (dboObj == null)
            {
                throw new ArgumentException(nameof(CustomerDTOFactory));
            }

            return new Models.Domain.Customer.Customer(
                dboObj.Id,
                dboObj.ImageKey,
                dboObj.FullName,
                dboObj.Phone,
                dboObj.Email,
                dboObj.Address,
                dboObj.ZipCode,
                dboObj.City,
                dboObj.MinPrice,
                dboObj.MaxPrice,
                dboObj.NewsLetter);
        }
    }
}