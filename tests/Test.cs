using AppItem = App.Items.Item;
using LegacyItem = Legacy.Item;
using NUnit.Framework;

namespace tests;

[TestFixture]
public class Tests
{
    [Test]
    public void App_and_legacy_mutates_state_the_same_way()
    {
        App.Program.Main(100);
        var app = App.Program.Items;

        Legacy.Program.Main(100);
        var legacy = Legacy.Program.Items;

        Assert.That(app, Is.EquivalentTo(legacy).Using<AppItem, LegacyItem>(IsEqual));
    }

    private bool IsEqual(AppItem a, LegacyItem b)
    {
        return a.Name == b.Name
            && a.Quality == b.Quality
            && a.SellIn == b.SellIn;
    } 
}