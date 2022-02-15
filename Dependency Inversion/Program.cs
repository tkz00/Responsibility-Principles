using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guitar g = new Guitar();

            //g.Play();

            //Console.Clear();

            //Bass b = new Bass();

            //b.Play();

            //Console.Clear();

            Guitar g = new Guitar();
            Bass b = new Bass();

            IInstrument[] instruments = { new Guitar(), new Bass() };

            foreach(IInstrument instrument in instruments)
            {
                instrument.Play();
            }
        }
    }
}
