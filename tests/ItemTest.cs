using App;
using NUnit.Framework;

namespace tests;

[TestFixture]
[TestOf(typeof(Item))]
public class ItemTest
{
    [Test]
    public void Legendary_item_cannot_lose_quality()
    {
        var it = new Item { Type = ItemType.Legendary, Quality = 10};
        it.DecrementQuality();

        Assert.That(it.Quality.value, Is.EqualTo(10));
    }

}