using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public class HealthPotionFactory : PotionFactory
    {
        private const int LevelRequired = 10;

        public override Potion BrewPotion(Ingredient[] ingredients, int AlchemyLevel)
        {
            if (AlchemyLevel >= LevelRequired)
            {
                if (AlchemyLevel >= LevelRequired * 2)
                {
                    //Como el nivel de alquimia del pj es más del doble requerido los efectos negativos de los ingredientes se revierten y se vuelven positivos.
                    return new Potion(ingredients.Aggregate(1, (a, b) => a * (b.Effect > -1 ? b.Effect : (b.Effect * -1))));
                }

                return new Potion(ingredients.Sum(x => x.Effect));
            }
            else
            {
                //Si no se tiene el nivel de alquimia requerido se generará una poción con un efecto aleatorio muy comunmente dañino.
                return new Potion(new Random(((int)DateTime.Now.Ticks)).Next(-500, 30));
            }
        }
    }
}
