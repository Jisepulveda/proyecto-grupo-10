﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmulator.Classes.nsGame.nsMap.nsTerrains.nsBuilds.nsProductions
{
    abstract class Production:Build
    {
        protected int health;
        protected int water;
        protected int maturity;
        protected double finalProduction;
        protected bool disease;
    }
}
