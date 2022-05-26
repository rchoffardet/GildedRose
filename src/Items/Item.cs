namespace App.Items;

public class Item
{
    public string Name { get; set; }

    public int SellIn { get; set; }

    public Quality Quality { get; set; }

    protected virtual void UpdateQuality()
    {
        this.Quality--;
        
        if (this.SellIn < 0)
        {
            this.Quality--;
        }
    }

    protected virtual void UpdateSellIn()
    {
        this.SellIn--;
    }

    public void Update()
    {
        this.UpdateQuality();
        this.UpdateSellIn();
    }
}
