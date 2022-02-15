using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public class Enemy : NPC
    {
        private int damage;
        public Enemy(string Name, int Damage) : base(Name)
        {
            this.damage = Damage;
        }

        public override string Interact()
        {
            return base.name + " te ha atacado, y has recibido " + this.damage + " puntos de daño.";
        }
    }
}
