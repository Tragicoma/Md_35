using System;
using System.Collections.Generic;

namespace Md_35
{
    class Program
    {
        static void Main(string[] args)
        {
            var rm = new RouteManager();
            int input;

            while (true)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Menu: \n1-Add route \n2-See list of routes \n3-Exit");
                Console.WriteLine("---------------------------------------------------");

                while (true)
                {

                    try
                    {
                        input = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter a valid number!");
                        continue;
                    }
                }

                Menu menu = (Menu)input;
                switch (menu)
                {
                    case Menu.Add:
                        rm.AddRoute();
                        break;
                    case Menu.SeeList:
                        rm.SeeRouteList();
                        break;
                    case Menu.Exit:
                        Console.WriteLine("Shutting down...");
                        return;
                    default:
                        Console.WriteLine("Unknown command :(");
                        continue;
                }

            }
        }

    }
}
