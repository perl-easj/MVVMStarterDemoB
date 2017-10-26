using System;
using System.Collections.ObjectModel;
using DataTransformation.Interfaces;
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
            get { return TypedDataObject.SalesDate; }
            set
            {
                TypedDataObject.SalesDate = value;
                OnPropertyChanged();
            }
        }

        public string Header
        {
            get { return "Price for car is " + Price; }
        }
        public int Price
        {
            get { return TypedDataObject.FinalPrice; }
            set
            {
                TypedDataObject.FinalPrice = value;
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
            get { return GetCarItemViewModel(TypedDataObject.CarKey); }
            set
            {
                if (value != null)
                {
                    TypedDataObject.CarKey = value.TypedDataObject.Key;
                }
                OnPropertyChanged();
            }
        }

        public Customer.ItemViewModel SelectedCustomer
        {
            get { return GetCustomerItemViewModel(TypedDataObject.CustomerKey); }
            set
            {
                if (value != null)
                {
                    TypedDataObject.CustomerKey = value.TypedDataObject.Key;
                }
                OnPropertyChanged();
            }
        }

        public Employee.ItemViewModel SelectedEmployee
        {
            get { return GetEmployeeItemViewModel(TypedDataObject.EmployeeKey); }
            set
            {
                if (value != null)
                {
                    TypedDataObject.EmployeeKey = value.TypedDataObject.Key;
                }
                OnPropertyChanged();
            }
        }

        private Car.ItemViewModel GetCarItemViewModel(int key)
        {
            foreach (var carItemViewModel in _observableCollectionCars)
            {
                if (carItemViewModel.TypedDataObject.Key == key)
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
                if (customerItemViewModel.TypedDataObject.Key == key)
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
                if (employeeItemViewModel.TypedDataObject.Key == key)
                {
                    return employeeItemViewModel;
                }
            }

            return null;
        }

        public DetailsViewModel(ITransformedData obj) : base(obj)
        {
            _observableCollectionCars = new ObservableCollection<Car.ItemViewModel>();
            _observableCollectionCustomers = new ObservableCollection<Customer.ItemViewModel>();
            _observableCollectionEmployees = new ObservableCollection<Employee.ItemViewModel>();

            foreach (var carData in ObjectProvider.CarCatalog.AllTransformed)
            {
                _observableCollectionCars.Add(new Car.ItemViewModel(carData));
            }

            foreach (var customerData in ObjectProvider.CustomerCatalog.AllTransformed)
            {
                _observableCollectionCustomers.Add(new Customer.ItemViewModel(customerData));
            }

            foreach (var employeeData in ObjectProvider.EmployeeCatalog.AllTransformed)
            {
                _observableCollectionEmployees.Add(new Employee.ItemViewModel(employeeData));
            }
        }
    }
}