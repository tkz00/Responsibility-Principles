using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    class Bass : IInstrument
    {
        public void Play()
        {
            Console.WriteLine("Reproduciendo sonido de bajo.");
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + "\\bassD049.wav";
            player.LoadAsync();
            player.PlaySync();
            Console.Clear();
        }
    }
}
