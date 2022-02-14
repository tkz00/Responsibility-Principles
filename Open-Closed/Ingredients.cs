using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public class Ingredient : IConsumable
    {
        private string name;
        private int effect;

        public int Effect
        {
            get
            {
                return this.effect;
            }
        }

        public Ingredient(string Name, int Effect)
        {
            this.name = Name;
            this.effect = Effect;
        }

        public int Consume(int CurrentHP)
        {
            return CurrentHP + this.effect;
        }
    }
}
