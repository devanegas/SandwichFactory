using System;
using System.Collections.Generic;
using System.Text;

namespace SandwichFactory
{
    public class AllMeatSub : Sandwich
    {
        public AllMeatSub()
        {
            Name = "All Meat Sub";
            Bread = "Bacon Wrapped";
            Protein = "Beef";
            Toppings.Add("More Beef");
            Toppings.Add("Chicken");
            Toppings.Add("Pork");
        }
    }
}
