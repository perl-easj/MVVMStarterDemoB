using ExtensionsModel.Implementation;
using MVVMStarterDemoB.Configuration.App;
using MVVMStarterDemoB.DataTransformations.Domain.Customer;

namespace MVVMStarterDemoB.Models.Domain.Customer
{
    public class CustomerCatalog : WebAPIPersistableCatalog<Customer, CustomerVMO, CustomerDTO>
    {
        #region Model Singleton implementation
        private static CustomerCatalog _instance;

        public static CustomerCatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new CustomerCatalog();
                return _instance;
            }
        }

        private CustomerCatalog() : base(AppConfig.ServerURL, "Customers")
        {
        }
        #endregion

        #region Data transformation
        public override Customer CreateDomainObjectFromDTO(CustomerDTO dtoObj)
        {
            return new Customer(
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

        public override CustomerDTO CreateDTO(Customer obj)
        {
            CustomerDTO dtoObj = new CustomerDTO();

            dtoObj.Id = obj.Key;
            dtoObj.FullName = obj.FullName;
            dtoObj.Phone = obj.Phone;
            dtoObj.Email = obj.Email;
            dtoObj.Address = obj.Address;
            dtoObj.ZipCode = obj.ZipCode;
            dtoObj.City = obj.City;
            dtoObj.MinPrice = obj.MinPrice;
            dtoObj.MaxPrice = obj.MaxPrice;
            dtoObj.NewsLetter = obj.NewsLetter;
            dtoObj.ImageKey = obj.ImageKey;

            return dtoObj;
        }

        public override Customer CreateDomainObjectFromVMO(CustomerVMO vmObj)
        {
            return new Customer(
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

        public override CustomerVMO CreateVMO(Customer obj)
        {
            CustomerVMO vmoObj = new CustomerVMO();

            vmoObj.Key = obj.Key;
            vmoObj.FullName = obj.FullName;
            vmoObj.Phone = obj.Phone;
            vmoObj.Email = obj.Email;
            vmoObj.Address = obj.Address;
            vmoObj.ZipCode = obj.ZipCode;
            vmoObj.City = obj.City;
            vmoObj.MinPrice = obj.MinPrice;
            vmoObj.MaxPrice = obj.MaxPrice;
            vmoObj.NewsLetter = obj.NewsLetter;
            vmoObj.ImageKey = obj.ImageKey;

            return vmoObj;
        } 
        #endregion
    }
}