using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Menu
    {
        public static void Main(string[] args)
        {
            MenuItem spaghetti = new MenuItem(10, "main", "A simple pasta dish");
            if ((spaghetti.Created - DateTime.Now).TotalDays < 7) ;
            {
                Console.WriteLine("**New Item**");
            }
            Console.WriteLine("pasta: ${0} {1} - {2}", spaghetti.Price, spaghetti.Category, spaghetti.Description);
            Console.WriteLine("-----------");

            MenuItem pizza = new MenuItem(8, "main", "Small cheese pizza");
            if ((spaghetti.Created - DateTime.Now).TotalDays < 7) ;
            {
                Console.WriteLine("**New Item**");
            }
            Console.WriteLine("pizza: ${0} {1} - {2}", pizza.Price, pizza.Category, pizza.Description);
            Console.WriteLine("-----------");
            Console.ReadLine();
        }
    }


    public class MenuItem
    {
        private double price;
        private string category;
        private string description;
        readonly DateTime created = DateTime.UtcNow;

        public double Price { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        // Create a constructor
        public MenuItem(double price, string category, string description)
        {
            Price = price;
            Category = category;
            Description = description;
            Created = created;
        }

    }

}