using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    class Giant : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("El gigante te ha atacado.");
        }
    }
}
