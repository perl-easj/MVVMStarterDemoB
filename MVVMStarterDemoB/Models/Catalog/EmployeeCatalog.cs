using MVVMStarterDemoB.DataTransformations.PersistentData;
using MVVMStarterDemoB.DataTransformations.ViewData;
using MVVMStarterDemoB.Models.Base;

namespace MVVMStarterDemoB.Models.Catalog
{
    public class EmployeeCatalog : CatalogAppBase<Data.Domain.Employee, EmployeeViewData, EmployeePersistentData>
    {
        public EmployeeCatalog() : base("Employees")
        {
        }

        public override Data.Domain.Employee CreateDomainObjectFromViewDataObject(EmployeeViewData vdObj)
        {
            return new Data.Domain.Employee
            (
                vdObj.Key,
                vdObj.ImageKey,
                vdObj.FullName,
                vdObj.Phone,
                vdObj.Email,
                vdObj.Title,
                vdObj.EmployedDate
            );
        }

        public override EmployeeViewData CreateViewDataObject(Data.Domain.Employee obj)
        {
            return new EmployeeViewData
            {
                Key = obj.Key,
                ImageKey = obj.ImageKey,
                FullName = obj.FullName,
                Phone = obj.Phone,
                Email = obj.Email,
                Title = obj.Title,
                EmployedDate = obj.EmployedDate
            };
        }

        public override EmployeePersistentData CreatePersistentDataObject(Data.Domain.Employee obj)
        {
            return new EmployeePersistentData
            {
                Key = obj.Key,
                ImageKey = obj.ImageKey,
                FullName = obj.FullName,
                Phone = obj.Phone,
                Email = obj.Email,
                Title = obj.Title,
                EmployedDate = obj.EmployedDate
            };
        }

        public override Data.Domain.Employee CreateDomainObjectFromPersistentDataObject(EmployeePersistentData pdObj)
        {
            return new Data.Domain.Employee
            (
                pdObj.Key,
                pdObj.ImageKey,
                pdObj.FullName,
                pdObj.Phone,
                pdObj.Email,
                pdObj.Title,
                pdObj.EmployedDate
            );
        }
    }
}