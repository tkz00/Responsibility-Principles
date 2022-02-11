using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Single_Responsibility
{
    class MessageBoxNotificationService : IPlayerNotificationService
    {
        public void NotifyPlayer(string message)
        {
            MessageBox.Show(message);
        }
    }
}
