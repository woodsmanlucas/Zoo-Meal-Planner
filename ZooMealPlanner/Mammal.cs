using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    class Mammal
    {
        public virtual double ServingWeightRatio { get; protected set; }
        public virtual string FoodPreference { get; protected set; }
        public virtual string FeedTime { get; protected set; }
        public virtual double weight { get; set; }
        public virtual string type { get; set; }
        public virtual string species { get; set; }

        public void PrintNutritionInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Meal Recommendation");
            Console.WriteLine("--------------------");
            Console.WriteLine($"Mammal Type: {type}");
            Console.WriteLine($"Species: {species}");
            Console.WriteLine($"Weight: {weight}KG");
            Console.WriteLine($"Serving: {ServingWeightRatio*weight}KG {FoodPreference}");
            Console.WriteLine("Instructions: Keep Animal Secure at all times");
            Console.WriteLine($"              Feed At {FeedTime}");
        }
    }
}
