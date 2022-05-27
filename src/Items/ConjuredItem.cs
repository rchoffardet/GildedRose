namespace App.Items;

public class ConjuredItem : Item
{
    protected override void UpdateQuality()
    {
        this.Quality -= 2;

        if (this.SellIn < 0)
        {
            this.Quality -= 2;
        }
    }
}
