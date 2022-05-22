namespace App
{
    public class Item
    {
        public string Name { get; set; }
        public ItemType Type { get; set; } = ItemType.Other;

        public int SellIn { get; set; }

        public Quality Quality { get; set; }

        public void UpdateQuality()
        {
            if (this.Name != "Aged Brie" && this.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                this.DecrementQuality();
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
                        this.DecrementQuality();
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

        public void DecrementQuality()
        {
            if(this.Type != ItemType.Legendary)
            {
                this.Quality--;
            }
        }
    }

    public enum ItemType
    {
        Other,
        Legendary
    }
}
