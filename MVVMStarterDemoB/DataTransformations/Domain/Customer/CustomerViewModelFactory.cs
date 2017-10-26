using System;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;

namespace MVVMStarterDemoB.DataTransformations.Domain.Customer
{
    public class CustomerViewModelFactory : TransformedDataFactoryBase<Models.Domain.Customer.Customer, CustomerViewModel>
    {
        public override Models.Domain.Customer.Customer CreateDomainObject(ITransformedData tObj)
        {
            CustomerViewModel vmObj = (tObj as CustomerViewModel);
            if (vmObj == null)
            {
                throw new ArgumentException(nameof(CustomerViewModelFactory));
            }

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