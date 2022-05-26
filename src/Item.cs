namespace App
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public Quality Quality { get; set; }

        public virtual void UpdateQuality()
        {
            this.Quality--;
            
            if (this.SellIn < 0)
            {
                this.Quality--;
            }
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

    public class TicketItem : Item
    {
        public override void UpdateQuality()
        {
            if (this.SellIn < 0)
            {
                this.Quality = 0;
            }
            else
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
        }

        public override void UpdateSellIn()
        {
            base.UpdateSellIn();
        }
    }
}
