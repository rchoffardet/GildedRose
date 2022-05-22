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
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            for(var i = 0; i < iterations; i++)
            {
                foreach(var item in Items)
                {
                    item.UpdateQuality();
                }
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public Quality Quality { get; set; }

        public void UpdateQuality()
        {
            if (this.Name != "Aged Brie" && this.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (this.Name != "Sulfuras, Hand of Ragnaros")
                {
                    this.Quality--;
                }
            }
            else
            {
                this.Quality++;

                if (this.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (this.SellIn < 11)
                    {
                        this.Quality++;
                    }

                    if (this.SellIn < 6)
                    {
                        this.Quality++;
                    }
                }
                
            }

            if (this.Name != "Sulfuras, Hand of Ragnaros")
            {
                this.SellIn = this.SellIn - 1;
            }

            if (this.SellIn < 0)
            {
                if (this.Name != "Aged Brie")
                {
                    if (this.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (this.Name != "Sulfuras, Hand of Ragnaros")
                        {
                            this.Quality--;
                        }
                    }
                    else
                    {
                        this.Quality = 0;
                    }
                }
                else
                {
                    this.Quality++;
                }
            }
        }
    }
}
