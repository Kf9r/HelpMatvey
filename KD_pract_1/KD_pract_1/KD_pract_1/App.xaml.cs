using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KD_pract_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Page1();
            MainPage = new StartPage();
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
