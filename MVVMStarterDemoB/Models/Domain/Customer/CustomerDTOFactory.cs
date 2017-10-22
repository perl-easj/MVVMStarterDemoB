using System;
using DTO.Implementation;
using DTO.Interfaces;

namespace MVVMStarterDemoB.Models.Domain.Customer
{
    public class CustomerDTOFactory : DTOFactoryBase<Customer, CustomerDTO>
    {
        public override Customer CreateT(IDTO obj)
        {
            CustomerDTO dtoObj = (obj as CustomerDTO);
            if (dtoObj == null)
            {
                throw new ArgumentException(nameof(CustomerDTOFactory));
            }

            return new Customer(
                dtoObj.Key,
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