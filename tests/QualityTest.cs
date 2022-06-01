using App;
using App.Items;
using NUnit.Framework;

namespace tests;

[TestFixture]
public class QualityTest
{
    [Test]
    public void It_increments()
    {
        var it = new Quality(12);
        it++;

        Assert.That(it.value, Is.EqualTo(13));
    }

    [Test]
    public void It_decrements()
    {
        var it = new Quality(12);
        it--;

        Assert.That(it.value, Is.EqualTo(11));
    }
}