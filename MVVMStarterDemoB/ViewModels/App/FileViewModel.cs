using Windows.UI.Xaml;
using AddOns.UI.Implementation;
using Commands.Implementation;
using MVVMStarterDemoB.Models.App;
using ViewModel.App.Implementation;

namespace MVVMStarterDemoB.ViewModels.App
{
    public class FileViewModel : AppViewModelBase
    {
        public FileViewModel()
        {
            AddCommands();
        }

        public override void AddCommands()
        {
            NavigationCommands.Add("Load", new RelayCommand(async () =>
            {
                await UIService.PresentMessageSingleActionCancel("Are you sure you want to LOAD model data?", "LOAD", new RelayCommand(DomainModel.Catalogs.Load));
            }));

            NavigationCommands.Add("Save", new RelayCommand(async () =>
            {
                await UIService.PresentMessageSingleActionCancel("Are you sure you want to SAVE model data?", "SAVE", new RelayCommand(DomainModel.Catalogs.Save));
            }));

            NavigationCommands.Add("Quit", new RelayCommand(async () =>
            {
                await UIService.PresentMessageSingleActionCancel("Are you sure you want to QUIT?", "QUIT", new RelayCommand(Application.Current.Exit));
            }));
        }
    }
}