using KalTrack.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace KalTrack.ViewModel {
    public class HomePageVM :BindableObject{
        public HomePageVM() {
            NavBack = new Command(Nav_Back);
            NavFourth = new Command(Nav_Fourth);
            GetListOfFood();
            Visibility = new Command(HandleFABOpenClose);
        }
        public ICommand NavBack { get; }
        public ICommand NavFourth { get; }

        public List<Food> Foods { get; private set; }

        public ICommand Visibility { get; }


        string monthText = DateTime.UtcNow.ToString("MMMM/yyyy");

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

        bool isOpen = false;
        public bool IsOpen {
            get => isOpen;
            set {
                isOpen = value;
                OnPropertyChanged();
            }
        }

        int motion = 0;
        public int Motion {
            get => motion;
            set {
                motion = value;
                OnPropertyChanged();
            }
        }


      

        void Nav_Back() {
            MonthText = DateTime.Parse(MonthText).AddMonths(-1).ToString("MMMM/yyyy");
        }

        void Nav_Fourth() {
            MonthText = DateTime.Parse(MonthText).AddMonths(1).ToString("MMMM/yyyy");
        }


        public List<Food> GetListOfFood() {
            Foods = new List<Food>();
            Foods.Add(new Food { Id = 1, Calories = 30, MealType = MealType.Breakfast.value});
            Foods.Add(new Food { Id = 1, Calories = 30, MealType = MealType.Breakfast.value });
            Foods.Add(new Food { Id = 1, Calories = 30, MealType = MealType.Breakfast.value });
            Foods.Add(new Food { Id = 1, Calories = 30, MealType = MealType.Breakfast.value });

            return Foods;
        }


        void HandleFABOpenClose() {
            if (IsOpen==false) {
                IsOpen = true;

            } else {
                IsOpen = false;
            }
        }
    }
}
