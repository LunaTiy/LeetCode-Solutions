namespace RestoreIPAddresses.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        const string s = "25525511135";
        string[] addresses = { "255.255.11.135", "255.255.111.35" };
        
        Assert.AreEqual(addresses, new Solution().RestoreIpAddresses(s));
    }
}