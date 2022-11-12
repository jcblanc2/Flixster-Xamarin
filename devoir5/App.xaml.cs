using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/// <summary>
/// Name: John Clayton Blanc
/// Date: 11/11/2022
/// Course: C#
/// </summary>

namespace devoir5
{

    public partial class App : Application
    {
        public App()
        {
             InitializeComponent();
            MainPage = new MainPage();
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
