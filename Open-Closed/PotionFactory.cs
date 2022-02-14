using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public abstract class PotionFactory
    {
        public abstract Potion BrewPotion(Ingredient[] ingredients, int AlchemyLevel);
    }
}
