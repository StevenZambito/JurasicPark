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

        public void Description()
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Diet Type: {DietType}");
            Console.WriteLine($"Date Acquired: {WhenAcquired}");
            Console.WriteLine($"Weight: {Weight} lbs");
            Console.WriteLine($"Enclosure Number: {EnclosureNumber}");
            Console.WriteLine();
        }


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

            var userInput = Console.ReadLine().ToUpper().Trim();
            return userInput;
        }

        static Dino PromptAndFindDino(List<Dino> listOfDinosToSearch)
        {
            var nameOfDino = PromptForString("What is the name of the Dinosaur you are looking for? ");

            var foundDino = listOfDinosToSearch.Find(dino => dino.Name.ToUpper() == nameOfDino);

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

            var userHasChosenToQuit = false;

            while (userHasChosenToQuit == false)
            {
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

                if (userResponse == "VIEW")
                {
                    if (dinosaurs.Count == 0)
                    {
                        Console.WriteLine("There are no dinosaurs in the park.");
                    }
                    else
                    {
                        var orderedDinosaurs = dinosaurs.OrderBy(x => x.WhenAcquired);
                        foreach (var dino in orderedDinosaurs)
                        {
                            dino.Description();
                        }
                    }
                }


                if (userResponse == "ADD")
                {
                    Console.WriteLine();
                    Console.Write("What is the name of the dinosaur? ");
                    var newDinoName = Console.ReadLine().Trim();

                    Console.Write($"What is {newDinoName}'s diet type? ");
                    var newDinoDietType = Console.ReadLine().Trim();

                    var newWhenAcquired = DateTime.Now;

                    Console.Write($"What is {newDinoName}'s weight? ");
                    var newDinoWeightString = Console.ReadLine().Trim();
                    var newDinoWeight = int.Parse(newDinoWeightString);

                    Console.Write($"What is {newDinoName}'s enclosure number? ");
                    var newEnclosureNumberString = Console.ReadLine().Trim();
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
                if (userResponse == "REMOVE")
                {
                    var removedDino = PromptAndFindDino(dinosaurs);
                    dinosaurs.Remove(removedDino);
                    Console.WriteLine();
                    Console.WriteLine($"{removedDino.Name} has been removed from the park.");

                }
                if (userResponse == "TRANSFER")
                {
                    var transferDinoName = PromptAndFindDino(dinosaurs);
                    var newEnclosureNum = PromptForString("What is this dinosaurs new enclosure number?");
                    transferDinoName.EnclosureNumber = int.Parse(newEnclosureNum);
                    Console.WriteLine();
                    Console.WriteLine($"{transferDinoName.Name} has been transferred to enclosure number {transferDinoName.EnclosureNumber}.");
                    Console.WriteLine();
                }
                if (userResponse == "SUMMARY")
                {
                    var numOfHerb = dinosaurs.Count(x => x.DietType == "Herbivore");
                    var numOfCarn = dinosaurs.Count(x => x.DietType == "Carnivore");
                    Console.WriteLine();
                    Console.Write($"There are {numOfHerb} herbivores and {numOfCarn} carnivores in the park.");
                    Console.WriteLine();
                }
                if (userResponse == "QUIT")
                {
                    userHasChosenToQuit = true;
                }
            }

            BannerMessage("Goodbye!");

        }
    }
}
