using Sharing.Services;
using Sharing.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sharing
{
    public partial class App : Application
    {

        public App() 
        {
            InitializeComponent();


            DependencyService.Register<ILoginService,loginService>();
            MainPage = new NavigationPage(new LoginPage2()); 
            
            //  DependencyService.Register<MockDataStore>();
           // MainPage = new AppShell(); 
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
