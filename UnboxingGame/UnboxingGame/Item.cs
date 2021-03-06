﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame
{
    public class Item
    {
        public Item(string itemName, ItemRarity itemRarity, decimal itemPrice)
        {
            if (string.IsNullOrWhiteSpace(itemName))
                throw new ArgumentException(nameof(itemName));

            this.ItemName = itemName;
            this.ItemRarity = itemRarity;
            this.ItemPrice = itemPrice;
        }
        public string ItemName { get; set; }
        public ItemRarity ItemRarity { get; set; }

        /* 
         * Rarities:
         * Common = 50%
         * Rare = 30%
         * Epic = 15%
         * Mythical = 5%
         */
        public decimal ItemPrice { get; set; }
        /*
         * Price Range:
         * Common = $50-$500
         * Rare = $500-$1000
         * Epic = $1000-$3000
         * Mythical = $3000-$6000
         */
        
    }

    public enum ItemRarity
    {
        Common,
        Rare,
        Epic,
        Mythical
    }
}
