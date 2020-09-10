﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmulator.Classes.nsGame.nsMap.nsTerrains.nsBuilds.nsProductions.nsProducts;

namespace Farmulator.Classes.nsGame.nsMarket
{
    class PriceProduct
    {
        private Product product;
        private int initialPrice;
        private int maxPriceVariation;
        private List<int> pricesHistory;

        //CONSTRUCTOR
        public PriceProduct(Product product, int initialPrice, int maxPriceVariation)
        {
            this.product = product;
            this.initialPrice = initialPrice;
            this.maxPriceVariation = maxPriceVariation;
            this.pricesHistory = new List<int>();
        }

        //ACCESO
        public Product GetProduct()
        {
            return this.product;
        }
        public List<int> GetPricesHistory()
        {
            return this.pricesHistory;
        }

        public int GetInitialPrice()
        {
            return this.initialPrice;
        }

        public int GetMaxPriceVariation()
        {
            return this.maxPriceVariation;
        }

        //METODOS
        public void AddPrice(int price)
        {
            this.pricesHistory.Add(price);
        }
    }
}