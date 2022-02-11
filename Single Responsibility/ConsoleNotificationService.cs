using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    class ConsoleNotificationService : IPlayerNotificationService
    {
        public void NotifyPlayer(string message)
        {
            Console.WriteLine(message);
        }
    }
}
