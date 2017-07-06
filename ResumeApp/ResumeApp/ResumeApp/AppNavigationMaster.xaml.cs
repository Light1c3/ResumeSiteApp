using ResumeApp.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResumeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppNavigationMaster : ContentPage
    {
        public ListView ListView => ListViewMenuItems;

        public AppNavigationMaster()
        {
            InitializeComponent();
            BindingContext = new AppNavigationMasterViewModel();
        }



        class AppNavigationMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<AppNavigationMenuItem> MenuItems { get; }
            public AppNavigationMasterViewModel()
            {
                MenuItems = new ObservableCollection<AppNavigationMenuItem>(new[]
                {
                    new AppNavigationMenuItem { Id = 0, Title = "Home", TargetType = typeof (MainPage) },
                    new AppNavigationMenuItem { Id = 1, Title = "About", TargetType = typeof (AboutPage) },
                    new AppNavigationMenuItem { Id = 2, Title = "Resume", TargetType = typeof (ResumePage) },
                    new AppNavigationMenuItem { Id = 3, Title = "Portfolio", TargetType = typeof (PortfolioPage) },
                    new AppNavigationMenuItem { Id = 4, Title = "Contact", TargetType = typeof (ContactPage) },
                });
            }
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }
    }
}
