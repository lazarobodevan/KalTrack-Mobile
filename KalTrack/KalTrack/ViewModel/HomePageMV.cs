using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using KalTrack.View;
using Xamarin.Forms;

namespace KalTrack.ViewModel {

    public class HomePageMV : INotifyPropertyChanged {
        
        public HomePageMV() {

        }

        public string getNowDate() {
            return DateTime.UtcNow.ToString("dd/MMMM");
        }


        





        public event PropertyChangedEventHandler PropertyChanged;
    }
}
