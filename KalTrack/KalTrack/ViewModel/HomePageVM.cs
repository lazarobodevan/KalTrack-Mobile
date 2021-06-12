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
            NavHome = new Command(Nav_Home);
            NavChart = new Command(Nav_Chart);
            NavCalendar = new Command(Nav_Calendar);
            NavOptions = new Command(Nav_Options);
        }
        public ICommand NavBack { get; }
        public ICommand NavFourth { get; }
        public ICommand NavHome { get; }
        public ICommand NavChart { get; }
        public ICommand NavCalendar { get; }
        public ICommand NavOptions { get; }

        string monthText = DateTime.UtcNow.ToString("dd/MMMM");

        public string MonthText {
            get => monthText;

            set {
                monthText = value;
                OnPropertyChanged();
            }

        }

        string txt = "Home";
        public string lblTxt {
            get => txt;
            set {
                txt = value;
                OnPropertyChanged();
            }
        }

        void Nav_Back() {
            MonthText = DateTime.Parse(MonthText).AddMonths(-1).ToString("dd/MMMM");
        }

        void Nav_Fourth() {
            MonthText = DateTime.Parse(MonthText).AddMonths(1).ToString("dd/MMMM");
        }

        void Nav_Home() {
            lblTxt = "Home";
        }
        void Nav_Chart() {
            lblTxt = "Chart";
        }
        void Nav_Calendar() {
            lblTxt = "Calendar";
        }
        void Nav_Options() {
            lblTxt = "Options";
        }
    }
}
