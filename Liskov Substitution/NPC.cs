﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public abstract class NPC
    {
        private protected string name;

        public NPC(string Name)
        {
            this.name = Name;
        }

        public abstract string Interact();
    }
}
