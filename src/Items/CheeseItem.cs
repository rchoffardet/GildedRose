namespace App.Items;

public class CheeseItem : Item
{
    protected override void UpdateQuality()
    {
        this.Quality++;

        if(this.SellIn < 0)
        {
            this.Quality++;
        }
    }
}
