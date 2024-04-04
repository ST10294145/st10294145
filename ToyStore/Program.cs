using System;
using System.Collections.Generic;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This is the list of toys offered to the custommer.
            More toys can be added in for more variety. */
            List<string> toyList = new List<string>();
            toyList.Add("Nerf Gun");
            toyList.Add("Hotwheel");
            toyList.Add("Lego");
            toyList.Add("Playstation 5");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello, what is your name?");
            string customerName = Console.ReadLine();
            Console.WriteLine(customerName + "...That is a nice name!");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("------------------------------------------");

            while (true)
            {
                Console.WriteLine("Here's our toy list:");
                foreach (string toy in toyList)
                {
                    Console.WriteLine(toy);
                }

                Console.WriteLine("Enter a toy name to get information:");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    //This gives the info for each toy and the price using a simple switch method within a while loop.
                    case "Nerf Gun":
                        Console.WriteLine("Nerf Gun is a popular toy for outdoor play. \nThe price of this toy is R55.");
                        break;
                    case "Hotwheel":
                        Console.WriteLine("Hotwheel is a brand of toy cars. \nThe price of this toy is R23.");
                        break;
                    case "Lego":
                        Console.WriteLine("Lego is a brand of building blocks. \nThe price of this toy is R300.");
                        break;
                    case "Videogame":
                        Console.WriteLine("This is a videogame console; that is used to play videogames e.g. Fortnite, Apex Legends, Assassins Creed, and other games. \nThe price of this toy is R12 000.");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Toy not found in the list.");
                         Console.ForegroundColor = ConsoleColor.Green; //This is to reset the colour to the default.
                        break;
                }

                Console.WriteLine("Would you like to pick a toy, " + customerName + "? (Yes/No)");
                string quit = Console.ReadLine().ToLower(); // Convert input to lowercase

                if (quit == "No")
                {
                    Console.WriteLine("That is fine and you should take your time.");
                }
                else if (quit == "Yes")
                {
                    Console.WriteLine("Excellent!");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter either 'Yes' or 'No'.");
                    Console.ForegroundColor = ConsoleColor.Green; //This is to reset the colour to the default.
                }
            }
        }
    }
}
