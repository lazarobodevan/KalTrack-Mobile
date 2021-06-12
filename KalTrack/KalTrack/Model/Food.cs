using System;
using System.Collections.Generic;
using System.Text;
using KalTrack.Model;
namespace KalTrack.Model {
    public class Food {
        private int Id;
        private string Name;
        private int Calories;
        private int DefaultCalories;
        private string Icon;
        private MealType MealType;
        public Food(int id, string name, int calories, string icon, MealType mealType) {
            this.Id = id;
            this.Name = name;
            this.Calories = calories;
            this.DefaultCalories = 0;
            this.Icon = icon;
            this.MealType = mealType;
        }

        public Food(int id, string name, int calories, int defaultCalories, string icon, MealType mealType) {
            this.Id = id;
            this.Name = name;
            this.Calories = calories;
            this.DefaultCalories = defaultCalories;
            this.Icon = icon;
            this.MealType = mealType;
        }

        public int GetId() {
            return this.Id;
        }

        public string GetName() {
            return this.Name;
        }

        public int GetCalories() {
            return this.Calories;
        }

        public string GetIcon() {
            return this.Icon;
        }

        public MealType GetMealType() {
            return this.MealType;
        }

        public void SetDefaultCalories(int calories) {
            this.DefaultCalories = calories;
        }

    }
}
