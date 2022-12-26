namespace JumpGame;

public class Solution
{
    public bool CanJump(int[] nums)
    {
        var maxJump = 0;

        for (var i = 0; i <= maxJump && maxJump < nums.Length - 1; i++)
        {
            int currentJump = i + nums[i];
            
            if(currentJump > maxJump)
                maxJump = currentJump;
        }

        return maxJump >= nums.Length - 1;
    }
}