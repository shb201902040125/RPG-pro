﻿using RPG;
using RPG_pro.Basics.Mods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_pro.Basics.Interfaces
{
    internal interface IModType : ILoadable
    {
        Mod Mod { get; }
    }
}
