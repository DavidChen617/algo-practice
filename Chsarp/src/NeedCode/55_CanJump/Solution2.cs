namespace NeedCode._55_CanJump;

public class Solution2
{
    public bool CanJump(int[] nums)
    {
        int n = nums.Length - 1;
        return DFS(0);

        bool DFS(int index)
        {
            if(index == n)
                return true;

            var end = Math.Min(n, index + nums[index]);
            
            for (int j = index + 1; j <= end; j++)
            {
                if(DFS(j))
                    return true;
            }

            return false;
        }
    }
}
