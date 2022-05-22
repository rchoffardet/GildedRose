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
            if (this.Type == ItemType.ImprovesItself)
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
            else
            {
                this.DecrementQuality();
                
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

        public void UpdateSellIn()
        {
            if(this.Type != ItemType.Legendary)
            {
                this.SellIn--;
            }
        }
    }

    public enum ItemType
    {
        Other,
        Legendary,
        ImprovesItself
    }
}
