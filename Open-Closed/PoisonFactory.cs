using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public class PoisonFactory : PotionFactory
    {
        private const int LevelRequired = 15;

        public override Potion BrewPotion(Ingredient[] ingredients, int AlchemyLevel)
        {
            if (AlchemyLevel >= LevelRequired)
            {
                if (AlchemyLevel >= LevelRequired * 2)
                {
                    return new Potion(Math.Abs(ingredients.Aggregate(1, (a, b) => a * b.Effect)) * -4);
                }

                return new Potion(Math.Abs(ingredients.Sum(x => x.Effect)) * -2);
            }
            else
            {
                //Si no se tiene el nivel de alquimia requerido entonces se crea una poción con un efecto aleatorio.
                return new Potion(new Random(((int)DateTime.Now.Ticks)).Next(-150, +150));
            }
        }
    }
}