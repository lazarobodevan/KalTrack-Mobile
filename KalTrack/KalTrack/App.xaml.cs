using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KalTrack.View;

namespace KalTrack {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            SetValue(NavigationPage.HasNavigationBarProperty, false);
        }

        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}
