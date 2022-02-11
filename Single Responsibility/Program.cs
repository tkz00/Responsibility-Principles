using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muestra los mensajes a través de la consola
            //ConsoleNotificationService consoleNotificationService = new ConsoleNotificationService();
            //Character pc = new Character(consoleNotificationService);

            //Muestra los mensajes a través de un messageBox
            MessageBoxNotificationService messageBoxNotificationService = new MessageBoxNotificationService();
            Character pc = new Character(messageBoxNotificationService);

            pc.TakeDamage(new Random(((int)DateTime.Now.Ticks)).Next(1, 50));
        }
    }
}
