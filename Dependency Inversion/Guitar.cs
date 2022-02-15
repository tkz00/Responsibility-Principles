using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    class Guitar : IInstrument
    {
        public void Play()
        {
            Console.WriteLine("Reproduciendo sonido de guitarra.");
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + "\\sfx-guitar3.wav";
            player.LoadAsync();
            player.PlaySync();
            Console.Clear();
        }
    }
}
