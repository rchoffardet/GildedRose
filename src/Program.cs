﻿using System.Collections.Generic;
using App.Items;

namespace App
{
    public class Program
    {
        public static IList<Item> Items;
        public static void Main(int iterations)
        {
            Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new CheeseItem {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new LegendaryItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new TicketItem {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            for(var i = 0; i < iterations; i++)
            {
                foreach(var item in Items)
                {
                    item.Update();
                }
            }
        }
    }
}
