using System;
using System.Collections.Generic;
using System.Linq;

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

        static string PromptForString(string prompt)
        {
            Console.WriteLine(prompt);

            var userInput = Console.ReadLine();
            return userInput;
        }

        static Dino PromptAndFindDino(List<Dino> listOfDinosToSearch)
        {
            var nameOfDino = PromptForString("What is the name of the Dinosaur you are looking for? ");

            var foundDino = listOfDinosToSearch.Find(dino => dino.Name == nameOfDino);

            return foundDino;
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

            var userResponse = PromptForString("Which option would you like to choose?");

            if (userResponse == "View")
            {
                var orderedDinosaurs = dinosaurs.OrderBy(x => x.WhenAcquired);
                foreach (var dino in orderedDinosaurs)
                {
                    Console.Write(dino.Name);
                }
            }
            else if (userResponse == "View" && dinosaurs.Count == 0)
            {
                return Console.WriteLine("There are no dinosaurs in the park.");
            };

            if (userResponse == "Add")
            {
                Console.Write("What is the name? ");
                var newDinoName = Console.ReadLine();

                Console.Write("What is the diet type? ");
                var newDinoDietType = Console.ReadLine();

                Console.Write("When was the dinosaur acquired? ");
                var newWhenAcquired = DateTime();

                Console.Write("What is the dinosaurs weight? ");
                var newDinoWeightString = Console.ReadLine();
                var newDinoWeight = int.Parse(newDinoWeightString);

                Console.Write("What is the enclosure number? ");
                var newEnclosureNumberString = Console.ReadLine();
                var newEnclosureNumber = int.Parse(newEnclosureNumberString);


                var newDino = new Dino()
                {
                    Name = newDinoName,
                    DietType = newDinoDietType,
                    WhenAcquired = newWhenAcquired,
                    Weight = newDinoWeight,
                    EnclosureNumber = newEnclosureNumber,
                };

                dinosaurs.Add(newDino);

            }
            if (userResponse == "Remove")
            {
                var removedDino = PromptAndFindDino(dinosaurs);
                dinosaurs.Remove(removedDino);

            }
            if (userResponse == "Transfer")
            {
                var transferDinoName = PromptAndFindDino(dinosaurs);
                var newEnclosureNum = PromptForString("What is this dinosaurs new enclosure number?");
                transferDinoName.EnclosureNumber = int.Parse(newEnclosureNum);
            }
            if (userResponse == "Summary")
            {
                var numOfHerb = dinosaurs.Count(x => x.DietType == "Herbivore");
                var numOfCarn = dinosaurs.Count(x => x.DietType == "Carnivores");

                Console.Write($"There are {numOfHerb} herbivores and {numOfCarn} carnivores in the park.");
            }
            BannerMessage("Goodbye!");

        }
    }
}
