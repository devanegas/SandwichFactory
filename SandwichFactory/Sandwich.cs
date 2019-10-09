using System;
using System.Collections.Generic;
using System.Text;

namespace SandwichFactory
{
    public abstract class Sandwich
    {
        public string Name;
        public string Bread;
        public string Protein;
        public List<string> Toppings = new List<string>();
        public void CutBread()
        {
            Console.WriteLine("Cutting your: " + Bread + " bread\n");
        }
        public void PlaceProtein()
        {
            Console.WriteLine("Placing your protein: " + Protein + "\n");
        }
        public void PlaceToppings()
        {
            Console.WriteLine("Adding Toppings:\n");
            foreach(var topping in Toppings)
            {
                Console.WriteLine("> " + topping);
            }
        }
        public void Toast()
        {
            Console.WriteLine("\nToasting your Sandwich\n");
        }
        public void Box()
        {
            Console.WriteLine("Putting your Sandwich in a box! Ready to Go!\n");
        }
        public string GetName()
        {
            return Name;
        }
    }
}
