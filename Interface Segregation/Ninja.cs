using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    class Ninja : IStealth, IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("El ninja te ha atacado.");
        }

        public void Stealth()
        {
            Console.WriteLine("El ninja entró en modo sigilo.");
        }
    }
}
