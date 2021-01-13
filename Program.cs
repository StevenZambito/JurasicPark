using System;
using System.Collections.Generic;

namespace JurasicPark
{
    class Dino
    {
        public string Name { get; set; }
        public string DietType { get; set; }
        public DateTime WhenAcquired { get; set; }
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }


    }


    class Program
    {
        static void BannerMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine(message);
            Console.WriteLine("-------------------------");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            var dinosaurs = new List<Dino>() {
            new Dino()
            {
              Name = "Rex",
              DietType = "Carnivore",
              WhenAcquired = DateTime.Now,
              Weight = 15000,
              EnclosureNumber = 1,
            },
            new Dino()
            {
              Name = "Camara",
              DietType = "Herbivore",
              WhenAcquired = DateTime.Now,
              Weight = 44000,
              EnclosureNumber = 2,
            },
            new Dino()
            {
              Name = "Brack",
              DietType = "Herbivore",
              WhenAcquired = DateTime.Now,
              Weight = 75000,
              EnclosureNumber = 3,
            },

          };

            BannerMessage("Welcome to Jurassic Park!");

            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine();
            Console.WriteLine("View");
            Console.WriteLine("Add");
            Console.WriteLine("Remove");
            Console.WriteLine("Transfer");
            Console.WriteLine("Summary");
            Console.WriteLine("Quit");
            Console.WriteLine();

            BannerMessage("Goodbye!");
        }
    }
}
