using System;
using System.Collections.Generic;
using System.Text;

namespace SandwichFactory
{
    public class PeanutButterAndJellySandwich : Sandwich
    {
        public PeanutButterAndJellySandwich()
        {
            Name = "Peanut Butter and Jelly Sandwich";
            Bread = "Regular White";
            Protein = "Peanut Butter";
            Toppings.Add("Jelly");
            Toppings.Add("Mayo");
            Toppings.Add("More Jelly");
        }
    }
}
