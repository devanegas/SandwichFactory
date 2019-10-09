using System;
using System.Collections.Generic;
using System.Text;

namespace SandwichFactory
{
    public class KnucklesSandwich : Sandwich
    {
        public KnucklesSandwich()
        {
            Name = "Knuckles Sandwich";
            Bread = "Regular";
            Protein = "Some knuckles";
            Toppings.Add("A ring");
            Toppings.Add("Another ring");

        }
    }
}
