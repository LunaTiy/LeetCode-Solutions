namespace MinimumFallingPathSum.Tests;

public class MinimumFallingPathSumTests
{
    [Test]
    public void TestCase1()
    {
        int[][] matrix =
        {
            new[] {2, 1 , 3},
            new[] {6, 5, 4},
            new[] {7, 8, 9}
        };
        
        Assert.AreEqual(13, new Solution().MinFallingPathSum(matrix));
    }
    
    [Test]
    public void TestCase2()
    {
        int[][] matrix =
        {
            new[] {-19, 57},
            new[] {-40, -5},
        };
        
        Assert.AreEqual(-59, new Solution().MinFallingPathSum(matrix));
    }
    
    [Test]
    public void TestCase3()
    {
        int[][] matrix =
        {
            new[] {100, -42 , -46, -41},
            new[] {31, 97, 10, -10},
            new[] {-58, -51, 82, 89},
            new[] {51, 81, 69, -51}
        };
        
        Assert.AreEqual(-36, new Solution().MinFallingPathSum(matrix));
    }
}