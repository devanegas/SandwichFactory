using System;
using System.Collections.Generic;
using System.Text;

namespace SandwichFactory
{
    public class VeganSub : Sandwich
    {
        public VeganSub()
        {
            Name = "Vegan Sub";
            Bread = "Gluten Free, GMO, Breadless, Blockchained";
            Protein = "Tofu";
            Toppings.Add("Lettuce");
            Toppings.Add("Celery");
            Toppings.Add("Grass");

        }
    }
}
