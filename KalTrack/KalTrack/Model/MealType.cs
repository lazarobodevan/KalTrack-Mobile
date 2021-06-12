using System;
using System.Collections.Generic;
using System.Text;

namespace KalTrack.Model {
    
    /*-----This class works like an enum class
      -----I decided to make this so I can return
      -----a string related to my 'enum type' */
    
    public class MealType {
        public string value;
        private MealType(string value) {
            this.value = value;
        }

        public static MealType Breakfast { get => new MealType("Café da manhã"); }
        public static MealType Collation { get => new MealType("Colação"); }
        public static MealType Lunch { get => new MealType("Colação"); }
        public static MealType Aft_Coffee_break { get => new MealType("Café da tarde"); }
        public static MealType Dinner { get => new MealType("Janta"); }
        public static MealType Supper { get => new MealType("Ceia"); }
    }
}
