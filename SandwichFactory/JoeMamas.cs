using System;
using System.Collections.Generic;
using System.Text;

namespace SandwichFactory
{
    public class JoeMamas : SandwichStore
    {
        public override Sandwich CreateSandwich(string type)
        {
            switch (type)
            {
                case "peanut butter and jelly":
                    return new PeanutButterAndJellySandwich();
                case "knuckles":
                    return new KnucklesSandwich();
            }

            return null;
        }
    }
}
