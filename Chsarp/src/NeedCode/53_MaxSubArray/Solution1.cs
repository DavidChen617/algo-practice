namespace NeedCode._53_MaxSubArray;

public class Solution1
{
    public int MaxSubArray(int[] nums)
    {
        int n = nums.Length,
            result = nums[0];
        
        for (int i = 0; i < n; i++)
        {
            var cur = 0;
            for (int j = i; j < n; j++)
            {
                cur += nums[j];
                result = Math.Max(result, cur);
            }
        }
        
        return result;
    }
}
