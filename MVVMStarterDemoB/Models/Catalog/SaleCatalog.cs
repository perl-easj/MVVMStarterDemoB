using MVVMStarterDemoB.DataTransformations.PersistentData;
using MVVMStarterDemoB.DataTransformations.ViewData;
using MVVMStarterDemoB.Models.Base;

namespace MVVMStarterDemoB.Models.Catalog
{
    public class SaleCatalog : CatalogAppBase<Data.Domain.Sale, SaleViewData, SalePersistentData>
    {
        public SaleCatalog() : base("Sales")
        {
        }

        public override Data.Domain.Sale CreateDomainObjectFromViewDataObject(SaleViewData vdObj)
        {
            return new Data.Domain.Sale
            (
                vdObj.Key,
                vdObj.CarKey,
                vdObj.CustomerKey,
                vdObj.EmployeeKey,
                vdObj.SalesDate,
                vdObj.FinalPrice
            );
        }

        public override SaleViewData CreateViewDataObject(Data.Domain.Sale obj)
        {
            return new SaleViewData
            {
                Key = obj.Key,
                CarKey = obj.CarKey,
                CustomerKey = obj.CustomerKey,
                EmployeeKey = obj.EmployeeKey,
                SalesDate = obj.SalesDate,
                FinalPrice = obj.FinalPrice
            };
        }

        public override SalePersistentData CreatePersistentDataObject(Data.Domain.Sale obj)
        {
            return new SalePersistentData
            {
                Key = obj.Key,
                CarKey = obj.CarKey,
                CustomerKey = obj.CustomerKey,
                EmployeeKey = obj.EmployeeKey,
                SalesDate = obj.SalesDate,
                FinalPrice = obj.FinalPrice
            };
        }

        public override Data.Domain.Sale CreateDomainObjectFromPersistentDataObject(SalePersistentData pdObj)
        {
            return new Data.Domain.Sale
            (
                pdObj.Key,
                pdObj.CarKey,
                pdObj.CustomerKey,
                pdObj.EmployeeKey,
                pdObj.SalesDate,
                pdObj.FinalPrice
            );
        }
    }
}