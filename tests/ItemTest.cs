using App;
using App.Items;
using NUnit.Framework;

namespace tests;

[TestFixture]
[TestOf(typeof(Item))]
public class ItemTest
{
    [Test]
    public void Item_lose_quality_and_sellin_and_twice_where_sellin_is_negative()
    {
        var fresh = new Item{ Quality = 10, SellIn = 10 };
        fresh.Update();

        Assert.That(fresh.Quality.value, Is.EqualTo(9));
        Assert.That(fresh.SellIn, Is.EqualTo(9));

        
        var stalled = new Item{ Quality = 10, SellIn = -1 };
        stalled.Update();

        Assert.That(stalled.Quality.value, Is.EqualTo(8));
        Assert.That(stalled.SellIn, Is.EqualTo(-2));
    }

    [Test]
    public void Legendary_item_cannot_lose_quality_nor_sellin()
    {
        var it = new LegendaryItem { Quality = 10, SellIn = 10};
        it.Update();

        Assert.That(it.Quality.value, Is.EqualTo(10));
        Assert.That(it.SellIn, Is.EqualTo(10));
    }

    [Test]
    public void Cheese_item_gains_twice_as_much_quality_when_sellin_is_negative()
    {
        var fresh = new CheeseItem { Quality = 10, SellIn = 10};
        fresh.Update();

        Assert.That(fresh.Quality.value, Is.EqualTo(11));
        Assert.That(fresh.SellIn, Is.EqualTo(9));

        var matured = new CheeseItem { Quality = 10, SellIn = -1};
        matured.Update();

        Assert.That(matured.Quality.value, Is.EqualTo(12));
        Assert.That(matured.SellIn, Is.EqualTo(-2));
    }

    [Test]
    public void Ticket_item_gains_twice_as_much_quality_when_sellin_is_10_and_triple_when_5()
    {
        var normal = new TicketItem { Quality = 10, SellIn = 11};
        normal.Update();

        Assert.That(normal.Quality.value, Is.EqualTo(11));
        Assert.That(normal.SellIn, Is.EqualTo(10));

        var closeToDate = new TicketItem { Quality = 10, SellIn = 10};
        closeToDate.Update();

        Assert.That(closeToDate.Quality.value, Is.EqualTo(12));
        Assert.That(closeToDate.SellIn, Is.EqualTo(9));

        var almostClosest = new TicketItem { Quality = 10, SellIn = 6};
        almostClosest.Update();

        Assert.That(almostClosest.Quality.value, Is.EqualTo(12));
        Assert.That(almostClosest.SellIn, Is.EqualTo(5));

        var closest = new TicketItem { Quality = 10, SellIn = 5};
        closest.Update();

        Assert.That(closest.Quality.value, Is.EqualTo(13));
        Assert.That(closest.SellIn, Is.EqualTo(4));
    }

    [Test]
    public void Conjured_item_loses_twice_as_quality_as_regular()
    {
        var fresh = new ConjuredItem{ Quality = 10, SellIn = 10 };
        fresh.Update();

        Assert.That(fresh.Quality.value, Is.EqualTo(8));
        Assert.That(fresh.SellIn, Is.EqualTo(9));

        
        var stalled = new ConjuredItem{ Quality = 10, SellIn = -1 };
        stalled.Update();

        Assert.That(stalled.Quality.value, Is.EqualTo(6));
        Assert.That(stalled.SellIn, Is.EqualTo(-2));
    }
}