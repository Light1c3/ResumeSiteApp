using ResumeApp.Pages;
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
            AppNavigationMenuItem aboutPage = new AppNavigationMenuItem { Id = 1, Title = "About", TargetType = typeof(AboutPage) };
            await Navigation.PushModalAsync(new AppNavigation(aboutPage));
        }

        private async void btnResume_Clicked(object sender, EventArgs e)
        {
            AppNavigationMenuItem resumePage = new AppNavigationMenuItem { Id = 1, Title = "Resume", TargetType = typeof(ResumePage) };
            await Navigation.PushModalAsync(new AppNavigation(resumePage));
        }

        private async void btnPortfolio_Clicked(object sender, EventArgs e)
        {
            AppNavigationMenuItem portfolioPage = new AppNavigationMenuItem { Id = 1, Title = "Portfolio", TargetType = typeof(PortfolioPage) };
            await Navigation.PushModalAsync(new AppNavigation(portfolioPage));
        }

        private async void btnContact_Clicked(object sender, EventArgs e)
        {
            AppNavigationMenuItem contactPage = new AppNavigationMenuItem { Id = 1, Title = "Contact", TargetType = typeof(ContactPage) };
            await Navigation.PushModalAsync(new AppNavigation(contactPage));
        }
    }
}
