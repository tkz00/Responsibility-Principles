using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja ninja = new Ninja();
            Giant giant = new Giant();
            Rat rat = new Rat();

            ninja.Attack();
            ninja.Stealth();

            giant.Attack();

            rat.Stealth();
        }
    }
}