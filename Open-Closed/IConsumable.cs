﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public interface IConsumable
    {
        int Consume(int CurrentHP);
    }
}
