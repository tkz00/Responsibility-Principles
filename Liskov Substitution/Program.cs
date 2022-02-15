using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            //NPC npc = new Enemy("orco", 15);

            //Console.WriteLine(npc.Interact());

            //npc = new Ally("Jorge");

            //Console.WriteLine(npc.Interact());

            NPC[] npcArray = { new Enemy("Orco", 15), new Ally("Jorgito") };

            foreach(NPC npc in npcArray)
            {
                Console.WriteLine(npc.Interact());
            }

        }
    }
}
