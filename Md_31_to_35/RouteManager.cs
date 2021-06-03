using System;
using System.Collections.Generic;
using System.Text;

namespace Md_35
{
    class RouteManager
    {
        public List<Route> routes = new List<Route>();
        public void AddRoute()
        {

            Route route = new Route();
            int numberOfCrossings;

            Console.WriteLine("Let's go for a ride... what will we call this route?");
            route.name = Console.ReadLine();

            Console.WriteLine("How many crossings does this route have?");
            while (true)
            {
                try
                {
                    numberOfCrossings = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number, try again!");
                    continue;
                }
            }

            route.crossings = new bool[numberOfCrossings];

            for (int i = 0; i < route.crossings.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"Can we pass crossing nr.{i+1}? (true/false)");
                        route.crossings[i] = bool.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("type 'true' or 'false'");
                        continue;
                    }

                    break;
                }
            }

            route.fullyOpen = true;
            foreach (var crossing in route.crossings)
            {
                if(!crossing)
                { route.fullyOpen = false; }
            }

            routes.Add(route);
        }

        public void SeeRouteList()
        {
            foreach (var route in routes)
            {
                Console.WriteLine(route.name.ToUpper());
                Console.WriteLine($"Number of crossings: {route.crossings.Length}");
                Console.WriteLine($"Fully open: {route.fullyOpen}");
                Console.WriteLine("---------------------------");
            }
        }

    }
}
