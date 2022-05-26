using App;
using NUnit.Framework;

namespace tests;

[TestFixture]
[TestOf(typeof(Item))]
public class ItemTest
{
    [Test]
    public void Legendary_item_cannot_lose_quality_nor_sellin()
    {
        var it = new LegendaryItem { Quality = 10, SellIn = 10};
        it.UpdateQuality();
        it.UpdateSellIn();

        Assert.That(it.Quality.value, Is.EqualTo(10));
        Assert.That(it.SellIn, Is.EqualTo(10));
    }

}