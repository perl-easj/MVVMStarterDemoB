using System;
using DBOInterfaces;
using DBOImplementation;

namespace MVVMStarterDemoB.Models.Domain.Customer
{
    public class CustomerDBOFactory : DBOFactoryBase<Customer, CustomerDBO>
    {
        public override Customer CreateT(IDBO obj)
        {
            CustomerDBO dboObj = (obj as CustomerDBO);
            if (dboObj == null)
            {
                throw new ArgumentException(nameof(CustomerDBOFactory));
            }

            return new Customer(
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