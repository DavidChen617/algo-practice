namespace NeedCode._53_MaxSubArray;

public class Solution2
{
    public int MaxSubArray(int[] nums)
    {
        int result = nums[0],
            curSum = 0;

        foreach (var num in nums)
        {
            if (curSum < 0)
                curSum = 0;
            
            curSum += num;
            result = Math.Max(result, curSum);
        }
        
        return result;
    }

}
