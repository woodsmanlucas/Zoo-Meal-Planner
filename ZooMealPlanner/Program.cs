using System;

namespace ZooMealPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Bear("Polar", 100, 0.014, "berries, green vegetation, flowers, fruits, fish", "9AM and 3PM");
            mammal.PrintNutritionInfo();


            Console.WriteLine("================");
            Console.WriteLine("Zoo Menu Planner");
            Console.WriteLine("================");
            Console.WriteLine("1. Monkey");
            Console.WriteLine("2. Bear");
            Console.WriteLine("9. Quit");
            Console.WriteLine("Selection:");
            string line = Console.ReadLine();
            int selection = 0;
            try
            {
                selection = Int32.Parse(line);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            while (selection != 9)
            {

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Species");
                        Console.WriteLine("--------");
                        Console.WriteLine("1.Squirrel");
                        Console.WriteLine("2.Howler");
                        Console.WriteLine("3.Colobus");
                        Console.WriteLine("9.Quit");
                        line = Console.ReadLine();
                        try
                        {
                            selection = Int32.Parse(line);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        string species = null;
                        double ratio = 0;
                        string food = "fresh fruit, vegetables, nuts, insects, berries";
                        string feedtime = "9AM, 12PM and 5PM.";
                        switch (selection)
                        {
                            case 1:
                                species = "Squirrel";
                                ratio = 0.006;
                                break;
                            case 2:
                                species = "Howler";
                                ratio = 0.007;
                                break;
                            case 3:
                                species = "Colobus";
                                ratio = 0.008;
                                break;
                            default:
                                Console.WriteLine("Please Choose a Monkey");
                                break;
                        }
                        Console.WriteLine($"How much does this {species} Monkey weight?");
                        line = Console.ReadLine();
                        int weight = 0;
                        try
                        {
                            weight = Int32.Parse(line);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        if (species != null && weight != 0)
                        {
                            mammal = new Monkey(species, weight, ratio, food, feedtime);
                            mammal.PrintNutritionInfo();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Species");
                        Console.WriteLine("--------");
                        Console.WriteLine("1.Polar");
                        Console.WriteLine("2.Black");
                        Console.WriteLine("9.Quit");
                        line = Console.ReadLine();
                        try
                        {
                            selection = Int32.Parse(line);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        species = null;
                        ratio = 0;
                        food = "berries, fish";
                        feedtime = "9AM and 3PM.";
                        switch (selection)
                        {
                            case 1:
                                species = "Polar";
                                ratio = 0.014;
                                break;
                            case 2:
                                species = "Black";
                                ratio = 0.016;
                                food += ", flowers, green vegitation, fruit";
                                break;
                            default:
                                Console.WriteLine("Please Choose a Bear");
                                break;
                        }
                        Console.WriteLine($"How much does this {species} Bear weight?");
                        Console.ReadLine();

                        if (species != null)
                        {
                            mammal = new Bear(species, 100, ratio, food, feedtime);
                            mammal.PrintNutritionInfo();
                        }
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Please rerun the program and select a value as provided");
                        break;
                }

                Console.WriteLine("================");
                Console.WriteLine("Zoo Menu Planner");
                Console.WriteLine("================");
                Console.WriteLine("1. Monkey");
                Console.WriteLine("2. Bear");
                Console.WriteLine("9. Quit");
                Console.WriteLine("Selection:");
                line = Console.ReadLine();
                try
                {
                    selection = Int32.Parse(line);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
    }
}
