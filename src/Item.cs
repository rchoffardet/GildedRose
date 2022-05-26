namespace App
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public Quality Quality { get; set; }

        public virtual void UpdateQuality()
        {
            if (this.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                this.Quality++;

                if (this.SellIn < 11)
                {
                    this.Quality++;
                }

                if (this.SellIn < 6)
                {
                    this.Quality++;
                }
            }
            else
            {
                this.DecrementQuality();
            }

            if (this.SellIn < 0)
            {
                if (this.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    this.Quality = 0;
                }
                else
                {
                    this.DecrementQuality();
                }
            }
        }

        public void DecrementQuality()
        {
            this.Quality--;
        }

        public virtual void UpdateSellIn()
        {
            this.SellIn--;
        }
    }

    public class LegendaryItem : Item
    {
        public override void UpdateQuality()
        {
            // do nothing
        }

        public override void UpdateSellIn()
        {
            // do nothing
        }
    }

    public class CheeseItem : Item
    {
        public override void UpdateQuality()
        {
            this.Quality++;

            if(this.SellIn < 0)
            {
                this.Quality++;
            }
        }

        public override void UpdateSellIn()
        {
            base.UpdateSellIn();
        }
    }
}
