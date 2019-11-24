using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    class Monkey : Mammal
    {
        public Monkey(string Species, double Weight, double ratio, string food, string feedtime)
        {
            type = "Monkey";
            species = Species;
            weight = Weight;
            ServingWeightRatio = ratio;
            FoodPreference = food;
            FeedTime = feedtime;
        }
    }
}
