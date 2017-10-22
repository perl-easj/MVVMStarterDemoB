using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Command.Implementation;
using MVVMStarterDemoB.Configuration.App;
using Persistency.Implementation;
using UI.Implementation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MVVMStarterDemoB.Views.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            AppConfig.Setup();
            AppFrame.Navigate(typeof(OpeningView));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            AppSplitView.IsPaneOpen = !AppSplitView.IsPaneOpen;
        }

        private async void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CarView.IsSelected)
            {
                TryNavigate(typeof(Domain.Car.View), "CarView");
            }
            if (CustomerView.IsSelected)
            {
                TryNavigate(typeof(Domain.Customer.View), "CustomerView");
            }
            if (EmployeeView.IsSelected)
            {
                TryNavigate(typeof(Domain.Employee.View), "EmployeeView");
            }
            if (SaleView.IsSelected)
            {
                TryNavigate(typeof(Domain.Sale.View), "SaleView");
            }
            if (ImageView.IsSelected)
            {
                AppFrame.Navigate(typeof(ImageView));
            }
            if (Load.IsSelected)
            {
                AppFrame.Navigate(typeof(OpeningView));
                await UIService.PresentMessageSingleActionCancel("Are you sure you want to LOAD model data?", "LOAD", new RelayCommand(PersistencyManager.Load));
            }
            if (Quit.IsSelected)
            {
                AppFrame.Navigate(typeof(OpeningView));
                await UIService.PresentMessageSingleActionCancel("Are you sure you want to QUIT?", "QUIT", new RelayCommand(Application.Current.Exit));
            }
        }

        private void TryNavigate(System.Type viewType, string viewName)
        {
            if (true) // Replace if you want to use login-based access restrictions
            {
                AppFrame.Navigate(viewType);
            }
            else
            {
                // Inform user about insufficient access rights
            }
        }
    }
}
