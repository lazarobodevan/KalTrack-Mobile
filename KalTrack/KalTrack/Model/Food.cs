using System;
using System.Collections.Generic;
using System.Text;
using KalTrack.Model;
namespace KalTrack.Model {
    public class Food {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public int DefaultCalories { get; set; }
        public string Icon { get; set; }
        public string MealType { get; set; }


        public void SetDefaultCalories(int calories) {
            this.DefaultCalories = calories;
        }

    }
}
