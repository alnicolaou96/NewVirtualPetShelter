using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            string VolunteerOrAdopt;
            do
            {
                Console.WriteLine("Welcome to my shelter!");
                Console.WriteLine("are you here to adopt or volunteer?");
                VolunteerOrAdopt = Console.ReadLine().ToLower();
                Console.Clear();
            }
            while ((VolunteerOrAdopt != "volunteer")&&(VolunteerOrAdopt!="adopt"));
            //breaks the loop when the user appropriately answers the prompt

            if (VolunteerOrAdopt == "adopt")
            {
                Console.WriteLine("Which pet would you like to adopt?");
                Console.WriteLine("Animal 1");
                Console.WriteLine("Animal 2");
                Console.WriteLine("Animal 3");
                Console.WriteLine("Animal 4");
            }
            else if (VolunteerOrAdopt == "volunteer")
            {
                Console.WriteLine("Which job would you like to take on first?");
                Console.WriteLine("Clean cages");
                Console.WriteLine("Feed animals");
                Console.WriteLine("Walk animals");
            }

        }
    }
}
