using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj3
{
    public class FisherRegister
    {
        List<Fisher> fishers = new List<Fisher>();
        public void AddFisher(Fisher fisher)
        {
            fishers.Add(fisher);
        }
        public string PrintRegister()
        {
            string printedRegister = "All fishes in register:\n";
            foreach (Fisher fisher in fishers)
            {
                printedRegister = printedRegister + fisher.PrintFishes();
            }
            return printedRegister;
        }
    }
    public class Fisher
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        List<Fish> fishes = new List<Fish>();

        public Fisher(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
        public void AddFish(Fish fish)
        {
            fishes.Add(fish);
        }
        public string PrintFishes()
        {
            string allFishes = "Fisher " + Name + "has the following fishes:\n\n";
            foreach (Fish fish in fishes)
            {
                allFishes = allFishes + fish.ToString() + "\n";
            }
            return allFishes + "\n";
        }
        public override string ToString()
        {
            return "Fisherman: " + Name + " Phone: " + PhoneNumber; 
        }
    }
    public class Fish 
    {
        public string Species { get; set; }
        public int Lenght { get; set; }
        public double Weight { get; set; }
        public Location CatchLocation { get; set; }
        public Fish(string species, int lenght, double weight, Location catchLocation)
        {
            Species = species;
            Lenght = lenght;
            Weight = weight;
            CatchLocation = catchLocation;
        }
        public override string ToString()
        {
            return "- species: " + Species + " " + Lenght + " cm " + Weight + " kg\n" + CatchLocation.ToString() + "\n";
        }
    }
    public class Location
    {
        public string Place { get; set; }
        public string GeneralArea { get; set; }
        public Location(string place, string area)
        {
            Place = place;
            GeneralArea = area;
        }
        public override string ToString()
        {
            return "- place: " + Place + "\n- location: " + GeneralArea;
        }
    }
}
