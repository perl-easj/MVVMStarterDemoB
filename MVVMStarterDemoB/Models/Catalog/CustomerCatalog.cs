using MVVMStarterDemoB.DataTransformations.PersistentData;
using MVVMStarterDemoB.DataTransformations.ViewData;
using MVVMStarterDemoB.Models.Base;

namespace MVVMStarterDemoB.Models.Catalog
{
    public class CustomerCatalog : CatalogAppBase<Data.Domain.Customer, CustomerViewData, CustomerPersistentData>
    {
        public CustomerCatalog() : base("Customers")
        {
        }

        public override Data.Domain.Customer CreateDomainObjectFromViewDataObject(CustomerViewData vdObj)
        {
            return new Data.Domain.Customer
            (
                vdObj.Key,
                vdObj.ImageKey,
                vdObj.FullName,
                vdObj.Phone,
                vdObj.Email,
                vdObj.Address,
                vdObj.ZipCode,
                vdObj.City,
                vdObj.MinPrice,
                vdObj.MaxPrice,
                vdObj.NewsLetter
            );
        }

        public override CustomerViewData CreateViewDataObject(Data.Domain.Customer obj)
        {
            return new CustomerViewData
            {
                Key = obj.Key,
                ImageKey = obj.ImageKey,
                FullName = obj.FullName,
                Phone = obj.Phone,
                Email = obj.Email,
                Address = obj.Address,
                ZipCode = obj.ZipCode,
                City = obj.City,
                MinPrice = obj.MinPrice,
                MaxPrice = obj.MaxPrice,
                NewsLetter = obj.NewsLetter
            };
        }

        public override CustomerPersistentData CreatePersistentDataObject(Data.Domain.Customer obj)
        {
            return new CustomerPersistentData
            {
                Id = obj.Key,
                Key = obj.Key,
                ImageKey = obj.ImageKey,
                FullName = obj.FullName,
                Phone = obj.Phone,
                Email = obj.Email,
                Address = obj.Address,
                ZipCode = obj.ZipCode,
                City = obj.City,
                MinPrice = obj.MinPrice,
                MaxPrice = obj.MaxPrice,
                NewsLetter  = obj.NewsLetter
            };
        }

        public override Data.Domain.Customer CreateDomainObjectFromPersistentDataObject(CustomerPersistentData pdObj)
        {
            return new Data.Domain.Customer
            (
                pdObj.Key,
                pdObj.ImageKey,
                pdObj.FullName,
                pdObj.Phone,
                pdObj.Email,
                pdObj.Address,
                pdObj.ZipCode,
                pdObj.City,
                pdObj.MinPrice,
                pdObj.MaxPrice,
                pdObj.NewsLetter
            );
        }
    }
}