namespace LexicographicallySmallestEquivalentString.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        const string s1 = "parker";
        const string s2 = "morris";
        const string baseStr = "parser";
        
        const string result = "makkek";
        
        Assert.AreEqual(result, new Solution().SmallestEquivalentString(s1, s2, baseStr));
    }
    
    [Test]
    public void Test2()
    {
        const string s1 = "hello";
        const string s2 = "world";
        const string baseStr = "hold";
        
        const string result = "hdld";
        
        Assert.AreEqual(result, new Solution().SmallestEquivalentString(s1, s2, baseStr));
    }
    
    [Test]
    public void Test3()
    {
        const string s1 = "leetcode";
        const string s2 = "programs";
        const string baseStr = "sourcecode";
        
        const string result = "aauaaaaada";
        
        Assert.AreEqual(result, new Solution().SmallestEquivalentString(s1, s2, baseStr));
    }
    
    [Test]
    public void Test4()
    {
        const string s1 = "opecenadojbodihfgmpijpfocomhcncicefpohkibjckijghii";
        const string s2 = "ndlbhpaeppgekfhnjnmmplmdoifdhbglmedpjgleofgnahglbe";
        const string baseStr = "ttusuhhrabgsswpaapxoxdanchyccmpjitwwmfioedtbiggfru";
        
        const string result = "ttusuaaraaasswaaaaxaxaaaaayaaaaaatwwaaaaaataaaaaru";
        
        Assert.AreEqual(result, new Solution().SmallestEquivalentString(s1, s2, baseStr));
    }
}