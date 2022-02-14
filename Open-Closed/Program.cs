using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    class Program
    {
        static void Main(string[] args)
        {
            int CurrentHp = 100;
            int AlchemyLevel = 5;

            PotionFactory potionFactory = new HealthPotionFactory();
            Ingredient[] ingredients = { new Ingredient("Wheat", 10), new Ingredient("Red Mushroom", 30) };

            Console.WriteLine("¿Desea hacer una poción de vida (1) o un veneno (2)?");
            string potionType = Console.ReadLine();

            if(potionType == "1")
            {
                potionFactory = new HealthPotionFactory();
            }
            else if(potionType == "2")
            {
                potionFactory = new PoisonFactory();
            }

            Potion potion = potionFactory.BrewPotion(ingredients, AlchemyLevel);

            Console.WriteLine(potion.Consume(CurrentHp));
        }
    }
}