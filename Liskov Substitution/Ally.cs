using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public class Ally : NPC
    {
        public Ally(string Name) : base(Name) { }

        public override string Interact()
        {
            return this.name + " dice 'HOLA!'";
        }
    }
}
