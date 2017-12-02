using ExtensionsModel.Implementation;
using MVVMStarterDemoB.Configuration.App;
using MVVMStarterDemoB.DataTransformations.Domain.Employee;

namespace MVVMStarterDemoB.Models.Domain.Employee
{
    public class EmployeeCatalog : WebAPIPersistableCatalog<Employee, EmployeeVMO, EmployeeDTO>
    {
        #region Model Singleton implementation
        private static EmployeeCatalog _instance;

        public static EmployeeCatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new EmployeeCatalog();
                return _instance;
            }
        }

        private EmployeeCatalog() : base(AppConfig.ServerURL, "Employees")
        {
        }
        #endregion

        #region Data transformation
        public override Employee CreateDomainObjectFromDTO(EmployeeDTO dtoObj)
        {
            return new Employee(
                dtoObj.Id,
                dtoObj.ImageKey,
                dtoObj.FullName,
                dtoObj.Phone,
                dtoObj.Email,
                dtoObj.Title,
                dtoObj.EmployedDate);
        }

        public override EmployeeDTO CreateDTO(Employee obj)
        {
            EmployeeDTO dtoObj = new EmployeeDTO();

            dtoObj.Id = obj.Key;
            dtoObj.FullName = obj.FullName;
            dtoObj.Phone = obj.Phone;
            dtoObj.Email = obj.Email;
            dtoObj.Title = obj.Title;
            dtoObj.EmployedDate = obj.EmployedDate.DateTime;
            dtoObj.ImageKey = obj.ImageKey;
            dtoObj.CarsSold = obj.CarsSold;

            return dtoObj;
        }

        public override Employee CreateDomainObjectFromVMO(EmployeeVMO vmObj)
        {
            return new Employee(
                vmObj.Key,
                vmObj.ImageKey,
                vmObj.FullName,
                vmObj.Phone,
                vmObj.Email,
                vmObj.Title,
                vmObj.EmployedDate);
        }

        public override EmployeeVMO CreateVMO(Employee obj)
        {
            EmployeeVMO vmoObj = new EmployeeVMO();

            vmoObj.Key = obj.Key;
            vmoObj.FullName = obj.FullName;
            vmoObj.Phone = obj.Phone;
            vmoObj.Email = obj.Email;
            vmoObj.Title = obj.Title;
            vmoObj.EmployedDate = obj.EmployedDate;
            vmoObj.ImageKey = obj.ImageKey;

            return null;
        } 
        #endregion
    }
}