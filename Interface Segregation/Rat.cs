using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    class Rat : IStealth
    {
        public void Stealth()
        {
            Console.WriteLine("La rata ha entrado en modo sigiloso.");
        }
    }
}
