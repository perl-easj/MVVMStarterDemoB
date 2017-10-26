﻿using ExtensionsModel.Implementation;
using MVVMStarterDemoB.Configuration.App;
using MVVMStarterDemoB.DataTransformations.Domain.Employee;
using MVVMStarterDemoB.ViewModels.Domain.Employee;

namespace MVVMStarterDemoB.Models.Domain.Employee
{
    public class EmployeeCatalog : WebAPIPersistableCatalog<Employee, EmployeeDTO>
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

        private EmployeeCatalog() : base(AppConfig.ServerURL, "Employees", new EmployeeViewModelFactory(), new EmployeeDTOFactory())
        {
        }
        #endregion
    }
}