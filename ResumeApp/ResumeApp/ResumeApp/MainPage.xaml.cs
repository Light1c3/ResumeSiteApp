using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ResumeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
        }

        private async void btnAbout_Clicked(object sender, EventArgs e)
        {
            AppNavigationMenuItem pageItem = new AppNavigationMenuItem { Id = 1, Title = "About", TargetType = typeof(AboutPage) };
            await Navigation.PushModalAsync(new AppNavigation(pageItem));
        }
    }
}
