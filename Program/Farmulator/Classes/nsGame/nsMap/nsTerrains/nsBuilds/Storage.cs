﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmulator.Classes.nsGame.nsMap.nsTerrains.nsBuilds
{
    class Storage:Build
    {
        private int maxCapacity;

        //CONSTRUCTOR
        public Storage(string name, int buyPrice, int sellPrice, int maxCapacity)
        {
            this.name = name;
            this.buyPrice = buyPrice;
            this.sellPrice = sellPrice;
            this.maxCapacity = maxCapacity;
        }
    }
}
