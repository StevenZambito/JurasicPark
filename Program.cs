using System;

namespace JurasicPark
{
    class Dino
    {
        public string Name { get; set; }
        public string DietType { get; set; }
        public string WhenAcquired { get; set; }
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
            BannerMessage("Welcome to Jurassic Park!");

            BannerMessage("Goodbye!");
        }
    }
}
