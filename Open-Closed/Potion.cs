using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public class Potion : IConsumable
    {
        private int effect;

        public Potion(int Effect)
        {
            this.effect = Effect;
        }

        public int Consume(int CurrentHP)
        {
            return CurrentHP + this.effect;
        }
    }
}
