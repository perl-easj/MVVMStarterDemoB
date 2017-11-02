using System;
using System.Collections.ObjectModel;
using MVVMStarterDemoB.DataTransformations.Domain.Sale;
using MVVMStarterDemoB.Models.App;
using ViewModel.Implementation;

namespace MVVMStarterDemoB.ViewModels.Domain.Sale
{
    public class DetailsViewModel : DetailsViewModelBase<SaleViewModel>
    {
        private ObservableCollection<Car.ItemViewModel> _observableCollectionCars;
        private ObservableCollection<Customer.ItemViewModel> _observableCollectionCustomers;
        private ObservableCollection<Employee.ItemViewModel> _observableCollectionEmployees;

        public DateTimeOffset Date
        {
            get { return DataObject.SalesDate; }
            set
            {
                DataObject.SalesDate = value;
                OnPropertyChanged();
            }
        }

        public string Header
        {
            get { return "Price for car is " + Price; }
        }
        public int Price
        {
            get { return DataObject.FinalPrice; }
            set
            {
                DataObject.FinalPrice = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Header));
            }
        }

        public ObservableCollection<Car.ItemViewModel> CollectionCars
        {
            get { return _observableCollectionCars; }
        }

        public ObservableCollection<Customer.ItemViewModel> CollectionCustomers
        {
            get { return _observableCollectionCustomers; }
        }

        public ObservableCollection<Employee.ItemViewModel> CollectionEmployees
        {
            get { return _observableCollectionEmployees; }
        }

        public Car.ItemViewModel SelectedCar
        {
            get { return GetCarItemViewModel(DataObject.CarKey); }
            set
            {
                if (value != null)
                {
                    DataObject.CarKey = value.DataObject.Key;
                }
                OnPropertyChanged();
            }
        }

        public Customer.ItemViewModel SelectedCustomer
        {
            get { return GetCustomerItemViewModel(DataObject.CustomerKey); }
            set
            {
                if (value != null)
                {
                    DataObject.CustomerKey = value.DataObject.Key;
                }
                OnPropertyChanged();
            }
        }

        public Employee.ItemViewModel SelectedEmployee
        {
            get { return GetEmployeeItemViewModel(DataObject.EmployeeKey); }
            set
            {
                if (value != null)
                {
                    DataObject.EmployeeKey = value.DataObject.Key;
                }
                OnPropertyChanged();
            }
        }

        private Car.ItemViewModel GetCarItemViewModel(int key)
        {
            foreach (var carItemViewModel in _observableCollectionCars)
            {
                if (carItemViewModel.DataObject.Key == key)
                {
                    return carItemViewModel;
                }
            }

            return null;
        }

        private Customer.ItemViewModel GetCustomerItemViewModel(int key)
        {
            foreach (var customerItemViewModel in _observableCollectionCustomers)
            {
                if (customerItemViewModel.DataObject.Key == key)
                {
                    return customerItemViewModel;
                }
            }

            return null;
        }

        private Employee.ItemViewModel GetEmployeeItemViewModel(int key)
        {
            foreach (var employeeItemViewModel in _observableCollectionEmployees)
            {
                if (employeeItemViewModel.DataObject.Key == key)
                {
                    return employeeItemViewModel;
                }
            }

            return null;
        }

        public DetailsViewModel(SaleViewModel obj) : base(obj)
        {
            _observableCollectionCars = new ObservableCollection<Car.ItemViewModel>();
            _observableCollectionCustomers = new ObservableCollection<Customer.ItemViewModel>();
            _observableCollectionEmployees = new ObservableCollection<Employee.ItemViewModel>();

            foreach (var carData in ObjectProvider.CarCatalog.All)
            {
                _observableCollectionCars.Add(new Car.ItemViewModel(carData));
            }

            foreach (var customerData in ObjectProvider.CustomerCatalog.All)
            {
                _observableCollectionCustomers.Add(new Customer.ItemViewModel(customerData));
            }

            foreach (var employeeData in ObjectProvider.EmployeeCatalog.All)
            {
                _observableCollectionEmployees.Add(new Employee.ItemViewModel(employeeData));
            }
        }
    }
}