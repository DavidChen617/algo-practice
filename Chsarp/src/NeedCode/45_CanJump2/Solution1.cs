namespace NeedCode._45_CanJump2;

public class Solution1
{
    public int Jump(int[] nums)
    {
        var n = nums.Length - 1;
        return DFS(0);

        int DFS(int index)
        {
            if (index == n)
                return 0;

            if (nums[index] == 0)
                return int.MaxValue;
            
            var end = Math.Min(n, index + nums[index]);
            var res = int.MaxValue;

            for (int i = index + 1; i <= end; i++)
            {
                res = Math.Min(res, 1 + DFS(i));
            }
            
            return res;
        }
    }
}
