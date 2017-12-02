using ExtensionsModel.Implementation;
using MVVMStarterDemoB.Configuration.App;
using MVVMStarterDemoB.DataTransformations.Domain.Sale;

namespace MVVMStarterDemoB.Models.Domain.Sale
{
    public class SaleCatalog : WebAPIPersistableCatalog<Sale, SaleVMO, SaleDTO>
    {
        #region Model Singleton implementation
        private static SaleCatalog _instance;

        public static SaleCatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new SaleCatalog();
                return _instance;
            }
        }

        private SaleCatalog() : base(AppConfig.ServerURL, "Sales")
        {
        }
        #endregion

        #region Data transformations
        public override Sale CreateDomainObjectFromDTO(SaleDTO dtoObj)
        {
            return new Sale(
                dtoObj.Id,
                dtoObj.CarKey,
                dtoObj.CustomerKey,
                dtoObj.EmployeeKey,
                dtoObj.SalesDate,
                dtoObj.FinalPrice);
        }

        public override SaleDTO CreateDTO(Sale obj)
        {
            SaleDTO dtoObj = new SaleDTO();

            dtoObj.Id = obj.Key;
            dtoObj.CarKey = obj.CarKey;
            dtoObj.CustomerKey = obj.CustomerKey;
            dtoObj.EmployeeKey = obj.EmployeeKey;

            dtoObj.SalesDate = obj.SalesDate.DateTime;
            dtoObj.FinalPrice = obj.FinalPrice;

            return null;
        }

        public override Sale CreateDomainObjectFromVMO(SaleVMO vmObj)
        {
            return new Sale(
                vmObj.Key,
                vmObj.CarKey,
                vmObj.CustomerKey,
                vmObj.EmployeeKey,
                vmObj.SalesDate,
                vmObj.FinalPrice);
        }

        public override SaleVMO CreateVMO(Sale obj)
        {
            SaleVMO vmObj = new SaleVMO();

            vmObj.Key = obj.Key;
            vmObj.CarKey = obj.CarKey;
            vmObj.CustomerKey = obj.CustomerKey;
            vmObj.EmployeeKey = obj.EmployeeKey;

            vmObj.SalesDate = obj.SalesDate;
            vmObj.FinalPrice = obj.FinalPrice;

            return vmObj;
        } 
        #endregion

        public int CarsSoldByEmployee(int employeeKey)
        {
            return All.FindAll(obj => obj.EmployeeKey == employeeKey).Count;
        }
    }
}