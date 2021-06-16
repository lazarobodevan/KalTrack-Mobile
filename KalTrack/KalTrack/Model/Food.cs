using System;
using System.Collections.Generic;
using System.Text;
using KalTrack.Model;
using KalTrack.ViewModel;

namespace KalTrack.Model {
    public class Food {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public int DefaultCalories { get; set; }
        public string Icon { get; set; }
        public string MealType { get; set; }
        //Temporario
        public string Date { get; set; }


        public Food() {
            this.Date = DateTime.UtcNow.ToString("MMMM/yyyy");
        }

        public void SetDefaultCalories(int calories) {
            this.DefaultCalories = calories;
        }

    }
}
