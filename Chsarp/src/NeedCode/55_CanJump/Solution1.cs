namespace NeedCode._55_CanJump;

public class Solution1
{
    public bool CanJump(int[] nums)
    {
        var maxReach = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if(i > maxReach)
                return false;
            maxReach = Math.Max(nums[i] + i, maxReach);
        }
        
        return true;
    }
}
