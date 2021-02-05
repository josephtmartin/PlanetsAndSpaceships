using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            //added supiter and saturn to list
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            //created new list
            var lastTwoPlanets = new List<string> { "Uranus, Neptune" };

            //combined the two lists
            planetList.AddRange(lastTwoPlanets);

            //used insert to add earth and venus
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            //add pluto to the end of the list
            planetList.Add("Pluto");

            //create a list to hold the rocky planets
            var rockyPlanets = new List<string>();

            //use getRange to extract the rocky ones
            var rockPlanets = planetList.GetRange(0, 4);
            rockyPlanets.AddRange(rockPlanets);

            //remove pluto
            planetList.Remove("Pluto");

            //dictionary
            var spacecrafts = new Dictionary<string, List<string>>();
            spacecrafts.Add("Mercury", new List<string> { "Mariner 10", "Messenger", "BepiColombo" });
            spacecrafts.Add("Venus", new List<string> { "Mariner 2", "Mariner 5", "Venera" });
            spacecrafts.Add("Mars", new List<string> { "Viking", "Opportunity", "Curiousity" });
            spacecrafts.Add("Jupiter", new List<string> { "Juno", "New Horizons" });
            spacecrafts.Add("Uranus", new List<string> { "Voyager 2" });
            spacecrafts.Add("Neptune", new List<string> { "Voyager 2" });
            spacecrafts.Add("Pluto", new List<string> { "New Horizons" });

            foreach (var item in spacecrafts)
            {
                Console.WriteLine($"{item.Key} : {string.Join(", ", item.Value)}");
            }
        }
    }
}
