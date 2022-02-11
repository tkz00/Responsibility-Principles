using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    class Character
    {
        public int health;
        private readonly IPlayerNotificationService playerNotificationService;

        public Character(IPlayerNotificationService playerNotificationService) : this(playerNotificationService, new Random(((int)DateTime.Now.Ticks)).Next(1,20)) { }

        public Character(IPlayerNotificationService playerNotificationService, int health)
        {
            this.health = health;
            this.playerNotificationService = playerNotificationService;
            this.playerNotificationService.NotifyPlayer("Tu personaje tiene " + this.health + " puntos de vida.");
        }

        public void TakeDamage(int damage)
        {
            this.playerNotificationService.NotifyPlayer("Has recibido " + damage + " puntos de daño.");
            this.health -= damage;

            if (this.health <= 0)
            {
                this.playerNotificationService.NotifyPlayer("Has muerto :(");
            }
        }
    }
}
