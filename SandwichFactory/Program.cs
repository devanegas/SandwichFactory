using System;

namespace SandwichFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichStore subway = new Subway();
            SandwichStore joeMamas = new JoeMamas();

            Sandwich sandwich = joeMamas.OrderSandwich("knuckles");
            Console.WriteLine("[ Ordered a " + sandwich.GetName() + " ]");

            Console.WriteLine("-----------------------------------------------");

            sandwich = subway.OrderSandwich("vegan");
            Console.WriteLine("[ Ordered a " + sandwich.GetName()+" ]");

        }
    }
}
