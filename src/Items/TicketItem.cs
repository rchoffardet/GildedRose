namespace App.Items;

public class TicketItem : Item
{
    protected override void UpdateQuality()
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

    protected override void UpdateSellIn()
    {
        base.UpdateSellIn();
    }
}
