namespace NeedCode._136_SingleNumber;

public class Solution2
{

    public int SingleNumber(int[] nums)
    {
        var res = 0;
        
        for (int i = 0; i < nums.Length; i++)
            res ^= nums[i];
        
        return res;
    }
}
