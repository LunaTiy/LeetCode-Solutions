namespace KeysAndRooms.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        IList<IList<int>> lists = new List<IList<int>>
            { new List<int> { 1 }, new List<int> { 2 }, new List<int> { 3 }, new List<int> { } };
        
        Assert.That(new Solution().CanVisitAllRooms(lists), Is.EqualTo(true));
    }
    
    [Test]
    public void Test2()
    {
        IList<IList<int>> lists = new List<IList<int>>
            { new List<int> { 1, 3 }, new List<int> { 3, 0, 1 }, new List<int> { 2 }, new List<int> { 0 } };
        
        Assert.That(new Solution().CanVisitAllRooms(lists), Is.EqualTo(false));
    }
}