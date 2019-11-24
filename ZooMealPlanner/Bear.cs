using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    class Bear : Mammal
    {
        public Bear(string Species, double Weight, double ratio, string food, string feedtime)
        {
            type = "Bear";
            species = Species;
            weight = Weight;
            ServingWeightRatio = ratio;
            FoodPreference = food;
            FeedTime = feedtime;
        }
    }
}
