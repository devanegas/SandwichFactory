using System;
using System.Collections.Generic;
using System.Text;

namespace SandwichFactory
{
    public abstract class SandwichStore
    {
        public Sandwich OrderSandwich(string type)
        {
            Sandwich sandwich;
            sandwich = CreateSandwich(type);

            sandwich.CutBread();
            sandwich.PlaceToppings();
            sandwich.Toast();
            sandwich.Box();

            return sandwich;
        }

        public abstract Sandwich CreateSandwich(string type);
    }
}
