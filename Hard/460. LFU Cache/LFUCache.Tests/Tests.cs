namespace LFUCache.Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        var cache = new LFUCache(2);
        cache.Put(1, 1);
        cache.Put(2, 2);

        Assert.AreEqual(1, cache.Get(1));

        cache.Put(3, 3);
        Assert.AreEqual(-1, cache.Get(2));
        Assert.AreEqual(3, cache.Get(3));

        cache.Put(4, 4);
        Assert.AreEqual(-1, cache.Get(1));
        Assert.AreEqual(3, cache.Get(3));
        Assert.AreEqual(4, cache.Get(4));
    }
}