using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace KalTrack.ViewModel {
    public class HomePageVM :BindableObject{
        public HomePageVM() {
            NavBack = new Command(Nav_Back);
            NavFourth = new Command(Nav_Fourth);
        }
        public ICommand NavBack { get; }
        public ICommand NavFourth { get; }

        string monthText = DateTime.UtcNow.ToString("dd/MMMM");

        public string MonthText {
            get => monthText;

            set {
                monthText = value;
                OnPropertyChanged();
            }

        }

        void Nav_Back() {
            MonthText = DateTime.Parse(MonthText).AddMonths(-1).ToString("dd/MMMM");
        }

        void Nav_Fourth() {
            MonthText = DateTime.Parse(MonthText).AddMonths(1).ToString("dd/MMMM");
        }

    }
}
