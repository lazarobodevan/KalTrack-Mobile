using KalTrack.ViewModel;
using Refractored.FabControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KalTrack.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage {

        public HomePage() {

            InitializeComponent();

            /*
            FabClicked += OnFabClicked;
            
            FABAdd.Clicked = (sender, args) => {
                //Raising the event here and passing sender and event arguments on
                FabClicked(sender, args);
            };
            */
        }

        /*
        private event EventHandler FabClicked = delegate { };

        private async void OnFabClicked(object sender, EventArgs args) {
            if (!FABAdd.IsVisible)
                await ((FloatingActionButtonView)sender).ScaleTo(1, 50, Easing.Linear);
        }

        */
    }
}