using System.Collections.Generic;

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
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0, Type = ItemType.ImprovesItself},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80, Type = ItemType.Legendary},
                new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20,
                        Type = ItemType.ImprovesItself
                    },
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            for(var i = 0; i < iterations; i++)
            {
                foreach(var item in Items)
                {
                    item.UpdateSellIn();
                    item.UpdateQuality();
                }
            }
        }
    }
}
