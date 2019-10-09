using System;
using System.Collections.Generic;
using System.Text;

namespace SandwichFactory
{
    public class Subway : SandwichStore
    {
        public override Sandwich CreateSandwich(string type)
        {
            switch (type)
            {
                case "vegan":
                    return new VeganSub();
                case "meat":
                    return new AllMeatSub();
            }

            return null;
        }
    }
}
