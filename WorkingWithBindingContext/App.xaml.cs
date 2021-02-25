using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingWithBindingContext
{
    public partial class App : Application
    {
       public static int pageNum = 0;
        public App()
        {
            InitializeComponent();

            MainPage =new NavigationPage(new MainPage());
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
